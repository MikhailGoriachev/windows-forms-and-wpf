namespace HomeWork.Views
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.TbxCurrentAddress = new System.Windows.Forms.TextBox();
            this.LblCurrentAddress = new System.Windows.Forms.Label();
            this.TbxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbxCurrentAddress
            // 
            this.TbxCurrentAddress.BackColor = System.Drawing.Color.Silver;
            this.TbxCurrentAddress.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxCurrentAddress.Location = new System.Drawing.Point(24, 64);
            this.TbxCurrentAddress.Name = "TbxCurrentAddress";
            this.TbxCurrentAddress.ReadOnly = true;
            this.TbxCurrentAddress.Size = new System.Drawing.Size(408, 27);
            this.TbxCurrentAddress.TabIndex = 3;
            this.TbxCurrentAddress.TabStop = false;
            this.TbxCurrentAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblCurrentAddress
            // 
            this.LblCurrentAddress.BackColor = System.Drawing.Color.DarkGray;
            this.LblCurrentAddress.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCurrentAddress.Location = new System.Drawing.Point(24, 24);
            this.LblCurrentAddress.Name = "LblCurrentAddress";
            this.LblCurrentAddress.Size = new System.Drawing.Size(408, 40);
            this.LblCurrentAddress.TabIndex = 2;
            this.LblCurrentAddress.Text = "Текущий адрес дома";
            this.LblCurrentAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbxAddress
            // 
            this.TbxAddress.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TbxAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.TbxAddress.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxAddress.Location = new System.Drawing.Point(24, 150);
            this.TbxAddress.Name = "TbxAddress";
            this.TbxAddress.Size = new System.Drawing.Size(408, 27);
            this.TbxAddress.TabIndex = 0;
            this.TbxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbxAddress.TextChanged += new System.EventHandler(this.TbxAddress_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAddress.BackColor = System.Drawing.Color.DarkGray;
            this.lblAddress.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddress.Location = new System.Drawing.Point(24, 110);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(408, 40);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = " Адрес дома ";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCancel.Location = new System.Drawing.Point(248, 210);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(184, 48);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnOk
            // 
            this.BtnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BtnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnOk.BackColor = System.Drawing.Color.Silver;
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnOk.Location = new System.Drawing.Point(24, 210);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(184, 48);
            this.BtnOk.TabIndex = 1;
            this.BtnOk.Text = "Изменить";
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(456, 285);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.TbxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.TbxCurrentAddress);
            this.Controls.Add(this.LblCurrentAddress);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение дома";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxCurrentAddress;
        private System.Windows.Forms.Label LblCurrentAddress;
        private System.Windows.Forms.TextBox TbxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOk;
    }
}