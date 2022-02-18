namespace ManyForms
{
    partial class FirstForm
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstForm));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txbString = new System.Windows.Forms.TextBox();
            this.chbMode = new System.Windows.Forms.CheckBox();
            this.btnWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(176, 216);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(144, 32);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(352, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txbString
            // 
            this.txbString.Location = new System.Drawing.Point(32, 72);
            this.txbString.Name = "txbString";
            this.txbString.Size = new System.Drawing.Size(472, 20);
            this.txbString.TabIndex = 2;
            // 
            // chbMode
            // 
            this.chbMode.AutoSize = true;
            this.chbMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbMode.ForeColor = System.Drawing.Color.GreenYellow;
            this.chbMode.Location = new System.Drawing.Point(32, 112);
            this.chbMode.Name = "chbMode";
            this.chbMode.Size = new System.Drawing.Size(174, 17);
            this.chbMode.TabIndex = 3;
            this.chbMode.Text = "Это произвольный текст";
            this.chbMode.UseVisualStyleBackColor = true;
            // 
            // btnWindow
            // 
            this.btnWindow.Location = new System.Drawing.Point(352, 160);
            this.btnWindow.Name = "btnWindow";
            this.btnWindow.Size = new System.Drawing.Size(144, 32);
            this.btnWindow.TabIndex = 4;
            this.btnWindow.Text = "Новое окно";
            this.btnWindow.UseVisualStyleBackColor = true;
            this.btnWindow.Click += new System.EventHandler(this.btnWindow_Click);
            // 
            // FirstForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(541, 261);
            this.Controls.Add(this.btnWindow);
            this.Controls.Add(this.chbMode);
            this.Controls.Add(this.txbString);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(557, 300);
            this.MinimumSize = new System.Drawing.Size(557, 300);
            this.Name = "FirstForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txbString;
        private System.Windows.Forms.CheckBox chbMode;
        private System.Windows.Forms.Button btnWindow;
    }
}