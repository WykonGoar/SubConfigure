using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubConfigure.Models.FileFormats
{
    public interface ISubtitleFile
    {
        FileType FileType { get; }

        void AddItem(ISubtitleItem item);

        bool RemoveItem(ISubtitleItem item);

        void ReplaceItem(ISubtitleItem oldItem, ISubtitleItem newItem);
                
        IList<string> GetAsOutput();

        void MoveEventTimes(string startRegion, string endRegion, int amount);
    }
}
