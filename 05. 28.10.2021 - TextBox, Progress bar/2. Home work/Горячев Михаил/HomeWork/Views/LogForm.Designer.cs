namespace HomeWork.Views
{
    partial class LogForm
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
            this.TbxLog = new System.Windows.Forms.TextBox();
            this.LilInfo = new System.Windows.Forms.LinkLabel();
            this.BtnCloseForm = new System.Windows.Forms.Button();
            this.BtnClearFile = new System.Windows.Forms.Button();
            this.LblLogFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbxLog
            // 
            this.TbxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxLog.BackColor = System.Drawing.Color.DarkGray;
            this.TbxLog.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxLog.Location = new System.Drawing.Point(24, 80);
            this.TbxLog.Multiline = true;
            this.TbxLog.Name = "TbxLog";
            this.TbxLog.ReadOnly = true;
            this.TbxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbxLog.Size = new System.Drawing.Size(854, 288);
            this.TbxLog.TabIndex = 2;
            this.TbxLog.TabStop = false;
            // 
            // LilInfo
            // 
            this.LilInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LilInfo.BackColor = System.Drawing.Color.DarkGray;
            this.LilInfo.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LilInfo.LinkColor = System.Drawing.Color.White;
            this.LilInfo.Location = new System.Drawing.Point(24, 392);
            this.LilInfo.Name = "LilInfo";
            this.LilInfo.Size = new System.Drawing.Size(294, 64);
            this.LilInfo.TabIndex = 12;
            this.LilInfo.TabStop = true;
            this.LilInfo.Text = "Файл журнала";
            this.LilInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LilInfo.VisitedLinkColor = System.Drawing.Color.Gainsboro;
            this.LilInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LilInfo_LinkClicked);
            // 
            // BtnCloseForm
            // 
            this.BtnCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCloseForm.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCloseForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCloseForm.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCloseForm.ForeColor = System.Drawing.Color.White;
            this.BtnCloseForm.Location = new System.Drawing.Point(624, 392);
            this.BtnCloseForm.Name = "BtnCloseForm";
            this.BtnCloseForm.Size = new System.Drawing.Size(251, 63);
            this.BtnCloseForm.TabIndex = 1;
            this.BtnCloseForm.Text = "Выход";
            this.BtnCloseForm.UseVisualStyleBackColor = false;
            // 
            // BtnClearFile
            // 
            this.BtnClearFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClearFile.BackColor = System.Drawing.Color.Brown;
            this.BtnClearFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearFile.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClearFile.ForeColor = System.Drawing.Color.White;
            this.BtnClearFile.Location = new System.Drawing.Point(344, 392);
            this.BtnClearFile.Name = "BtnClearFile";
            this.BtnClearFile.Size = new System.Drawing.Size(251, 63);
            this.BtnClearFile.TabIndex = 0;
            this.BtnClearFile.Text = "Очистка журнала";
            this.BtnClearFile.UseVisualStyleBackColor = false;
            this.BtnClearFile.Click += new System.EventHandler(this.BtnClearFile_Click);
            // 
            // LblLogFile
            // 
            this.LblLogFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLogFile.BackColor = System.Drawing.Color.Gray;
            this.LblLogFile.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblLogFile.Location = new System.Drawing.Point(251, 8);
            this.LblLogFile.Name = "LblLogFile";
            this.LblLogFile.Size = new System.Drawing.Size(400, 64);
            this.LblLogFile.TabIndex = 17;
            this.LblLogFile.Text = "Журнал действий";
            this.LblLogFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.BtnCloseForm;
            this.ClientSize = new System.Drawing.Size(902, 473);
            this.Controls.Add(this.LblLogFile);
            this.Controls.Add(this.LilInfo);
            this.Controls.Add(this.TbxLog);
            this.Controls.Add(this.BtnCloseForm);
            this.Controls.Add(this.BtnClearFile);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(918, 512);
            this.Name = "LogForm";
            this.Text = "Журнал";
            this.Load += new System.EventHandler(this.LogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbxLog;
        private System.Windows.Forms.LinkLabel LilInfo;
        private System.Windows.Forms.Button BtnCloseForm;
        private System.Windows.Forms.Button BtnClearFile;
        private System.Windows.Forms.Label LblLogFile;
    }
}