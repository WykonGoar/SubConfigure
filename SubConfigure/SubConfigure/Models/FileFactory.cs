using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubConfigure.Models
{
    public class FileFactory : IFileFactory
    {
        private static FileFactory mAssFileFactory;

        private FileFactory() { }

        public static IFileFactory GetInstance()
        {
            if (mAssFileFactory == null)
                mAssFileFactory = new FileFactory();

            return mAssFileFactory;
        }
    }
}
