namespace HomeWork.Views
{
    partial class RepairShopForm
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
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxbCurrentAddress = new System.Windows.Forms.TextBox();
            this.TxbCurrentName = new System.Windows.Forms.TextBox();
            this.LblCurrentAddress = new System.Windows.Forms.Label();
            this.LblCurrentName = new System.Windows.Forms.Label();
            this.TxbAddress = new System.Windows.Forms.TextBox();
            this.TxbName = new System.Windows.Forms.TextBox();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BtnEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnEdit.Enabled = false;
            this.BtnEdit.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.Location = new System.Drawing.Point(192, 264);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(320, 64);
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.Text = "Применить";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(536, 264);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(240, 64);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // TxbCurrentAddress
            // 
            this.TxbCurrentAddress.Enabled = false;
            this.TxbCurrentAddress.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxbCurrentAddress.Location = new System.Drawing.Point(416, 64);
            this.TxbCurrentAddress.Name = "TxbCurrentAddress";
            this.TxbCurrentAddress.Size = new System.Drawing.Size(360, 40);
            this.TxbCurrentAddress.TabIndex = 21;
            // 
            // TxbCurrentName
            // 
            this.TxbCurrentName.Enabled = false;
            this.TxbCurrentName.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxbCurrentName.Location = new System.Drawing.Point(24, 64);
            this.TxbCurrentName.Name = "TxbCurrentName";
            this.TxbCurrentName.Size = new System.Drawing.Size(360, 40);
            this.TxbCurrentName.TabIndex = 15;
            // 
            // LblCurrentAddress
            // 
            this.LblCurrentAddress.BackColor = System.Drawing.Color.DarkGray;
            this.LblCurrentAddress.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCurrentAddress.ForeColor = System.Drawing.Color.White;
            this.LblCurrentAddress.Location = new System.Drawing.Point(416, 16);
            this.LblCurrentAddress.Name = "LblCurrentAddress";
            this.LblCurrentAddress.Size = new System.Drawing.Size(360, 48);
            this.LblCurrentAddress.TabIndex = 24;
            this.LblCurrentAddress.Text = "Текущий адрес";
            this.LblCurrentAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCurrentName
            // 
            this.LblCurrentName.BackColor = System.Drawing.Color.DarkGray;
            this.LblCurrentName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCurrentName.ForeColor = System.Drawing.Color.White;
            this.LblCurrentName.Location = new System.Drawing.Point(24, 16);
            this.LblCurrentName.Name = "LblCurrentName";
            this.LblCurrentName.Size = new System.Drawing.Size(360, 48);
            this.LblCurrentName.TabIndex = 16;
            this.LblCurrentName.Text = "Текущее название";
            this.LblCurrentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxbAddress
            // 
            this.TxbAddress.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxbAddress.Location = new System.Drawing.Point(416, 184);
            this.TxbAddress.Name = "TxbAddress";
            this.TxbAddress.Size = new System.Drawing.Size(360, 40);
            this.TxbAddress.TabIndex = 1;
            this.TxbAddress.TextChanged += new System.EventHandler(this.CheckFields_Command);
            this.TxbAddress.Validating += new System.ComponentModel.CancelEventHandler(this.CheckFields_Command);
            // 
            // TxbName
            // 
            this.TxbName.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxbName.Location = new System.Drawing.Point(24, 184);
            this.TxbName.Name = "TxbName";
            this.TxbName.Size = new System.Drawing.Size(360, 40);
            this.TxbName.TabIndex = 0;
            this.TxbName.TextChanged += new System.EventHandler(this.CheckFields_Command);
            this.TxbName.Validating += new System.ComponentModel.CancelEventHandler(this.CheckFields_Command);
            // 
            // LblAddress
            // 
            this.LblAddress.BackColor = System.Drawing.Color.DarkGray;
            this.LblAddress.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblAddress.ForeColor = System.Drawing.Color.White;
            this.LblAddress.Location = new System.Drawing.Point(416, 136);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(360, 48);
            this.LblAddress.TabIndex = 32;
            this.LblAddress.Text = "Адрес";
            this.LblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblName
            // 
            this.LblName.BackColor = System.Drawing.Color.DarkGray;
            this.LblName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblName.ForeColor = System.Drawing.Color.White;
            this.LblName.Location = new System.Drawing.Point(24, 136);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(360, 48);
            this.LblName.TabIndex = 30;
            this.LblName.Text = "Название";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RepairShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 344);
            this.Controls.Add(this.TxbAddress);
            this.Controls.Add(this.TxbName);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.TxbCurrentAddress);
            this.Controls.Add(this.TxbCurrentName);
            this.Controls.Add(this.LblCurrentAddress);
            this.Controls.Add(this.LblCurrentName);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.Name = "RepairShopForm";
            this.Text = "Редактирование данных о мастерской";
            this.Load += new System.EventHandler(this.RepairShopForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxbCurrentAddress;
        private System.Windows.Forms.TextBox TxbCurrentName;
        private System.Windows.Forms.Label LblCurrentAddress;
        private System.Windows.Forms.Label LblCurrentName;
        private System.Windows.Forms.TextBox TxbAddress;
        private System.Windows.Forms.TextBox TxbName;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblName;
    }
}