namespace Log_Viewer_Intergator
{
    partial class View
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
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.txbLogSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbInfo = new System.Windows.Forms.CheckBox();
            this.cbWarn = new System.Windows.Forms.CheckBox();
            this.cbError = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenInNotepad = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.rtbLog.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtbLog.Location = new System.Drawing.Point(162, 57);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(876, 550);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // txbLogSearch
            // 
            this.txbLogSearch.Location = new System.Drawing.Point(310, 18);
            this.txbLogSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbLogSearch.Name = "txbLogSearch";
            this.txbLogSearch.Size = new System.Drawing.Size(727, 26);
            this.txbLogSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(158, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Include content";
            // 
            // cbInfo
            // 
            this.cbInfo.AutoSize = true;
            this.cbInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbInfo.Location = new System.Drawing.Point(38, 263);
            this.cbInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbInfo.Name = "cbInfo";
            this.cbInfo.Size = new System.Drawing.Size(70, 29);
            this.cbInfo.TabIndex = 4;
            this.cbInfo.Text = "Info";
            this.cbInfo.UseVisualStyleBackColor = false;
            // 
            // cbWarn
            // 
            this.cbWarn.AutoSize = true;
            this.cbWarn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbWarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbWarn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbWarn.Location = new System.Drawing.Point(38, 303);
            this.cbWarn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbWarn.Name = "cbWarn";
            this.cbWarn.Size = new System.Drawing.Size(86, 29);
            this.cbWarn.TabIndex = 5;
            this.cbWarn.Text = "Warn";
            this.cbWarn.UseVisualStyleBackColor = false;
            // 
            // cbError
            // 
            this.cbError.AutoSize = true;
            this.cbError.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbError.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbError.Location = new System.Drawing.Point(38, 343);
            this.cbError.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbError.Name = "cbError";
            this.cbError.Size = new System.Drawing.Size(80, 29);
            this.cbError.TabIndex = 6;
            this.cbError.Text = "Error";
            this.cbError.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(15, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Content type";
            // 
            // btnOpenInNotepad
            // 
            this.btnOpenInNotepad.BackColor = System.Drawing.Color.Black;
            this.btnOpenInNotepad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOpenInNotepad.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnOpenInNotepad.Location = new System.Drawing.Point(4, 511);
            this.btnOpenInNotepad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenInNotepad.Name = "btnOpenInNotepad";
            this.btnOpenInNotepad.Size = new System.Drawing.Size(150, 98);
            this.btnOpenInNotepad.TabIndex = 8;
            this.btnOpenInNotepad.Text = "Open in Notepad";
            this.btnOpenInNotepad.UseVisualStyleBackColor = false;
            this.btnOpenInNotepad.Click += new System.EventHandler(this.btnOpenInNotepad_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Black;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAccept.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAccept.Location = new System.Drawing.Point(4, 18);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(150, 88);
            this.btnAccept.TabIndex = 9;
            this.btnAccept.Text = "Accept changes";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1056, 628);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnOpenInNotepad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbError);
            this.Controls.Add(this.cbWarn);
            this.Controls.Add(this.cbInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbLogSearch);
            this.Controls.Add(this.rtbLog);
            this.Name = "View";
            this.Text = "View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.TextBox txbLogSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbInfo;
        private System.Windows.Forms.CheckBox cbWarn;
        private System.Windows.Forms.CheckBox cbError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenInNotepad;
        private System.Windows.Forms.Button btnAccept;
    }
}