using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubConfigure.Models.FileFormats.ASS.V4Plus
{
    public class V4PlusEvent : IV4PlusEvent
    {
        #region variablen
        private int mLayer;
        private string mStart;
        private string mEnd;
        private string mStyle;
        private string mName;
        private int mMarginL;
        private int mMarginR;
        private int mMarginV;
        private string mEffect;
        private string mText;
        #endregion

        public readonly static string TIME_FORMAT = "H:mm:ss.ff";

        public V4PlusEvent() { }
        
        #region Getters and setters
        public int Layer { get { return mLayer; } set { mLayer = value; } }
        public string Start { get { return mStart; } set { mStart = value; } }
        public string End { get { return mEnd; } set { mEnd = value; } }
        public string Style { get { return mStyle; } set { mStyle = value; } }
        public string Name { get { return mName; } set { mName = value; } }
        public int MarginL { get { return mMarginL; } set { mMarginL = value; } }
        public int MarginR { get { return mMarginR; } set { mMarginR = value; } }
        public int MarginV { get { return mMarginV; } set { mMarginV = value; } }
        public string Effect { get { return mEffect; } set { mEffect = value; } }
        public string Text { get { return mText; } set { mText = value; } }
        #endregion

        public void SetPropertyWithString(Enum enumValue, string value)
        {
            V4PlusEventHeader property;

            if (enumValue is V4PlusEventHeader)
                property = (V4PlusEventHeader)enumValue;
            else
                throw new ArgumentException("The enum type isn't correct. The type must be 'V4PlusEventHeader'");

            switch(property)
            {
                case V4PlusEventHeader.Layer:
                    SetLayer(value);
                    break;
                case V4PlusEventHeader.Start:
                    SetStart(value);
                    break;
                case V4PlusEventHeader.End:
                    SetEnd(value);
                    break;
                case V4PlusEventHeader.Style:
                    SetStyle(value);
                    break;
                case V4PlusEventHeader.Name:
                    SetName(value);
                    break;
                case V4PlusEventHeader.MarginL:
                    SetMarginL(value);
                    break;
                case V4PlusEventHeader.MarginR:
                    SetMarginR(value);
                    break;
                case V4PlusEventHeader.MarginV:
                    SetMarginV(value);
                    break;
                case V4PlusEventHeader.Effect:
                    SetEffect(value);
                    break;
                case V4PlusEventHeader.Text:
                    SetText(value);
                    break;
            }
        }
        
        public string GetPropertyAsString(Enum enumValue)
        {
             V4PlusEventHeader property;

            if (enumValue is V4PlusEventHeader)
                property = (V4PlusEventHeader)enumValue;
            else
                throw new ArgumentException("The enum type isn't correct. The type must be 'V4PlusEventHeader'");

            switch (property)
            {
                case V4PlusEventHeader.Layer:
                    return mLayer.ToString();
                case V4PlusEventHeader.Start:
                    return mStart;
                case V4PlusEventHeader.End:
                    return mEnd;
                case V4PlusEventHeader.Style:
                    return mStyle;
                case V4PlusEventHeader.Name:
                    return mName;
                case V4PlusEventHeader.MarginL:
                    return mMarginL.ToString();
                case V4PlusEventHeader.MarginR:
                    return mMarginR.ToString();
                case V4PlusEventHeader.MarginV:
                    return mMarginV.ToString();
                case V4PlusEventHeader.Effect:
                    return mEffect;
                case V4PlusEventHeader.Text:
                    return mText;
            }

            return String.Empty;
        }

        public string GetAsOutput()
        {
            EnumHelper<V4PlusEventHeader> eventFormatHelper = new EnumHelper<V4PlusEventHeader>();
            string output = "Dialogue: ";

            foreach (V4PlusEventHeader key in eventFormatHelper.GetEnumList())
            {
                output += GetPropertyAsString(key) + ",";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        public static string GetFormatOutput()
        {
            EnumHelper<V4PlusEventHeader> eventFormatHelper = new EnumHelper<V4PlusEventHeader>();
            string output = "Format: ";

            foreach (string description in eventFormatHelper.GetDescriptionList())
            {
                output += description + ",";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        #region setters
        private void SetLayer(string value)
        {
            mLayer = Convert.ToInt32(value);
        }

        private void SetStart(string value)
        {
            mStart = value;
        }

        private void SetEnd(string value)
        {
            mEnd = value;
        }

        private void SetStyle(string value)
        {
            mStyle = value;
        }

        private void SetName(string value)
        {
            mName = value;
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

        private void SetEffect(string value)
        {
            mEffect = value;
        }

        private void SetText(string value)
        {
            mText = value;
        }
        #endregion


        public void MoveStartTime(int amount)
        {
            DateTime startTime = DateTime.ParseExact(mStart, TIME_FORMAT, null);
            DateTime endTime = DateTime.ParseExact(mEnd, TIME_FORMAT, null);

            startTime.AddMilliseconds(amount);
            endTime.AddMilliseconds(amount);

            mStart = startTime.ToString(TIME_FORMAT);
            mEnd = endTime.ToString(TIME_FORMAT);
        }
    }
}
