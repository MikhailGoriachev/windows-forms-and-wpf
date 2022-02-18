namespace HomeWork.Views
{
    partial class TelevisionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelevisionForm));
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblDiagonal = new System.Windows.Forms.Label();
            this.LblDefect = new System.Windows.Forms.Label();
            this.LblMaster = new System.Windows.Forms.Label();
            this.LblOwner = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.TxbModel = new System.Windows.Forms.TextBox();
            this.TxbOwner = new System.Windows.Forms.TextBox();
            this.CbxDefect = new System.Windows.Forms.ComboBox();
            this.CbxDiagonal = new System.Windows.Forms.ComboBox();
            this.CbxMaster = new System.Windows.Forms.ComboBox();
            this.NudPrice = new System.Windows.Forms.NumericUpDown();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.BackColor = System.Drawing.Color.DarkGray;
            this.LblTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(16, 32);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(360, 40);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Производитель и тип";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblDiagonal
            // 
            this.LblDiagonal.BackColor = System.Drawing.Color.DarkGray;
            this.LblDiagonal.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblDiagonal.ForeColor = System.Drawing.Color.White;
            this.LblDiagonal.Location = new System.Drawing.Point(16, 148);
            this.LblDiagonal.Name = "LblDiagonal";
            this.LblDiagonal.Size = new System.Drawing.Size(360, 44);
            this.LblDiagonal.TabIndex = 1;
            this.LblDiagonal.Text = "Диагональ экрана";
            this.LblDiagonal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblDefect
            // 
            this.LblDefect.BackColor = System.Drawing.Color.DarkGray;
            this.LblDefect.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblDefect.ForeColor = System.Drawing.Color.White;
            this.LblDefect.Location = new System.Drawing.Point(16, 264);
            this.LblDefect.Name = "LblDefect";
            this.LblDefect.Size = new System.Drawing.Size(360, 40);
            this.LblDefect.TabIndex = 2;
            this.LblDefect.Text = "Выбор дефекта";
            this.LblDefect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblMaster
            // 
            this.LblMaster.BackColor = System.Drawing.Color.DarkGray;
            this.LblMaster.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblMaster.ForeColor = System.Drawing.Color.White;
            this.LblMaster.Location = new System.Drawing.Point(416, 32);
            this.LblMaster.Name = "LblMaster";
            this.LblMaster.Size = new System.Drawing.Size(360, 40);
            this.LblMaster.TabIndex = 3;
            this.LblMaster.Text = "Мастер";
            this.LblMaster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblOwner
            // 
            this.LblOwner.BackColor = System.Drawing.Color.DarkGray;
            this.LblOwner.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblOwner.ForeColor = System.Drawing.Color.White;
            this.LblOwner.Location = new System.Drawing.Point(416, 148);
            this.LblOwner.Name = "LblOwner";
            this.LblOwner.Size = new System.Drawing.Size(360, 44);
            this.LblOwner.TabIndex = 4;
            this.LblOwner.Text = "Владелец";
            this.LblOwner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPrice
            // 
            this.LblPrice.BackColor = System.Drawing.Color.DarkGray;
            this.LblPrice.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPrice.ForeColor = System.Drawing.Color.White;
            this.LblPrice.Location = new System.Drawing.Point(416, 264);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(360, 40);
            this.LblPrice.TabIndex = 5;
            this.LblPrice.Text = "Цена";
            this.LblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxbModel
            // 
            this.TxbModel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxbModel.Location = new System.Drawing.Point(16, 72);
            this.TxbModel.Name = "TxbModel";
            this.TxbModel.Size = new System.Drawing.Size(360, 33);
            this.TxbModel.TabIndex = 0;
            this.TxbModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxbModel.TextChanged += new System.EventHandler(this.CheckFields_Command);
            this.TxbModel.Validating += new System.ComponentModel.CancelEventHandler(this.CheckFields_Command);
            // 
            // TxbOwner
            // 
            this.TxbOwner.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxbOwner.Location = new System.Drawing.Point(416, 192);
            this.TxbOwner.Name = "TxbOwner";
            this.TxbOwner.Size = new System.Drawing.Size(360, 33);
            this.TxbOwner.TabIndex = 3;
            this.TxbOwner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxbOwner.TextChanged += new System.EventHandler(this.CheckFields_Command);
            this.TxbOwner.Validating += new System.ComponentModel.CancelEventHandler(this.CheckFields_Command);
            // 
            // CbxDefect
            // 
            this.CbxDefect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxDefect.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbxDefect.FormattingEnabled = true;
            this.CbxDefect.Items.AddRange(new object[] {
            "Выход из строя модуля цветности",
            "Поломка блока питания",
            "Поломка электрического управления",
            "Неисправность селектора радиоканалов",
            "Поломка усилителя частот",
            "Поломка матрицы телевизора"});
            this.CbxDefect.Location = new System.Drawing.Point(16, 304);
            this.CbxDefect.Name = "CbxDefect";
            this.CbxDefect.Size = new System.Drawing.Size(360, 33);
            this.CbxDefect.TabIndex = 4;
            // 
            // CbxDiagonal
            // 
            this.CbxDiagonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxDiagonal.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbxDiagonal.FormattingEnabled = true;
            this.CbxDiagonal.Items.AddRange(new object[] {
            "22",
            "26",
            "32",
            "37",
            "40",
            "42",
            "46",
            "50",
            "60",
            "65"});
            this.CbxDiagonal.Location = new System.Drawing.Point(16, 192);
            this.CbxDiagonal.Name = "CbxDiagonal";
            this.CbxDiagonal.Size = new System.Drawing.Size(360, 33);
            this.CbxDiagonal.TabIndex = 2;
            // 
            // CbxMaster
            // 
            this.CbxMaster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxMaster.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbxMaster.FormattingEnabled = true;
            this.CbxMaster.Items.AddRange(new object[] {
            "Князев И. А.",
            "Соколова В. К.",
            "Минин П. К.",
            "Михайлов Д. Я."});
            this.CbxMaster.Location = new System.Drawing.Point(416, 72);
            this.CbxMaster.Name = "CbxMaster";
            this.CbxMaster.Size = new System.Drawing.Size(360, 33);
            this.CbxMaster.TabIndex = 1;
            // 
            // NudPrice
            // 
            this.NudPrice.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NudPrice.Location = new System.Drawing.Point(416, 304);
            this.NudPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NudPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudPrice.Name = "NudPrice";
            this.NudPrice.Size = new System.Drawing.Size(360, 33);
            this.NudPrice.TabIndex = 5;
            this.NudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NudPrice_KeyDown);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.IndianRed;
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.No;
            this.BtnExit.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(552, 376);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(216, 64);
            this.BtnExit.TabIndex = 13;
            this.BtnExit.Text = "Выход";
            this.BtnExit.UseVisualStyleBackColor = false;
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BtnCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnCreate.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCreate.ForeColor = System.Drawing.Color.White;
            this.BtnCreate.Location = new System.Drawing.Point(208, 376);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(320, 64);
            this.BtnCreate.TabIndex = 14;
            this.BtnCreate.Text = "Добавить в коллекцию";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // TelevisionForm
            // 
            this.AcceptButton = this.BtnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.NudPrice);
            this.Controls.Add(this.CbxMaster);
            this.Controls.Add(this.CbxDiagonal);
            this.Controls.Add(this.CbxDefect);
            this.Controls.Add(this.TxbOwner);
            this.Controls.Add(this.TxbModel);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.LblOwner);
            this.Controls.Add(this.LblMaster);
            this.Controls.Add(this.LblDefect);
            this.Controls.Add(this.LblDiagonal);
            this.Controls.Add(this.LblTitle);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelevisionForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание записи";
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblDiagonal;
        private System.Windows.Forms.Label LblDefect;
        private System.Windows.Forms.Label LblMaster;
        private System.Windows.Forms.Label LblOwner;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.TextBox TxbModel;
        private System.Windows.Forms.TextBox TxbOwner;
        private System.Windows.Forms.ComboBox CbxDefect;
        private System.Windows.Forms.ComboBox CbxDiagonal;
        private System.Windows.Forms.ComboBox CbxMaster;
        private System.Windows.Forms.NumericUpDown NudPrice;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnCreate;
    }
}