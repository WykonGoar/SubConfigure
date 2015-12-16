using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubConfigure.Models.FileFormats.ASS.V4Plus
{
    public class V4PlusScriptInfo : IV4PlusScriptInfo
    {

        private V4PlusScriptInfoHeader mParameter;
        private string mValue;

        public V4PlusScriptInfo(V4PlusScriptInfoHeader parameter, string value)
        {
            mParameter = parameter;
            mValue = value;
        }

        public V4PlusScriptInfoHeader Parameter { get { return mParameter; } }

        public string Value { get { return mValue; } set { mValue = value; } }

        public string GetAsOutput()
        {
            EnumHelper<V4PlusScriptInfoHeader> helper = new EnumHelper<V4PlusScriptInfoHeader>();
            string description = helper.GetDescriptionFromEnum(mParameter);
            return description + ": " + mValue;
        }
    }
}
