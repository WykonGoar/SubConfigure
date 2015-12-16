using SubConfigure.Models;
using SubConfigure.Models.FileFormats;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubConfigure
{
    public partial class Home : Form
    {
        private HomeController mHomeControler;

        public Home()
        {
            InitializeComponent();

            mHomeControler = new HomeController();
        }

        public DataGridView ASSStylesDataGridView { get { return dgvASSStyles; } set { dgvASSStyles = value; } }
        public DataGridView ASSEventsDataGridView { get { return dgvASSEvents; } set { dgvASSEvents = value; } }

        public DataGridView ASSScriptInfoDataGridView { get { return dgvASSScriptInfo; } set { dgvASSScriptInfo = value; } }

        private void bImport_Click(object sender, EventArgs e)
        {
            bool gelukt = mHomeControler.ImportSubtitles();
            MessageBox.Show("Import success: " + gelukt);
            UpdateDataSets();
        }

        private void bExport_Click(object sender, EventArgs e)
        {
            bool gelukt = mHomeControler.ExportSubtitles();
            MessageBox.Show("Export success: " + gelukt);
        }

        private void UpdateDataSets()
        {
            mHomeControler.UpdateGridViews(this);
        }

        private void tbMove_Click(object sender, EventArgs e)
        {
            mHomeControler.MoveEventTimes(mtbStartRegion.Text, mtbEndRegion.Text, (int)nudTime.Value);
            mHomeControler.UpdateGridViews(this);
        }
    }
}
