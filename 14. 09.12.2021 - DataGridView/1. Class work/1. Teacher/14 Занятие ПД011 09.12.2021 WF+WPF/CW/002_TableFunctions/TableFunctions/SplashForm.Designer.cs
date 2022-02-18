namespace TableFunctions
{
    partial class SplashForm
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.prbSplash = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Lavender;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.ForeColor = System.Drawing.Color.Purple;
            this.lblInfo.Location = new System.Drawing.Point(0, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(638, 358);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Таблица тригонометрических функций\r\n\r\nВерсия 1.0";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.UseWaitCursor = true;
            this.lblInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblInfo_MouseMove);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(480, 312);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(144, 31);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.UseWaitCursor = true;
            this.btnOk.Visible = false;
            // 
            // prbSplash
            // 
            this.prbSplash.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prbSplash.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.prbSplash.Location = new System.Drawing.Point(0, 348);
            this.prbSplash.Name = "prbSplash";
            this.prbSplash.Size = new System.Drawing.Size(638, 10);
            this.prbSplash.Step = 1;
            this.prbSplash.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbSplash.TabIndex = 2;
            this.prbSplash.UseWaitCursor = true;
            // 
            // SplashForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 358);
            this.ControlBox = false;
            this.Controls.Add(this.prbSplash);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 360);
            this.MinimumSize = new System.Drawing.Size(640, 360);
            this.Name = "SplashForm";
            this.Opacity = 0.8D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.UseWaitCursor = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SplashForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnOk;
        internal System.Windows.Forms.ProgressBar prbSplash;
    }
}