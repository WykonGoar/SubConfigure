using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubConfigure.Models.FileFormats.ASS.V4Plus
{
    public interface IV4PlusFile : ISubtitleFile
    {
        IList<IV4PlusScriptInfo> GetScriptInfo();
        IList<IV4PlusStyle> GetStyles();
        IList<IV4PlusEvent> GetEvents();
    }
}
