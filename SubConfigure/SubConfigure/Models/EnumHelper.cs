using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SubConfigure.Models
{
    public class EnumHelper<T>
    {
        /// <summary>
        /// Gets all the descriptions for each enum value.
        /// </summary>
        /// <returns>Dictionary<string, T> The string is the description, T is the enum.</returns>
        public Dictionary<string, T> GetDescriptionsWithEnums()
        {
            Dictionary<string, T> descriptionsDictionary = new Dictionary<string, T>();
            
            foreach (T enumValue in GetEnumList())
            {
                string description = GetDescription(enumValue);
                descriptionsDictionary.Add(description, enumValue);
            }

            return descriptionsDictionary;
        }

        /// <summary>
        /// Gets all the enum value for each string.
        /// </summary>
        /// <returns>Dictionary<T, string> The string is the description, T is the enum.</returns>
        public Dictionary<T, string> GetEnumsWithDescriptions()
        {
            Dictionary<T, string> enumDictionary = new Dictionary<T, string>();

            foreach (T enumValue in GetEnumList())
            {
                string description = GetDescription(enumValue);
                enumDictionary.Add(enumValue, description);
            }

            return enumDictionary;
        }

        /// <summary>
        /// Get the enum value based on the description.
        /// </summary>
        /// <param name="description">The description of the enum value.</param>
        /// <returns>T The enum value.</returns>
        public T GetEnumFromDescription(string description)
        {
            try
            {
                Dictionary<string, T> descriptionDictionary = GetDescriptionsWithEnums();
                return descriptionDictionary[description];
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine("[EnumHelper] KeyNotFoundException : The description '{0}' was not found in the dictionary", description);
                Console.WriteLine(ex.StackTrace);
                throw ex;
            }
        }

        /// <summary>
        /// Get the description based on the enum value.
        /// </summary>
        /// <param name="en">The enum value of the description.</param>
        /// <returns>string The description</returns>
        public string GetDescriptionFromEnum(T en)
        {
            try
            {
                Dictionary<T, string> enumDictionary = GetEnumsWithDescriptions();
                return enumDictionary[en];
            }
            catch(Exception ex)
            {
                Console.WriteLine("[EnumHelper] exception :" + ex.StackTrace);
                return String.Empty;
            }
        }

        /// <summary>
        /// Get a enumerable of all the enums;
        /// </summary>
        /// <returns>Enumerable</returns>
        public IList<T> GetEnumList()
        {
            return Enum.GetValues(typeof(T)).Cast<T>().ToList<T>();
        }

        public IList<string> GetDescriptionList()
        {
            return GetDescriptionsWithEnums().Keys.ToList<string>();
        }

        private string GetDescription(T en)
        {
            Type type = en.GetType();

            MemberInfo[] memInfo = type.GetMember(en.ToString());

            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return en.ToString();
        }
    }
}
