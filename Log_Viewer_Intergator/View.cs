using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Log_Viewer_Intergator
{
    public partial class View : Form
    {
        List<string> readFromFile = new List<string>();
        string readFromFileLong;
        Configuration config = new Configuration();
        List<string> filteredList = new List<string>();
        List<string> errorList = new List<string>();
        List<string> warnList = new List<string>();
        List<string> infoList = new List<string>();
        string errorString;
        string warnString;
        string infoString;

        public View()
        {
            InitializeComponent();
            rtbLog.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            using (StreamReader reader = new StreamReader(config.LogFileDirectory + "\\BIG_DADDY.txt"))
            {
                readFromFileLong = reader.ReadToEnd();
            }
            readFromFile = readFromFileLong.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList();
            rtbLog.AppendText(readFromFileLong);
            this.KeyDown += MainForm_KeyDown;
            this.KeyPreview = true;
            ReadLogsAndMakeProperLists();
        }

        private void ReadLogsAndMakeProperLists()
        {
            bool errorFlag = false;
            foreach (var obj in readFromFile)
            {
                if (obj.Contains("INFO"))
                {
                    infoList.Add(obj);
                    errorFlag = false;

                }
                else if (obj.Contains("WARN"))
                {
                    warnList.Add(obj);
                    errorFlag = false;

                }
                else if (obj.Contains("ERROR"))
                {
                    errorList.Add(obj);
                    errorFlag = true;
                }
                else if(errorFlag == true)
                {
                    errorList[errorList.Count - 1] += obj;
                }
                else if(obj.Contains("transfer failed - action required"))
                {
                    infoList[infoList.Count - 1] += obj;
                }
                else
                {
                    MessageBox.Show(obj);
                }
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                ShowSearchDialog();
            }
        }

        private void ShowSearchDialog()
        {
            string searchTerm = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter text to search for:",
                "Search",
                "",
                -1, -1);

            if (!string.IsNullOrEmpty(searchTerm))
            {
                HighlightText(searchTerm);
            }
        }

        private void HighlightText(string searchTerm)
        {
            rtbLog.Select(0, 0);
            rtbLog.SelectionBackColor = rtbLog.BackColor;

            int startIndex = 0;
            while ((startIndex = rtbLog.Find(searchTerm, startIndex, RichTextBoxFinds.None)) != -1)
            {
                rtbLog.Select(startIndex, searchTerm.Length);
                rtbLog.SelectionBackColor = Color.Yellow;
                startIndex += searchTerm.Length;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            filteredList.Clear();
            rtbLog.Clear();
            if (cbError.Checked)
            {
               errorString = string.Join(Environment.NewLine, errorList.Where(x=>x.Contains(txbLogSearch.Text)));
               rtbLog.AppendText(errorString);
            }
            if (cbWarn.Checked)
            {
                warnString = string.Join(Environment.NewLine, warnList.Where(x => x.Contains(txbLogSearch.Text)));
                rtbLog.AppendText(warnString);
            }
            if (cbInfo.Checked)
            {
                infoString = string.Join(Environment.NewLine, infoList.Where(x => x.Contains(txbLogSearch.Text)));
                rtbLog.AppendText(infoString);
            }

        }
        private void btnOpenInNotepad_Click(object sender, EventArgs e)
        {
            try
            {
                string content = rtbLog.Text;
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logContent.txt");
                File.WriteAllText(filePath, content);
                Process.Start("notepad.exe", filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
