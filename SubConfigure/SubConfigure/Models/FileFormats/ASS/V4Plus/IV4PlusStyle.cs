using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubConfigure.Models.FileFormats.ASS.V4Plus
{
    public interface IV4PlusStyle : ISubtitleItem
    {
        string Name { get; set; }
        int FontSize { get; set; }
        string PrimaryColour { get; set; }
        string SecondaryColour { get; set; }
        string OutlineColour { get; set; }
        string BackColour { get; set; }
        int Bold { get; set; }
        int Italic { get; set; }
        int Underline { get; set; }
        int Strikeout { get; set; }
        int ScaleX { get; set; }
        int ScaleY { get; set; }
        int Spacing { get; set; }
        int Angle { get; set; }
        int BorderStyle { get; set; }
        int Outline { get; set; }
        int Shadow { get; set; }
        int Alignment { get; set; }
        int MarginL { get; set; }
        int MarginR { get; set; }
        int MarginV { get; set; }
        int Encoding { get; set; }

        void SetPropertyWithString(Enum enumValue, string value);

        string GetPropertyAsString(Enum enumValue);

        string GetAsOutput();

    }
}
