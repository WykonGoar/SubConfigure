using SubConfigure.Models;
using SubConfigure.Models.FileFormats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SubConfigure.Models.FileFormats.ASS.V4Plus;
using SubConfigure.Models.FileFormats.ASS;

namespace SubConfigure
{
    public class HomeController
    {
        FileReader mFileReader;
        FileWriter mFileWriter;
        ISubtitleFile mSubtitleFile;
        DataGridView dgvASSEvents;
        DataGridView dgvASSStyles;

        string fileFilter = "ass files (*.ass)|*.ass|srt files (*.srt)|*.srt";

        public HomeController()
        {
            mFileReader = new FileReader();
            mFileWriter = new FileWriter();
        }

        public bool ImportSubtitles()
        {
            string filePath = GetImportFilePath();
            if (filePath == null)
                return false;

            mSubtitleFile = mFileReader.ReadFile(filePath);
            return true;
        }

        public bool ExportSubtitles()
        {
            string filePath = GetExportFilePath();
            if (filePath == null)
                return false;

            bool gelukt = mFileWriter.CreateFile(filePath, mSubtitleFile);
            return gelukt;
        }

        private string GetImportFilePath()
        {
            OpenFileDialog mOpenFileDialog = new OpenFileDialog();
            mOpenFileDialog.Multiselect = false;
            mOpenFileDialog.Filter = fileFilter;

            if (mOpenFileDialog.ShowDialog() != DialogResult.OK)
                return null;

            return mOpenFileDialog.FileName;
        }

        private string GetExportFilePath()
        {
            SaveFileDialog mSaveFileDialog = new SaveFileDialog();
            mSaveFileDialog.Filter = fileFilter;

            if (mSaveFileDialog.ShowDialog() != DialogResult.OK)
                return null;

            return mSaveFileDialog.FileName;
        }

        public void UpdateGridViews(Home home)
        {
            switch(mSubtitleFile.FileType)
            {
                case FileType.ass:
                    ASSDataSet mDataSet = new ASSDataSet(ASSStyleType.V4Plus, mSubtitleFile);
                    mDataSet.GetStylesGridView(home.ASSStylesDataGridView);
                    mDataSet.GetEventsGridView(home.ASSEventsDataGridView);
                    mDataSet.GetScriptInfoGridView(home.ASSScriptInfoDataGridView);
                    break;
            }
        }
        
        public void MoveEventTimes(string startRegion, string endRegion, int ms)
        {
            mSubtitleFile.MoveEventTimes(startRegion, endRegion, ms);
        }
    }
}
 