namespace Log_Viewer_Intergator
{
    partial class LogViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogs = new System.Windows.Forms.Button();
            this.cbLogs = new System.Windows.Forms.ComboBox();
            this.dtpLog = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogs
            // 
            this.btnLogs.BackColor = System.Drawing.Color.Black;
            this.btnLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogs.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLogs.Location = new System.Drawing.Point(12, 140);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(172, 78);
            this.btnLogs.TabIndex = 0;
            this.btnLogs.Text = "Generate logs";
            this.btnLogs.UseVisualStyleBackColor = false;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // cbLogs
            // 
            this.cbLogs.BackColor = System.Drawing.SystemColors.MenuText;
            this.cbLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbLogs.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.cbLogs.FormattingEnabled = true;
            this.cbLogs.Location = new System.Drawing.Point(12, 77);
            this.cbLogs.Name = "cbLogs";
            this.cbLogs.Size = new System.Drawing.Size(158, 33);
            this.cbLogs.TabIndex = 1;
            // 
            // dtpLog
            // 
            this.dtpLog.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpLog.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtpLog.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dtpLog.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpLog.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dtpLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpLog.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpLog.Location = new System.Drawing.Point(12, 28);
            this.dtpLog.Name = "dtpLog";
            this.dtpLog.Size = new System.Drawing.Size(158, 30);
            this.dtpLog.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(190, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pickup starting date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(190, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pickup type of logs you want to see";
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.Black;
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProcess.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnProcess.Location = new System.Drawing.Point(12, 224);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(172, 101);
            this.btnProcess.TabIndex = 5;
            this.btnProcess.Text = "Process logs and open new window";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // LogViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(570, 353);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpLog);
            this.Controls.Add(this.cbLogs);
            this.Controls.Add(this.btnLogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LogViewer";
            this.Text = "Log view";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.ComboBox cbLogs;
        private System.Windows.Forms.DateTimePicker dtpLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcess;
    }
}

