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
        ComboBox cmbExp = new ComboBox();
        ComboBox cmbInv = new ComboBox();
        Panel panel_images = new Panel();
        Label labelExp = new Label();
        Label labelInv = new Label();

        public View(string type = "All logs")
        {
            InitializeComponent();
            rtbLog.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            if (type == config.AllLogs)
            {
                using (StreamReader reader = new StreamReader(config.LogFileDirectory + $"\\{config.LogFile}"))
                {
                    readFromFileLong = reader.ReadToEnd();
                }
                readFromFile = readFromFileLong.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList();
                rtbLog.AppendText(readFromFileLong);
                ReadLogsAndMakeProperLists();
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                CreateTabToSelectImagesFrom();
                ReadFilesAndFillProperCombos();
                this.pLog.Visible = false;
                btnAccept.Visible = false;
                lblInclude.Visible = false;
                txbLogSearch.Visible = false;
            }
            this.KeyDown += MainForm_KeyDown;
            this.KeyPreview = true;
        }

        private void ReadFilesAndFillProperCombos()
        {

            var files = Directory.GetFiles(config.LogFileDirectory);

            foreach (var file in files)
            {
                if (file.Contains(config.Expenses))
                {
                    cmbExp.Items.Add(Path.GetFileName(file).Substring(17));
                }
                else if (file.Contains(config.Invoices))
                {
                    cmbInv.Items.Add(Path.GetFileName(file).Substring(17));
                }
            }
        }


        private void CreateTabToSelectImagesFrom()
        {
            panel_images = new Panel();
            panel_images.Width = 120;
            panel_images.Height = 76;
            panel_images.BackColor = Color.DimGray;
            panel_images.Location = new Point(5, this.Height - panel_images.Height - 200);
            this.Controls.Add(panel_images);

            cmbExp.Width = 120;
            cmbInv.Width = 120;
            panel_images.Controls.Add((ComboBox)cmbExp);
            panel_images.Controls.Add((ComboBox)cmbInv);

            panel_images.Controls.Add(labelExp);

            panel_images.Controls.Add(labelInv);
            labelExp.Location = new Point(0, 40);
            labelExp.Text = "Expenses";
            labelInv.Text = "Invoices";
            cmbInv.Location = new Point(0, 16);
            cmbExp.Location = new Point(0, 56);
            cmbInv.SelectedIndexChanged += ShowFileWithCorrespondingNameInv;
            cmbExp.SelectedIndexChanged += ShowFileWithCorrespondingNameExp;
        }

        private void ShowFileWithCorrespondingNameExp(object sender, EventArgs e)
        {
            rtbLog.Clear();
            using (StreamReader reader = new StreamReader(config.LogFileDirectory + $"\\{config.ImagesExpenses}{cmbExp.Text}"))
            {
                rtbLog.AppendText(reader.ReadToEnd());
            }
        }

        private void ShowFileWithCorrespondingNameInv(object sender, EventArgs e)
        {
            rtbLog.Clear();
            using (StreamReader reader = new StreamReader(config.LogFileDirectory + $"\\{config.ImagesInvoices}{cmbInv.Text}"))
            {
                rtbLog.AppendText(reader.ReadToEnd());
            }
        }

        private void ReadLogsAndMakeProperLists()
        {
            bool errorFlag = false;
            foreach (var obj in readFromFile)
            {
                if (obj.Contains(config.INFO))
                {
                    infoList.Add(obj);
                    errorFlag = false;

                }
                else if (obj.Contains(config.WARN))
                {
                    warnList.Add(obj);
                    errorFlag = false;

                }
                else if (obj.Contains(config.ERROR))
                {
                    errorList.Add(obj);
                    errorFlag = true;
                }
                else if (errorFlag == true)
                {
                    errorList[errorList.Count - 1] += obj;
                }
                else if (obj.Contains(config.TransferFailed))
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
                config.EnterText,
                config.Search,
                String.Empty,
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
                errorString = string.Join(Environment.NewLine, errorList.Where(x => x.Contains(txbLogSearch.Text)));
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
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, config.LogContent);
                File.WriteAllText(filePath, content);
                Process.Start(config.ApplicationToOpen, filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{config.ERROR}: {ex.Message}", $"{config.ERROR}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSizeUp_Click(object sender, EventArgs e)
        {
            Font newFont = new Font(rtbLog.Font.FontFamily, rtbLog.Font.Size + 1);
            rtbLog.Font = newFont;
        }

        private void btnSizeDown_Click(object sender, EventArgs e)
        {
            Font newFont = new Font(rtbLog.Font.FontFamily, rtbLog.Font.Size - 1);
            rtbLog.Font = newFont;
        }
    }
}
