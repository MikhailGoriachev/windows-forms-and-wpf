
namespace DragAndDropDemo
{
    partial class TabControlForm
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
            this.tbcDemo = new System.Windows.Forms.TabControl();
            this.tbpSource = new System.Windows.Forms.TabPage();
            this.lblRedirect = new System.Windows.Forms.Label();
            this.LblSource = new System.Windows.Forms.Label();
            this.tbpDestination = new System.Windows.Forms.TabPage();
            this.btnClrLabel = new System.Windows.Forms.Button();
            this.lblDestination = new System.Windows.Forms.Label();
            this.tbcDemo.SuspendLayout();
            this.tbpSource.SuspendLayout();
            this.tbpDestination.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcDemo
            // 
            this.tbcDemo.AllowDrop = true;
            this.tbcDemo.Controls.Add(this.tbpSource);
            this.tbcDemo.Controls.Add(this.tbpDestination);
            this.tbcDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcDemo.Location = new System.Drawing.Point(0, 0);
            this.tbcDemo.Name = "tbcDemo";
            this.tbcDemo.SelectedIndex = 0;
            this.tbcDemo.Size = new System.Drawing.Size(800, 450);
            this.tbcDemo.TabIndex = 0;
            // 
            // tbpSource
            // 
            this.tbpSource.Controls.Add(this.lblRedirect);
            this.tbpSource.Controls.Add(this.LblSource);
            this.tbpSource.Location = new System.Drawing.Point(4, 22);
            this.tbpSource.Name = "tbpSource";
            this.tbpSource.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSource.Size = new System.Drawing.Size(792, 424);
            this.tbpSource.TabIndex = 0;
            this.tbpSource.Text = "Источник";
            this.tbpSource.UseVisualStyleBackColor = true;
            // 
            // lblRedirect
            // 
            this.lblRedirect.AllowDrop = true;
            this.lblRedirect.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblRedirect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRedirect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRedirect.ForeColor = System.Drawing.Color.Black;
            this.lblRedirect.Location = new System.Drawing.Point(132, 288);
            this.lblRedirect.Name = "lblRedirect";
            this.lblRedirect.Size = new System.Drawing.Size(504, 72);
            this.lblRedirect.TabIndex = 1;
            this.lblRedirect.Text = "Перетащите текст сюда";
            this.lblRedirect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRedirect.DragDrop += new System.Windows.Forms.DragEventHandler(this.LblRedirect_DragDrop);
            this.lblRedirect.DragEnter += new System.Windows.Forms.DragEventHandler(this.LblRedirect_DragEnter);
            // 
            // LblSource
            // 
            this.LblSource.BackColor = System.Drawing.Color.PaleGreen;
            this.LblSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSource.Location = new System.Drawing.Point(40, 40);
            this.LblSource.Name = "LblSource";
            this.LblSource.Size = new System.Drawing.Size(688, 160);
            this.LblSource.TabIndex = 0;
            this.LblSource.Text = "Демонстрационный текст";
            this.LblSource.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblSource.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown);
            // 
            // tbpDestination
            // 
            this.tbpDestination.AllowDrop = true;
            this.tbpDestination.Controls.Add(this.btnClrLabel);
            this.tbpDestination.Controls.Add(this.lblDestination);
            this.tbpDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbpDestination.Location = new System.Drawing.Point(4, 22);
            this.tbpDestination.Name = "tbpDestination";
            this.tbpDestination.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDestination.Size = new System.Drawing.Size(792, 424);
            this.tbpDestination.TabIndex = 1;
            this.tbpDestination.Text = "Приемник";
            this.tbpDestination.UseVisualStyleBackColor = true;
            // 
            // btnClrLabel
            // 
            this.btnClrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnClrLabel.Location = new System.Drawing.Point(272, 40);
            this.btnClrLabel.Name = "btnClrLabel";
            this.btnClrLabel.Size = new System.Drawing.Size(248, 48);
            this.btnClrLabel.TabIndex = 2;
            this.btnClrLabel.Text = "Очистка метки";
            this.btnClrLabel.UseVisualStyleBackColor = true;
            this.btnClrLabel.Click += new System.EventHandler(this.BtnClrLabel_Click);
            // 
            // lblDestination
            // 
            this.lblDestination.AllowDrop = true;
            this.lblDestination.BackColor = System.Drawing.Color.Lavender;
            this.lblDestination.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDestination.Location = new System.Drawing.Point(52, 120);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(688, 172);
            this.lblDestination.TabIndex = 1;
            this.lblDestination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcDemo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TabControlForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TabControlForm";
            this.tbcDemo.ResumeLayout(false);
            this.tbpSource.ResumeLayout(false);
            this.tbpDestination.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcDemo;
        private System.Windows.Forms.TabPage tbpSource;
        private System.Windows.Forms.TabPage tbpDestination;
        private System.Windows.Forms.Label LblSource;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblRedirect;
        private System.Windows.Forms.Button btnClrLabel;
    }
}