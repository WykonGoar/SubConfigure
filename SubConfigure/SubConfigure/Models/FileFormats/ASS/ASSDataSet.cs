using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using SubConfigure.Models.FileFormats.ASS;
using SubConfigure.Models.FileFormats.ASS.V4Plus;

namespace SubConfigure.Models.FileFormats.ASS
{
    public class ASSDataSet : IDataSet
    {
        private ISubtitleFile mSubtitleFile;
        private ASSStyleType mStyleType;

        public ASSDataSet(ASSStyleType styleType, ISubtitleFile subtitleFile)
        {
            mStyleType = styleType;
            mSubtitleFile = subtitleFile;
        }

        public void GetScriptInfoGridView(DataGridView dataGridView)
        {
            switch(mStyleType)
            {
                case ASSStyleType.V4Plus:
                    GetV4PlusScriptInfoGridView(dataGridView);
                    break;
            }
        }

        public void GetStylesGridView(DataGridView dataGridView)
        {
            switch(mStyleType)
            {
                case ASSStyleType.V4Plus:
                    GetV4PlusStyleGridView(dataGridView);
                    break;
            }
        }

        public void GetEventsGridView(DataGridView dataGridView)
        {
            switch (mStyleType)
            {
                case ASSStyleType.V4Plus:
                    GetV4PlusEventGridView(dataGridView);
                    break;
            }
        }

        private void GetV4PlusStyleGridView(DataGridView dataGridView)
        {
            //dataGridView.AutoGenerateColumns = false;
            V4PlusFile subtitleFile = mSubtitleFile as V4PlusFile;

            EnumHelper<V4PlusStyleHeader> styleHelper = new EnumHelper<V4PlusStyleHeader>();
            Dictionary<V4PlusStyleHeader, string> enumDictionary = styleHelper.GetEnumsWithDescriptions();
            
            //DataGridViewColumnCollection columns = new DataGridViewColumnCollection(dataGridView);
            //dataGridView.Columns.Clear();

            //foreach (string styleDescription in enumDictionary.Values)
            //{
            //    DataGridViewColumn column = new DataGridViewColumn();
            //    column.HeaderText = styleDescription;
            //    dataGridView.Columns.Add(column);
            //}

            BindingList<IV4PlusStyle> rows = new BindingList<IV4PlusStyle>();
            rows.AddingNew += new AddingNewEventHandler(subtitleFile.AddingNewStyle);

            IList<IV4PlusStyle> styleValues = subtitleFile.GetStyles();
            foreach(IV4PlusStyle value in styleValues)
            {
                rows.Add(value);
            }

            dataGridView.DataSource = rows;
        }

        private void GetV4PlusEventGridView(DataGridView dataGridView)
        {
            V4PlusFile subtitleFile = mSubtitleFile as V4PlusFile;
            
            BindingList<IV4PlusEvent> rows = new BindingList<IV4PlusEvent>();
            rows.AddingNew += new AddingNewEventHandler(subtitleFile.AddingNewEvent);

            IList<IV4PlusEvent> eventValues = subtitleFile.GetEvents();
            foreach (IV4PlusEvent value in eventValues)
            {
                rows.Add(value);
            }

            dataGridView.DataSource = rows;
        }

        private void GetV4PlusScriptInfoGridView(DataGridView dataGridView)
        {
            V4PlusFile subtitleFile = mSubtitleFile as V4PlusFile;

            BindingList<IV4PlusScriptInfo> rows = new BindingList<IV4PlusScriptInfo>();
            IList<IV4PlusScriptInfo> scriptInfoValues = subtitleFile.GetScriptInfo();
            foreach (IV4PlusScriptInfo value in scriptInfoValues)
            {
                rows.Add(value);
            }

            dataGridView.DataSource = rows;
        }
    }
}
