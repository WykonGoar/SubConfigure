using SubConfigure.Models.FileFormats;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubConfigure.Models
{
    public class FileWriter
    {
        public FileWriter() { }

        public bool CreateFile(string filePath, ISubtitleFile subtitleFile)
        {
            bool result = true;

            StreamWriter writer = new StreamWriter(filePath);

            IList<string> output = subtitleFile.GetAsOutput();

            foreach(string line in output)
            {
                writer.WriteLine(line);
            }

            writer.Close();

            return result;
        }
    }
}
