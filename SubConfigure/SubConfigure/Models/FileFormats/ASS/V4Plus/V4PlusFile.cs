using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubConfigure.Models.FileFormats.ASS.V4Plus
{
    public class V4PlusFile : IV4PlusFile
    {
        private List<IV4PlusScriptInfo> mScriptInfo;
        private List<IV4PlusStyle> mStyles;
        private List<IV4PlusEvent> mEvents;

        public V4PlusFile() 
        {
            mScriptInfo = new List<IV4PlusScriptInfo>();
            mStyles = new List<IV4PlusStyle>();
            mEvents = new List<IV4PlusEvent>();
        }
        public FileType FileType { get { return FileType.ass; } }

        public void AddItem(ISubtitleItem item)
        {
            if(item is IV4PlusScriptInfo)
            {
                IV4PlusScriptInfo scriptInfo = item as IV4PlusScriptInfo;
                mScriptInfo.Add(scriptInfo);
            }

            else if (item is IV4PlusStyle)
            {
                IV4PlusStyle style = item as IV4PlusStyle;
                mStyles.Add(style);
            }

            else if (item is IV4PlusEvent)
            {
                IV4PlusEvent cEvent = item as IV4PlusEvent;
                mEvents.Add(cEvent);
            }               
        }

        public bool RemoveItem(ISubtitleItem item)
        {
            if (item is IV4PlusScriptInfo)
            {
                IV4PlusScriptInfo scriptInfo = item as IV4PlusScriptInfo;
                return mScriptInfo.Remove(scriptInfo);
            }

            else if (item is IV4PlusStyle)
            {
                IV4PlusStyle style = item as IV4PlusStyle;
                return mStyles.Remove(style);
            }

            else if (item is IV4PlusEvent)
            {
                IV4PlusEvent cEvent = item as IV4PlusEvent;
                return mEvents.Remove(cEvent);
            }        

            return false;
        }

        public void ReplaceItem(ISubtitleItem oldItem, ISubtitleItem newItem)
        {
            if (oldItem is IV4PlusScriptInfo)
            {
                IV4PlusScriptInfo oldScriptInfo = oldItem as IV4PlusScriptInfo;
                IV4PlusScriptInfo newScriptInfo = newItem as IV4PlusScriptInfo;
                mScriptInfo.Remove(oldScriptInfo);
                mScriptInfo.Add(newScriptInfo);
            }

            else if (oldItem is IV4PlusStyle)
            {
                IV4PlusStyle oldStyle = oldItem as IV4PlusStyle;
                IV4PlusStyle newStyle = newItem as IV4PlusStyle;
                mStyles.Remove(oldStyle);
                mStyles.Add(newStyle);
            }

            else if (oldItem is IV4PlusEvent)
            {
                IV4PlusEvent oldEvent = oldItem as IV4PlusEvent;
                IV4PlusEvent newEvent = newItem as IV4PlusEvent;
                mEvents.Remove(oldEvent);
                mEvents.Add(newEvent);
            }
        }

        public IList<IV4PlusScriptInfo> GetScriptInfo()
        {
            return mScriptInfo;
        }
        
        public IList<IV4PlusStyle> GetStyles()
        {
            return mStyles;
        }

        public IList<IV4PlusEvent> GetEvents()
        {
            return mEvents;
        }

        public IList<string> GetAsOutput()
        {
            List<string> output = new List<string>();

            //Creat Script Info output
            output.Add("[Script Info]");

            //Create the output for each style
            foreach (IV4PlusScriptInfo scriptInfo in mScriptInfo)
            {
                output.Add(scriptInfo.GetAsOutput());
            }

            output.Add("");
            //Create Style Output
            output.Add("[V4+ Styles]");
            output.Add(V4PlusStyle.GetFormatOutput());
            
            //Create the output for each style
            foreach (IV4PlusStyle style in mStyles)
            {
                output.Add(style.GetAsOutput());
            }

            output.Add("");
            //Create Event Output
            output.Add("[Events]");
            output.Add(V4PlusEvent.GetFormatOutput());

            //Create the output for each event
            foreach (IV4PlusEvent cEvent in mEvents)
            {
                output.Add(cEvent.GetAsOutput());
            }            

            return output;
        } 

        public void AddingNewStyle(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new V4PlusStyle();
        }

        public void AddingNewEvent(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new V4PlusEvent();
        }
        
        public void MoveEventTimes(string startTime, string endTime, int amount)
        {
            string timeFormat = V4PlusEvent.TIME_FORMAT;

            TimeSpan start = TimeSpan.Parse(startTime);
            TimeSpan end = TimeSpan.Parse(endTime);

            IList<IV4PlusEvent> eventsList = GetEventsInRegion(start, end);

            foreach (IV4PlusEvent cEvent in eventsList)
            {
                IV4PlusEvent oldEvent = cEvent;
                cEvent.MoveStartTime(amount);

                mEvents.Remove(oldEvent);
                mEvents.Add(cEvent);
            }
        }

        private IList<IV4PlusEvent> GetEventsInRegion(TimeSpan startRegion, TimeSpan endRegion)
        {
            List<IV4PlusEvent> eventsInRegionList = new List<IV4PlusEvent>();

            foreach(IV4PlusEvent cEvent in mEvents)
            {
                TimeSpan currentTime = TimeSpan.Parse(cEvent.Start);

                if (currentTime >= startRegion && currentTime <= endRegion)
                {
                    eventsInRegionList.Add(cEvent);
                }

            }

            return eventsInRegionList;
        }
    }
}
