using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubConfigure.Models.FileFormats.ASS.V4Plus
{
    public interface IV4PlusEvent : ISubtitleItem
    {
        int Layer { get; set; }
        string Start { get; set; }
        string End { get; set; }
        string Style { get; set; }
        string Name { get; set; }
        int MarginL { get; set; }
        int MarginR { get; set; }
        int MarginV { get; set; }
        string Effect { get; set; }
        string Text { get; set; }
        
        void MoveStartTime(int amount);
    
        void SetPropertyWithString(Enum enumValue, string value);

        string GetPropertyAsString(Enum enumValue);

        string GetAsOutput();
    }
}
