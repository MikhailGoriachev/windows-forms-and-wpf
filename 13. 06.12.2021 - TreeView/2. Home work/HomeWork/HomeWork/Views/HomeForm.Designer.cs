namespace Appliances.Views
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
            this.TbxCurrentTitle = new System.Windows.Forms.TextBox();
            this.LblCurrentTitle = new System.Windows.Forms.Label();
            this.TbxTitle = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
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
            this.TbxAddress.Location = new System.Drawing.Point(24, 315);
            this.TbxAddress.Name = "TbxAddress";
            this.TbxAddress.Size = new System.Drawing.Size(408, 27);
            this.TbxAddress.TabIndex = 1;
            this.TbxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbxAddress.TextChanged += new System.EventHandler(this.TextBoxChange_Command);
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAddress.BackColor = System.Drawing.Color.DarkGray;
            this.lblAddress.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddress.Location = new System.Drawing.Point(24, 275);
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
            this.BtnCancel.Location = new System.Drawing.Point(248, 375);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(184, 48);
            this.BtnCancel.TabIndex = 3;
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
            this.BtnOk.Location = new System.Drawing.Point(24, 375);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(184, 48);
            this.BtnOk.TabIndex = 2;
            this.BtnOk.Text = "Изменить";
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // TbxCurrentTitle
            // 
            this.TbxCurrentTitle.BackColor = System.Drawing.Color.Silver;
            this.TbxCurrentTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxCurrentTitle.Location = new System.Drawing.Point(24, 144);
            this.TbxCurrentTitle.Name = "TbxCurrentTitle";
            this.TbxCurrentTitle.ReadOnly = true;
            this.TbxCurrentTitle.Size = new System.Drawing.Size(408, 27);
            this.TbxCurrentTitle.TabIndex = 6;
            this.TbxCurrentTitle.TabStop = false;
            this.TbxCurrentTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblCurrentTitle
            // 
            this.LblCurrentTitle.BackColor = System.Drawing.Color.DarkGray;
            this.LblCurrentTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCurrentTitle.Location = new System.Drawing.Point(24, 104);
            this.LblCurrentTitle.Name = "LblCurrentTitle";
            this.LblCurrentTitle.Size = new System.Drawing.Size(408, 40);
            this.LblCurrentTitle.TabIndex = 5;
            this.LblCurrentTitle.Text = "Текущее название дома";
            this.LblCurrentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbxTitle
            // 
            this.TbxTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TbxTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.TbxTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxTitle.Location = new System.Drawing.Point(24, 236);
            this.TbxTitle.Name = "TbxTitle";
            this.TbxTitle.Size = new System.Drawing.Size(408, 27);
            this.TbxTitle.TabIndex = 0;
            this.TbxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbxTitle.TextChanged += new System.EventHandler(this.TextBoxChange_Command);
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblTitle.BackColor = System.Drawing.Color.DarkGray;
            this.LblTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTitle.Location = new System.Drawing.Point(24, 196);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(408, 40);
            this.LblTitle.TabIndex = 8;
            this.LblTitle.Text = "Название дома";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.TbxTitle);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.TbxCurrentTitle);
            this.Controls.Add(this.LblCurrentTitle);
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
        private System.Windows.Forms.TextBox TbxCurrentTitle;
        private System.Windows.Forms.Label LblCurrentTitle;
        private System.Windows.Forms.TextBox TbxTitle;
        private System.Windows.Forms.Label LblTitle;
    }
}