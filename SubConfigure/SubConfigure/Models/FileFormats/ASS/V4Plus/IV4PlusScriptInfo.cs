using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubConfigure.Models.FileFormats.ASS.V4Plus
{
    public interface IV4PlusScriptInfo : ISubtitleItem
    {
        V4PlusScriptInfoHeader Parameter { get; }
        string Value { get; set; }

        string GetAsOutput();
    }
}
