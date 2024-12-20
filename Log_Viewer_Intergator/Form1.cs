using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_Viewer_Intergator
{
    public partial class LogViewer : Form
    {
        AWSConnectorDownloader awsDownloader = new AWSConnectorDownloader();
        LogWorker logWorker = new LogWorker();
        Configuration config = new Configuration();
        public LogViewer()
        {
            InitializeComponent();
            cbLogs.Items.Add("Invoices");
            cbLogs.Items.Add("Expenses");
            cbLogs.Items.Add("Images");
            cbLogs.Items.Add("All logs");
            cbLogs.SelectedIndex = 3;

            this.Font = SystemFonts.IconTitleFont;

            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.StartPosition = FormStartPosition.Manual;
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            string typeOfLogs = cbLogs.SelectedItem.ToString();

            logWorker.DeleteAllLogsFromLogFolder();
            DownloadLogs(dtpLog.Value);
          
        }
        private async Task DownloadLogs(DateTime date)
        {
            try
            {
                await awsDownloader.TryDownloadLogsFromAWS(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnProcess_Click(object sender, EventArgs e)
        {
            logWorker.MergeLogsIntoOneFile();
            new View().ShowDialog();
        }
    }
}
