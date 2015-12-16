using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubConfigure.Models.FileFormats.ASS.V4Plus
{
    public class V4PlusStyle : IV4PlusStyle
    {
        #region variablen
        private string mName;
        private string mFontName;
        private int mFontSize;
        private string mPrimaryColour;   
        private string mSecondaryColour;
        private string mOutlineColour;
        private string mBackColour;
        private int mBold;
        private int mItalic;
        private int mUnderline;
        private int mStrikeout;
        private int mScaleX;
        private int mScaleY;
        private int mSpacing;
        private int mAngle;
        private int mBorderStyle;
        private int mOutline;
        private int mShadow;
        private int mAlignment;
        private int mMarginL;
        private int mMarginR;
        private int mMarginV;
        private int mEncoding;
        #endregion
        
        public V4PlusStyle() { }

        #region Getters and setters
        public string Name { get { return mName; } set { mName = value; } }
        public string FontName { get { return mFontName; } set { mFontName = value; } }
        public int FontSize { get { return mFontSize; } set { mFontSize = value; } }
        public string PrimaryColour { get { return mPrimaryColour; } set { mPrimaryColour = value; } }
        public string SecondaryColour { get { return mSecondaryColour; } set { mSecondaryColour = value; } }
        public string OutlineColour { get { return mOutlineColour; } set { mOutlineColour = value; } }
        public string BackColour { get { return mBackColour; } set { mBackColour = value; } }
        public int Bold { get { return mBold; } set { mBold = value; } }
        public int Italic { get { return mItalic; } set { mItalic = value; } }
        public int Underline { get { return mUnderline; } set { mUnderline = value; } }
        public int Strikeout { get { return mStrikeout; } set { mStrikeout = value; } }
        public int ScaleX { get { return mScaleX; } set { mScaleX = value; } }
        public int ScaleY { get { return mScaleY; } set { mScaleY = value; } }
        public int Spacing { get { return mSpacing; } set { mSpacing = value; } }
        public int Angle { get { return mAngle; } set { mAngle = value; } }
        public int BorderStyle { get { return mBorderStyle; } set { mBorderStyle = value; } }
        public int Outline { get { return mOutline; } set { mOutline = value; } }
        public int Shadow { get { return mShadow; } set { mShadow = value; } }
        public int Alignment { get { return mAlignment; } set { mAlignment = value; } }
        public int MarginL { get { return mMarginL; } set { mMarginL = value; } }
        public int MarginR { get { return mMarginR; } set { mMarginR = value; } }
        public int MarginV { get { return mMarginV; } set { mMarginV = value; } }
        public int Encoding { get { return mEncoding; } set { mEncoding = value; } }
        #endregion
       
        public void SetPropertyWithString(Enum enumValue, string value)
        {
            V4PlusStyleHeader property;

            if (enumValue is V4PlusStyleHeader)
                property = (V4PlusStyleHeader)enumValue;
            else
                throw new ArgumentException("The enum type isn't correct. The type must be 'V4PlusStyleHeader'");

            switch(property)
            {
                case V4PlusStyleHeader.Name:
                    SetName(value);
                    break;
                case V4PlusStyleHeader.Fontname:
                    SetFontName(value);
                    break;
                case V4PlusStyleHeader.Fontsize:
                    SetFontSize(value);
                    break;
                case V4PlusStyleHeader.PrimaryColour:
                    SetPrimaryColour(value);
                    break;
                case V4PlusStyleHeader.SecondaryColour:
                    SetSecondaryColour(value);
                    break;
                case V4PlusStyleHeader.OutlineColour:
                    SetOutlineColour(value);
                    break;
                case V4PlusStyleHeader.BackColour:
                    SetBackColour(value);
                    break;
                case V4PlusStyleHeader.Bold:
                    SetBold(value);
                    break;
                case V4PlusStyleHeader.Italic:
                    SetItalic(value);
                    break;
                case V4PlusStyleHeader.Underline:
                    SetUnderline(value);
                    break;
                case V4PlusStyleHeader.Strikeout:
                    SetStrikeout(value);
                    break;
                case V4PlusStyleHeader.ScaleX:
                    SetScaleX(value);
                    break;
                case V4PlusStyleHeader.ScaleY:
                    SetScaleY(value);
                    break;
                case V4PlusStyleHeader.Spacing:
                    SetSpacing(value);
                    break;
                case V4PlusStyleHeader.Angle:
                    SetAngle(value);
                    break;
                case V4PlusStyleHeader.BorderStyle:
                    SetBorderStyle(value);
                    break;
                case V4PlusStyleHeader.Outline:
                    SetOutline(value);
                    break;
                case V4PlusStyleHeader.Shadow:
                    SetShadow(value);
                    break;
                case V4PlusStyleHeader.Alignment:
                    SetAlignment(value);
                    break;
                case V4PlusStyleHeader.MarginL:
                    SetMarginL(value);
                    break;
                case V4PlusStyleHeader.MarginR:
                    SetMarginR(value);
                    break;
                case V4PlusStyleHeader.MarginV:
                    SetMarginV(value);
                    break;
                case V4PlusStyleHeader.Encoding:
                    SetEncoding(value);
                    break;
            }
        }

        public string GetPropertyAsString(Enum enumValue)
        {
            V4PlusStyleHeader property;

            if (enumValue is V4PlusStyleHeader)
                property = (V4PlusStyleHeader)enumValue;
            else
                throw new ArgumentException("The enum type isn't correct. The type must be 'V4PlusStyleHeader'");

            switch (property)
            {
                case V4PlusStyleHeader.Name:
                    return mName;
                case V4PlusStyleHeader.Fontsize:
                    return mFontSize.ToString();
                case V4PlusStyleHeader.PrimaryColour:
                    return mPrimaryColour;
                case V4PlusStyleHeader.SecondaryColour:
                    return mSecondaryColour;
                case V4PlusStyleHeader.OutlineColour:
                    return mOutlineColour;
                case V4PlusStyleHeader.BackColour:
                    return mBackColour;
                case V4PlusStyleHeader.Bold:
                    return mBold.ToString();
                case V4PlusStyleHeader.Italic:
                    return mItalic.ToString();
                case V4PlusStyleHeader.Underline:
                    return mUnderline.ToString();
                case V4PlusStyleHeader.Strikeout:
                    return mStrikeout.ToString();
                case V4PlusStyleHeader.ScaleX:
                    return mScaleX.ToString();
                case V4PlusStyleHeader.ScaleY:
                    return mScaleY.ToString();
                case V4PlusStyleHeader.Spacing:
                    return mSpacing.ToString();
                case V4PlusStyleHeader.Angle:
                    return mAngle.ToString();
                case V4PlusStyleHeader.BorderStyle:
                    return mBorderStyle.ToString();
                case V4PlusStyleHeader.Outline:
                    return mOutline.ToString();
                case V4PlusStyleHeader.Shadow:
                    return mShadow.ToString();
                case V4PlusStyleHeader.Alignment:
                    return mAlignment.ToString();
                case V4PlusStyleHeader.MarginL:
                    return mMarginL.ToString();
                case V4PlusStyleHeader.MarginR:
                    return mMarginR.ToString();
                case V4PlusStyleHeader.MarginV:
                    return mMarginV.ToString();
                case V4PlusStyleHeader.Encoding:
                    return mEncoding.ToString();
            }
            return String.Empty;
        }

        public string GetAsOutput()
        {
            EnumHelper<V4PlusStyleHeader> styleFormatHelper = new EnumHelper<V4PlusStyleHeader>();
            string output = "Style: ";

            foreach (V4PlusStyleHeader key in styleFormatHelper.GetEnumList())
            {
                output += GetPropertyAsString(key) + ",";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        public static string GetFormatOutput()
        {
            EnumHelper<V4PlusStyleHeader> styleFormatHelper = new EnumHelper<V4PlusStyleHeader>();
            string output = "Format: ";

            foreach (string description in styleFormatHelper.GetDescriptionList())
            {
                output += description + "," ;
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        #region Setters
        private void SetName(string value)
        {
            mName = value;
        }

        private void SetFontName(string value)
        {
            mFontName = value;
        }

        private void SetFontSize(string value)
        {
            mFontSize = Convert.ToInt32(value);
        }

        private void SetPrimaryColour(string value)
        {
            mPrimaryColour = value;
        }

        private void SetSecondaryColour(string value)
        {
            mSecondaryColour = value;
        }

        private void SetOutlineColour(string value)
        {
            mOutlineColour = value;
        }

        private void SetBackColour(string value)
        {
            mBackColour = value;
        }

        private void SetBold(string value)
        {
            mBold = Convert.ToInt32(value);
        }

        private void SetItalic(string value)
        {
            mItalic = Convert.ToInt32(value);
        }

        private void SetUnderline(string value)
        {
            mUnderline = Convert.ToInt32(value);
        }

        private void SetStrikeout(string value)
        {
            mStrikeout = Convert.ToInt32(value);
        }

        private void SetScaleX(string value)
        {
            mScaleX = Convert.ToInt32(value);
        }

        private void SetScaleY(string value)
        {
            mScaleY = Convert.ToInt32(value);
        }

        private void SetSpacing(string value)
        {
            mSpacing = Convert.ToInt32(value);
        }

        private void SetAngle(string value)
        {
            mAngle = Convert.ToInt32(value);
        }

        private void SetBorderStyle(string value)
        {
            mBorderStyle = Convert.ToInt32(value);
        }

        private void SetOutline(string value)
        {
            mOutline = Convert.ToInt32(value);
        }

        private void SetShadow(string value)
        {
            mShadow = Convert.ToInt32(value);
        }

        private void SetAlignment(string value)
        {
            mAlignment = Convert.ToInt32(value);
        }

        private void SetMarginL(string value)
        {
            mMarginL = Convert.ToInt32(value);
        }

        private void SetMarginR(string value)
        {
            mMarginR = Convert.ToInt32(value);
        }

        private void SetMarginV(string value)
        {
            mMarginV = Convert.ToInt32(value);
        }

        private void SetEncoding(string value)
        {
            mEncoding = Convert.ToInt32(value);
        }
        #endregion
    }
}
