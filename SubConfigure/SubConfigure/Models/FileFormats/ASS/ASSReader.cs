using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using SubConfigure.Models.FileFormats.ASS;
using SubConfigure.Models.FileFormats.ASS.V4Plus;

namespace SubConfigure.Models.FileFormats.ASS
{
    public class ASSReader
    {
        string[] styleSepperators = { "," };
        string[] eventSeparators = { "," };

        public ASSReader() { }

        public ISubtitleFile ReadFile(ASSStyleType style, string filePath)
        {
            StreamReader reader = new StreamReader(Path.GetFullPath(filePath));

            ISubtitleFile subtitleFile = null;

            switch (style)
            {
                case ASSStyleType.V4Plus:
                    subtitleFile = ReadV4Plus(reader);
                    break;
            }

            reader.Close();

            return subtitleFile;
        }

        private ISubtitleFile ReadV4Plus(StreamReader reader)
        {
            V4PlusFile subtitleFile = new V4PlusFile();

            EnumHelper<V4PlusScriptInfoHeader> scriptInfoHelper = new EnumHelper<V4PlusScriptInfoHeader>();
            EnumHelper<V4PlusEventHeader> eventFormatHelper = new EnumHelper<V4PlusEventHeader>();
            EnumHelper<V4PlusStyleHeader> styleFormatHelper = new EnumHelper<V4PlusStyleHeader>();
            IList<V4PlusEventHeader> eventFormatList = eventFormatHelper.GetEnumList();
            IList<V4PlusStyleHeader> styleFormatList = styleFormatHelper.GetEnumList();


            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (line == "[Script Info]")
                {
                    bool gettingScriptInfo = true;

                    while (!reader.EndOfStream && gettingScriptInfo)
                    {
                        line = reader.ReadLine();

                        if (line.Equals("[V4+ Styles]") || line.Equals("[Events]"))
                        {
                            gettingScriptInfo = false;
                            continue;
                        }

                        int infoIndex = line.IndexOf(":");
                        if (infoIndex < 0)
                            continue;

                        string infoDescription = line.Substring(0, infoIndex);
                        string infoValue = line.Substring(infoIndex + 2);

                        V4PlusScriptInfoHeader header;
                        try
                        {
                            header = scriptInfoHelper.GetEnumFromDescription(infoDescription);
                        }
                        catch (Exception ex)
                        {
                            continue;
                        }

                        V4PlusScriptInfo scriptInfo = new V4PlusScriptInfo(header, infoValue);
                        subtitleFile.AddItem(scriptInfo);

                    }
                }

                if (line == "[V4+ Styles]")
                {
                    bool gettingStyles = true;

                    while (!reader.EndOfStream && gettingStyles)
                    {
                        line = reader.ReadLine();

                        if (line.Contains("Format") || line.Equals(""))
                            continue;

                        if (line.Equals("[Script Info]") || line.Equals("[Events]"))
                        {
                            gettingStyles = false;
                            continue;
                        }

                        V4PlusStyle style = new V4PlusStyle();
                        string styleRow = line.Replace("Style: ", "");

                        string[] styleValues = styleRow.Split(styleSepperators, StringSplitOptions.None);

                        for (int i = 0; i < styleFormatList.Count; i++)
                        {
                            V4PlusStyleHeader header = styleFormatList[i];
                            string styleValue = styleValues.GetValue(i).ToString();
                            style.SetPropertyWithString(header, styleValue);
                        }

                        subtitleFile.AddItem(style);
                    }
                }

                if (line == "[Events]")
                {
                    bool gettingEvents = true;

                    while (!reader.EndOfStream && gettingEvents)
                    {
                        line = reader.ReadLine();

                        if (line.Contains("Format") || line.Equals(""))
                            continue;

                        if (line.Equals("[Script Info]") || line.Equals("[V4+ Styles]"))
                        {
                            gettingEvents = false;
                            continue;
                        }

                        IV4PlusEvent cEvent = new V4PlusEvent();
                        string eventRow = line.Replace("Dialogue: ", "");

                        string[] eventValues = SplitEventValues(eventRow);

                        for (int i = 0; i < eventFormatList.Count; i++)
                        {
                            V4PlusEventHeader header = eventFormatList[i];
                            string eventValue = eventValues.GetValue(i).ToString();
                            cEvent.SetPropertyWithString(header, eventValue);
                        }

                        subtitleFile.AddItem(cEvent);
                    }
                }
            }

            return subtitleFile;
        }

        private string[] SplitEventValues(string line)
        {
            string[] lineFullSplitted = line.Split(eventSeparators, StringSplitOptions.None);

            string textValue = String.Empty;
            for (int i = 9; i < lineFullSplitted.Length; i++)
            {
                if (i == 9)
                    textValue = lineFullSplitted.GetValue(i).ToString();
                else
                    textValue += "," + lineFullSplitted.GetValue(i).ToString();
            }

            string lineMinusTextValue = line;
            if (textValue != "")
                lineMinusTextValue = line.Replace("," + textValue, String.Empty);

            string[] returnValue = new string[10];
            string[] eventValues = lineMinusTextValue.Split(eventSeparators, StringSplitOptions.None);
            for (int i = 0; i < eventValues.Length; i++)
            {
                returnValue.SetValue(eventValues.GetValue(i), i);
            }

            returnValue.SetValue(textValue, 9);

            return returnValue;
        }
    }
}