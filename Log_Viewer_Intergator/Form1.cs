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
        FileWorker logWorker = new FileWorker();
        Configuration config = new Configuration();
        public LogViewer()
        {
            InitializeComponent();
            cbLogs.Items.Add(config.Images);
            cbLogs.Items.Add(config.AllLogs);
            cbLogs.SelectedIndex = 1;

            this.Font = SystemFonts.IconTitleFont;

            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.StartPosition = FormStartPosition.Manual;
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            string typeOfAction = cbLogs.SelectedItem.ToString();

            logWorker.DeleteAllFilesFromFilesFolder();
            if(typeOfAction == config.AllLogs)
            DownloadLogs(dtpLog.Value);
            else
            {
                DownloadImageFiles(dtpLog.Value);
            }
          
        }

        private async Task DownloadImageFiles(DateTime date)
        {
            try
            {
                await awsDownloader.TryDownloadImageFilesFromAWS(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            if(cbLogs.SelectedItem == config.AllLogs)
            {
                logWorker.MergeLogsIntoOneFile();
                new View().ShowDialog();
            }
            else
            {
                new View(config.Images).ShowDialog();
            }
        }

        private void cbLogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((sender as ComboBox).SelectedItem == config.Images)
            {
                btnLogs.Text = config.GenerateImages;

            }
            else
            {
                btnLogs.Text = config.GenerateLogs;
            }
        }
    }
}
