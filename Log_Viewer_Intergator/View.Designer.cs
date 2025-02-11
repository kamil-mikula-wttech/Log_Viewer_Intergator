﻿namespace Log_Viewer_Intergator
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
            this.lblInclude = new System.Windows.Forms.Label();
            this.cbInfo = new System.Windows.Forms.CheckBox();
            this.cbWarn = new System.Windows.Forms.CheckBox();
            this.cbError = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenInNotepad = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnSizeUp = new System.Windows.Forms.Button();
            this.btnSizeDown = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pLog = new System.Windows.Forms.Panel();
            this.pLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.rtbLog.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtbLog.Location = new System.Drawing.Point(192, 57);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(846, 550);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // txbLogSearch
            // 
            this.txbLogSearch.Location = new System.Drawing.Point(339, 18);
            this.txbLogSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbLogSearch.Name = "txbLogSearch";
            this.txbLogSearch.Size = new System.Drawing.Size(698, 26);
            this.txbLogSearch.TabIndex = 1;
            // 
            // lblInclude
            // 
            this.lblInclude.AutoSize = true;
            this.lblInclude.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInclude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInclude.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblInclude.Location = new System.Drawing.Point(187, 18);
            this.lblInclude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInclude.Name = "lblInclude";
            this.lblInclude.Size = new System.Drawing.Size(144, 25);
            this.lblInclude.TabIndex = 2;
            this.lblInclude.Text = "Include content";
            // 
            // cbInfo
            // 
            this.cbInfo.AutoSize = true;
            this.cbInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cbInfo.Location = new System.Drawing.Point(42, 40);
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
            this.cbWarn.Location = new System.Drawing.Point(42, 80);
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
            this.cbError.Location = new System.Drawing.Point(42, 120);
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
            this.label2.Location = new System.Drawing.Point(19, 11);
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
            this.btnOpenInNotepad.Location = new System.Drawing.Point(1, 219);
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
            // btnSizeUp
            // 
            this.btnSizeUp.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSizeUp.Location = new System.Drawing.Point(85, 179);
            this.btnSizeUp.Name = "btnSizeUp";
            this.btnSizeUp.Size = new System.Drawing.Size(30, 29);
            this.btnSizeUp.TabIndex = 10;
            this.btnSizeUp.Text = "+";
            this.btnSizeUp.UseVisualStyleBackColor = false;
            this.btnSizeUp.Click += new System.EventHandler(this.btnSizeUp_Click);
            // 
            // btnSizeDown
            // 
            this.btnSizeDown.BackColor = System.Drawing.Color.Maroon;
            this.btnSizeDown.ForeColor = System.Drawing.Color.Black;
            this.btnSizeDown.Location = new System.Drawing.Point(49, 179);
            this.btnSizeDown.Name = "btnSizeDown";
            this.btnSizeDown.Size = new System.Drawing.Size(30, 29);
            this.btnSizeDown.TabIndex = 11;
            this.btnSizeDown.Text = "-";
            this.btnSizeDown.UseVisualStyleBackColor = false;
            this.btnSizeDown.Click += new System.EventHandler(this.btnSizeDown_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(42, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "font size";
            // 
            // pLog
            // 
            this.pLog.Controls.Add(this.btnOpenInNotepad);
            this.pLog.Controls.Add(this.cbInfo);
            this.pLog.Controls.Add(this.cbWarn);
            this.pLog.Controls.Add(this.cbError);
            this.pLog.Controls.Add(this.label2);
            this.pLog.Location = new System.Drawing.Point(4, 214);
            this.pLog.Name = "pLog";
            this.pLog.Size = new System.Drawing.Size(152, 323);
            this.pLog.TabIndex = 13;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1056, 628);
            this.Controls.Add(this.pLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSizeDown);
            this.Controls.Add(this.btnSizeUp);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblInclude);
            this.Controls.Add(this.txbLogSearch);
            this.Controls.Add(this.rtbLog);
            this.Name = "View";
            this.Text = "View";
            this.pLog.ResumeLayout(false);
            this.pLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.TextBox txbLogSearch;
        private System.Windows.Forms.Label lblInclude;
        private System.Windows.Forms.CheckBox cbInfo;
        private System.Windows.Forms.CheckBox cbWarn;
        private System.Windows.Forms.CheckBox cbError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenInNotepad;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnSizeUp;
        private System.Windows.Forms.Button btnSizeDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pLog;
    }
}