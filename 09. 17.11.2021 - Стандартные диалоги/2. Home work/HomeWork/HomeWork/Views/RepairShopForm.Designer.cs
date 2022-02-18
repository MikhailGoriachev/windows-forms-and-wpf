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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepairShopForm));
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
            this.TxbFilePath = new System.Windows.Forms.TextBox();
            this.LblFile = new System.Windows.Forms.Label();
            this.BtnChangeFile = new System.Windows.Forms.Button();
            this.SfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEdit.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BtnEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnEdit.Enabled = false;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.Location = new System.Drawing.Point(232, 352);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(288, 64);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.Text = "Применить";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(536, 352);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(240, 64);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // TxbCurrentAddress
            // 
            this.TxbCurrentAddress.Enabled = false;
            this.TxbCurrentAddress.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxbCurrentAddress.Location = new System.Drawing.Point(416, 64);
            this.TxbCurrentAddress.Name = "TxbCurrentAddress";
            this.TxbCurrentAddress.Size = new System.Drawing.Size(360, 33);
            this.TxbCurrentAddress.TabIndex = 1;
            this.TxbCurrentAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxbCurrentName
            // 
            this.TxbCurrentName.Enabled = false;
            this.TxbCurrentName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxbCurrentName.Location = new System.Drawing.Point(24, 64);
            this.TxbCurrentName.Name = "TxbCurrentName";
            this.TxbCurrentName.Size = new System.Drawing.Size(360, 33);
            this.TxbCurrentName.TabIndex = 0;
            this.TxbCurrentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblCurrentAddress
            // 
            this.LblCurrentAddress.BackColor = System.Drawing.Color.DarkGray;
            this.LblCurrentAddress.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCurrentAddress.ForeColor = System.Drawing.Color.White;
            this.LblCurrentAddress.Location = new System.Drawing.Point(416, 24);
            this.LblCurrentAddress.Name = "LblCurrentAddress";
            this.LblCurrentAddress.Size = new System.Drawing.Size(360, 40);
            this.LblCurrentAddress.TabIndex = 24;
            this.LblCurrentAddress.Text = "Текущий адрес";
            this.LblCurrentAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCurrentName
            // 
            this.LblCurrentName.BackColor = System.Drawing.Color.DarkGray;
            this.LblCurrentName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCurrentName.ForeColor = System.Drawing.Color.White;
            this.LblCurrentName.Location = new System.Drawing.Point(24, 24);
            this.LblCurrentName.Name = "LblCurrentName";
            this.LblCurrentName.Size = new System.Drawing.Size(360, 40);
            this.LblCurrentName.TabIndex = 16;
            this.LblCurrentName.Text = "Текущее название";
            this.LblCurrentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxbAddress
            // 
            this.TxbAddress.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TxbAddress.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxbAddress.Location = new System.Drawing.Point(416, 176);
            this.TxbAddress.Name = "TxbAddress";
            this.TxbAddress.Size = new System.Drawing.Size(360, 33);
            this.TxbAddress.TabIndex = 3;
            this.TxbAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxbAddress.TextChanged += new System.EventHandler(this.CheckFields_Command);
            this.TxbAddress.Validating += new System.ComponentModel.CancelEventHandler(this.CheckFields_Command);
            // 
            // TxbName
            // 
            this.TxbName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TxbName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxbName.Location = new System.Drawing.Point(24, 176);
            this.TxbName.Name = "TxbName";
            this.TxbName.Size = new System.Drawing.Size(360, 33);
            this.TxbName.TabIndex = 2;
            this.TxbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxbName.TextChanged += new System.EventHandler(this.CheckFields_Command);
            this.TxbName.Validating += new System.ComponentModel.CancelEventHandler(this.CheckFields_Command);
            // 
            // LblAddress
            // 
            this.LblAddress.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblAddress.BackColor = System.Drawing.Color.DarkGray;
            this.LblAddress.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblAddress.ForeColor = System.Drawing.Color.White;
            this.LblAddress.Location = new System.Drawing.Point(416, 136);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(360, 40);
            this.LblAddress.TabIndex = 32;
            this.LblAddress.Text = "Адрес";
            this.LblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblName
            // 
            this.LblName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblName.BackColor = System.Drawing.Color.DarkGray;
            this.LblName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblName.ForeColor = System.Drawing.Color.White;
            this.LblName.Location = new System.Drawing.Point(24, 136);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(360, 40);
            this.LblName.TabIndex = 30;
            this.LblName.Text = "Название";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxbFilePath
            // 
            this.TxbFilePath.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TxbFilePath.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxbFilePath.Location = new System.Drawing.Point(24, 288);
            this.TxbFilePath.Name = "TxbFilePath";
            this.TxbFilePath.ReadOnly = true;
            this.TxbFilePath.Size = new System.Drawing.Size(752, 33);
            this.TxbFilePath.TabIndex = 33;
            this.TxbFilePath.TabStop = false;
            this.TxbFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxbFilePath.TextChanged += new System.EventHandler(this.CheckFields_Command);
            this.TxbFilePath.Validating += new System.ComponentModel.CancelEventHandler(this.CheckFields_Command);
            // 
            // LblFile
            // 
            this.LblFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblFile.BackColor = System.Drawing.Color.DarkGray;
            this.LblFile.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblFile.ForeColor = System.Drawing.Color.White;
            this.LblFile.Location = new System.Drawing.Point(24, 248);
            this.LblFile.Name = "LblFile";
            this.LblFile.Size = new System.Drawing.Size(752, 40);
            this.LblFile.TabIndex = 34;
            this.LblFile.Text = "Файл сохранения";
            this.LblFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnChangeFile
            // 
            this.BtnChangeFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnChangeFile.BackColor = System.Drawing.Color.Gray;
            this.BtnChangeFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangeFile.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnChangeFile.ForeColor = System.Drawing.Color.White;
            this.BtnChangeFile.Location = new System.Drawing.Point(24, 352);
            this.BtnChangeFile.Name = "BtnChangeFile";
            this.BtnChangeFile.Size = new System.Drawing.Size(192, 64);
            this.BtnChangeFile.TabIndex = 4;
            this.BtnChangeFile.Text = "Изменить файл";
            this.BtnChangeFile.UseVisualStyleBackColor = false;
            this.BtnChangeFile.Click += new System.EventHandler(this.SelectFile_Command);
            // 
            // SfdSaveFile
            // 
            this.SfdSaveFile.CheckFileExists = true;
            this.SfdSaveFile.CreatePrompt = true;
            this.SfdSaveFile.DefaultExt = "json";
            this.SfdSaveFile.FileName = ".\\RepairShop_Data.json";
            this.SfdSaveFile.Filter = "Файлы JSON (*.JSON) | *.JSON";
            this.SfdSaveFile.InitialDirectory = ".\\";
            this.SfdSaveFile.RestoreDirectory = true;
            this.SfdSaveFile.SupportMultiDottedExtensions = true;
            this.SfdSaveFile.Title = "Сохранить в файл данные мастерской";
            this.SfdSaveFile.ValidateNames = false;
            // 
            // RepairShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 442);
            this.Controls.Add(this.BtnChangeFile);
            this.Controls.Add(this.TxbFilePath);
            this.Controls.Add(this.LblFile);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RepairShopForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
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
        private System.Windows.Forms.TextBox TxbFilePath;
        private System.Windows.Forms.Label LblFile;
        private System.Windows.Forms.Button BtnChangeFile;
        private System.Windows.Forms.SaveFileDialog SfdSaveFile;
    }
}