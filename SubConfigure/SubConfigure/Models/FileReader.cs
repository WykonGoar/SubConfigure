using SubConfigure.Models.FileFormats;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubConfigure.Models.FileFormats.ASS;

namespace SubConfigure.Models
{
    public class FileReader
    {
        public FileReader() { }

        public ISubtitleFile ReadFile(string filePath)
        {
            if (!Path.HasExtension(filePath))
                throw new FileNotFoundException("Current file '" + filePath + "' has no extention.");

            string fileType = Path.GetExtension(filePath).ToLower();

            switch (fileType)
            {
                case ".ass":
                    ASSStyleType type = GetASSStyleType(filePath);
                    ASSReader assReader = new ASSReader();

                    return assReader.ReadFile(type, filePath);
            }

            return null;
        }

        private ASSStyleType GetASSStyleType(string filePath)
        {            
            StreamReader reader = new StreamReader(Path.GetFullPath(filePath));

            string type = String.Empty;

            while(!reader.EndOfStream &&  type == String.Empty)
            {
                string line = reader.ReadLine();
                if(line.Contains("ScriptType"))
                {
                    type = line.Substring(line.LastIndexOf(":") + 2).ToLower();
                }
            }

            reader.Close();
            switch(type)
            {
                case "v4.00+":
                    return ASSStyleType.V4Plus;
            }

            return ASSStyleType.V4Plus;
        }
    }
}
