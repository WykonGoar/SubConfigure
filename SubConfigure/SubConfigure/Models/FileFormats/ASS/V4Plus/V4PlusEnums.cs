using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SubConfigure.Models.FileFormats.ASS.V4Plus
{
    public enum V4PlusScriptInfoHeader
    {
        [Description("Title")]
        Title,
        [Description("ScriptType")]
        ScriptType,
        [Description("WrapStyle")]
        WrapStyle,
        [Description("PlayResX")]
        PlayResX,
        [Description("PlayResY")]
        PlayResY,
        [Description("ScaledBorderAndShadow")]
        ScaledBorderAndShadow,
        [Description("Last Style Storage")]
        LastStyleStorage,
        [Description("Audio File")]
        AudioFile,
        [Description("Video File")]
        VideoFile,
        [Description("Video Aspect Ratio")]
        VideoAspectRatio,
        [Description("Video Zoom")]
        VideoZoom,
        [Description("Video Position")]
        VideoPosition,
        [Description("Original Translation")]
        OriginalTranslation,
        [Description("Collisions")]
        Collisions,
    }

    public enum V4PlusStyleHeader
    {
        [Description("Name")]
        Name,
        [Description("Fontname")]
        Fontname,
        [Description("Fontsize")]
        Fontsize,
        [Description("PrimaryColour")]
        PrimaryColour,
        [Description("SecondaryColour")]
        SecondaryColour,
        [Description("OutlineColour")]
        OutlineColour,
        [Description("BackColour")]
        BackColour,
        [Description("Bold")]
        Bold,
        [Description("Italic")]
        Italic,
        [Description("Underline")]
        Underline,
        [Description("Strikeout")]
        Strikeout,
        [Description("ScaleX")]
        ScaleX,
        [Description("ScaleY")]
        ScaleY,
        [Description("Spacing")]
        Spacing,
        [Description("Angle")]
        Angle,
        [Description("BorderStyle")]
        BorderStyle,
        [Description("Outline")]
        Outline,
        [Description("Shadow")]
        Shadow,
        [Description("Alignment")]
        Alignment,
        [Description("MarginL")]
        MarginL,
        [Description("MarginR")]
        MarginR,
        [Description("MarginV")]
        MarginV,
        [Description("Encoding")]
        Encoding
    }

    public enum V4PlusEventHeader
    {
        [Description("Layer")]
        Layer,
        [Description("Start")]
        Start,
        [Description("End")]
        End,
        [Description("Style")]
        Style,
        [Description("Name")]
        Name,
        [Description("MarginL")]
        MarginL,
        [Description("MarginR")]
        MarginR,
        [Description("MarginV")]
        MarginV,
        [Description("Effect")]
        Effect,
        [Description("Text")]
        Text
    }
}
