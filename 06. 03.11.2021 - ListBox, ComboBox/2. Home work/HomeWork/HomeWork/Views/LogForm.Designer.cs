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
            this.LblHistory = new System.Windows.Forms.Label();
            this.TbxHistory = new System.Windows.Forms.TextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnLoadFile = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblHistory
            // 
            this.LblHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblHistory.BackColor = System.Drawing.Color.Gray;
            this.LblHistory.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblHistory.ForeColor = System.Drawing.Color.White;
            this.LblHistory.Location = new System.Drawing.Point(264, 25);
            this.LblHistory.Name = "LblHistory";
            this.LblHistory.Size = new System.Drawing.Size(272, 40);
            this.LblHistory.TabIndex = 4;
            this.LblHistory.Text = "Журнал";
            this.LblHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbxHistory
            // 
            this.TbxHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxHistory.BackColor = System.Drawing.Color.DarkGray;
            this.TbxHistory.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxHistory.Location = new System.Drawing.Point(32, 72);
            this.TbxHistory.Multiline = true;
            this.TbxHistory.Name = "TbxHistory";
            this.TbxHistory.ReadOnly = true;
            this.TbxHistory.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbxHistory.Size = new System.Drawing.Size(736, 286);
            this.TbxHistory.TabIndex = 3;
            this.TbxHistory.TabStop = false;
            this.TbxHistory.WordWrap = false;
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnClear.BackColor = System.Drawing.Color.DarkGray;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClear.Location = new System.Drawing.Point(32, 384);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(184, 47);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "Очистка журнала";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnLoadFile
            // 
            this.BtnLoadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnLoadFile.BackColor = System.Drawing.Color.DarkGray;
            this.BtnLoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoadFile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnLoadFile.Location = new System.Drawing.Point(296, 384);
            this.BtnLoadFile.Name = "BtnLoadFile";
            this.BtnLoadFile.Size = new System.Drawing.Size(208, 47);
            this.BtnLoadFile.TabIndex = 1;
            this.BtnLoadFile.Text = "Открыть файл журнала";
            this.BtnLoadFile.UseVisualStyleBackColor = false;
            this.BtnLoadFile.Click += new System.EventHandler(this.BtnLoadFile_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.IndianRed;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClose.Location = new System.Drawing.Point(584, 384);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(184, 47);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "Выход";
            this.BtnClose.UseVisualStyleBackColor = false;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(800, 442);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnLoadFile);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.LblHistory);
            this.Controls.Add(this.TbxHistory);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(816, 481);
            this.Name = "LogForm";
            this.Text = "Журнал";
            this.Load += new System.EventHandler(this.LogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHistory;
        private System.Windows.Forms.TextBox TbxHistory;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnLoadFile;
        private System.Windows.Forms.Button BtnClose;
    }
}