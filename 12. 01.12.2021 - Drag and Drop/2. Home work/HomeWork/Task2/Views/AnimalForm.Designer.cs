namespace Animals.Views
{
    partial class AnimalForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalForm));
            this.LblCurrentSpecials = new System.Windows.Forms.Label();
            this.GbxCurrentData = new System.Windows.Forms.GroupBox();
            this.TbxCurrentOwner = new System.Windows.Forms.TextBox();
            this.TbxCurrentColor = new System.Windows.Forms.TextBox();
            this.TbxCurrentAge = new System.Windows.Forms.TextBox();
            this.TbxCurrentWeight = new System.Windows.Forms.TextBox();
            this.TbxCurrentName = new System.Windows.Forms.TextBox();
            this.TbxCurrentSpecials = new System.Windows.Forms.TextBox();
            this.LblCurrentOwner = new System.Windows.Forms.Label();
            this.LblCurrentColor = new System.Windows.Forms.Label();
            this.LblCurrentAge = new System.Windows.Forms.Label();
            this.LblCurrentWeight = new System.Windows.Forms.Label();
            this.LblCurrentName = new System.Windows.Forms.Label();
            this.GbxNewData = new System.Windows.Forms.GroupBox();
            this.NudAge = new System.Windows.Forms.NumericUpDown();
            this.NudWeight = new System.Windows.Forms.NumericUpDown();
            this.TbxOwner = new System.Windows.Forms.TextBox();
            this.CbxColors = new System.Windows.Forms.ComboBox();
            this.CbxSpecials = new System.Windows.Forms.ComboBox();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.LblOwner = new System.Windows.Forms.Label();
            this.LblColor = new System.Windows.Forms.Label();
            this.LblAge = new System.Windows.Forms.Label();
            this.LblWeight = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblSpecials = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.ErpOwner = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbxCurrentData.SuspendLayout();
            this.GbxNewData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErpOwner)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCurrentSpecials
            // 
            this.LblCurrentSpecials.BackColor = System.Drawing.Color.DarkGray;
            this.LblCurrentSpecials.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCurrentSpecials.ForeColor = System.Drawing.Color.White;
            this.LblCurrentSpecials.Location = new System.Drawing.Point(16, 24);
            this.LblCurrentSpecials.Name = "LblCurrentSpecials";
            this.LblCurrentSpecials.Size = new System.Drawing.Size(272, 40);
            this.LblCurrentSpecials.TabIndex = 0;
            this.LblCurrentSpecials.Text = "Вид животного";
            this.LblCurrentSpecials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GbxCurrentData
            // 
            this.GbxCurrentData.Controls.Add(this.TbxCurrentOwner);
            this.GbxCurrentData.Controls.Add(this.TbxCurrentColor);
            this.GbxCurrentData.Controls.Add(this.TbxCurrentAge);
            this.GbxCurrentData.Controls.Add(this.TbxCurrentWeight);
            this.GbxCurrentData.Controls.Add(this.TbxCurrentName);
            this.GbxCurrentData.Controls.Add(this.TbxCurrentSpecials);
            this.GbxCurrentData.Controls.Add(this.LblCurrentOwner);
            this.GbxCurrentData.Controls.Add(this.LblCurrentColor);
            this.GbxCurrentData.Controls.Add(this.LblCurrentAge);
            this.GbxCurrentData.Controls.Add(this.LblCurrentWeight);
            this.GbxCurrentData.Controls.Add(this.LblCurrentName);
            this.GbxCurrentData.Controls.Add(this.LblCurrentSpecials);
            this.GbxCurrentData.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxCurrentData.ForeColor = System.Drawing.Color.White;
            this.GbxCurrentData.Location = new System.Drawing.Point(8, 8);
            this.GbxCurrentData.Name = "GbxCurrentData";
            this.GbxCurrentData.Size = new System.Drawing.Size(896, 192);
            this.GbxCurrentData.TabIndex = 1;
            this.GbxCurrentData.TabStop = false;
            this.GbxCurrentData.Text = " Текущие данные ";
            // 
            // TbxCurrentOwner
            // 
            this.TbxCurrentOwner.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TbxCurrentOwner.Location = new System.Drawing.Point(608, 152);
            this.TbxCurrentOwner.Name = "TbxCurrentOwner";
            this.TbxCurrentOwner.ReadOnly = true;
            this.TbxCurrentOwner.Size = new System.Drawing.Size(272, 26);
            this.TbxCurrentOwner.TabIndex = 11;
            this.TbxCurrentOwner.TabStop = false;
            // 
            // TbxCurrentColor
            // 
            this.TbxCurrentColor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TbxCurrentColor.Location = new System.Drawing.Point(608, 64);
            this.TbxCurrentColor.Name = "TbxCurrentColor";
            this.TbxCurrentColor.ReadOnly = true;
            this.TbxCurrentColor.Size = new System.Drawing.Size(272, 26);
            this.TbxCurrentColor.TabIndex = 10;
            this.TbxCurrentColor.TabStop = false;
            // 
            // TbxCurrentAge
            // 
            this.TbxCurrentAge.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TbxCurrentAge.Location = new System.Drawing.Point(312, 152);
            this.TbxCurrentAge.Name = "TbxCurrentAge";
            this.TbxCurrentAge.ReadOnly = true;
            this.TbxCurrentAge.Size = new System.Drawing.Size(272, 26);
            this.TbxCurrentAge.TabIndex = 9;
            this.TbxCurrentAge.TabStop = false;
            // 
            // TbxCurrentWeight
            // 
            this.TbxCurrentWeight.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TbxCurrentWeight.Location = new System.Drawing.Point(16, 152);
            this.TbxCurrentWeight.Name = "TbxCurrentWeight";
            this.TbxCurrentWeight.ReadOnly = true;
            this.TbxCurrentWeight.Size = new System.Drawing.Size(272, 26);
            this.TbxCurrentWeight.TabIndex = 8;
            this.TbxCurrentWeight.TabStop = false;
            // 
            // TbxCurrentName
            // 
            this.TbxCurrentName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TbxCurrentName.Location = new System.Drawing.Point(312, 64);
            this.TbxCurrentName.Name = "TbxCurrentName";
            this.TbxCurrentName.ReadOnly = true;
            this.TbxCurrentName.Size = new System.Drawing.Size(272, 26);
            this.TbxCurrentName.TabIndex = 7;
            this.TbxCurrentName.TabStop = false;
            // 
            // TbxCurrentSpecials
            // 
            this.TbxCurrentSpecials.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TbxCurrentSpecials.Location = new System.Drawing.Point(16, 64);
            this.TbxCurrentSpecials.Name = "TbxCurrentSpecials";
            this.TbxCurrentSpecials.ReadOnly = true;
            this.TbxCurrentSpecials.Size = new System.Drawing.Size(272, 26);
            this.TbxCurrentSpecials.TabIndex = 6;
            this.TbxCurrentSpecials.TabStop = false;
            // 
            // LblCurrentOwner
            // 
            this.LblCurrentOwner.BackColor = System.Drawing.Color.DarkGray;
            this.LblCurrentOwner.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCurrentOwner.ForeColor = System.Drawing.Color.White;
            this.LblCurrentOwner.Location = new System.Drawing.Point(608, 112);
            this.LblCurrentOwner.Name = "LblCurrentOwner";
            this.LblCurrentOwner.Size = new System.Drawing.Size(272, 40);
            this.LblCurrentOwner.TabIndex = 5;
            this.LblCurrentOwner.Text = "Фамилия и инициалы";
            this.LblCurrentOwner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCurrentColor
            // 
            this.LblCurrentColor.BackColor = System.Drawing.Color.DarkGray;
            this.LblCurrentColor.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCurrentColor.ForeColor = System.Drawing.Color.White;
            this.LblCurrentColor.Location = new System.Drawing.Point(608, 24);
            this.LblCurrentColor.Name = "LblCurrentColor";
            this.LblCurrentColor.Size = new System.Drawing.Size(272, 40);
            this.LblCurrentColor.TabIndex = 4;
            this.LblCurrentColor.Text = "Цвет";
            this.LblCurrentColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCurrentAge
            // 
            this.LblCurrentAge.BackColor = System.Drawing.Color.DarkGray;
            this.LblCurrentAge.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCurrentAge.ForeColor = System.Drawing.Color.White;
            this.LblCurrentAge.Location = new System.Drawing.Point(312, 112);
            this.LblCurrentAge.Name = "LblCurrentAge";
            this.LblCurrentAge.Size = new System.Drawing.Size(272, 40);
            this.LblCurrentAge.TabIndex = 3;
            this.LblCurrentAge.Text = "Возраст (год)";
            this.LblCurrentAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCurrentWeight
            // 
            this.LblCurrentWeight.BackColor = System.Drawing.Color.DarkGray;
            this.LblCurrentWeight.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCurrentWeight.ForeColor = System.Drawing.Color.White;
            this.LblCurrentWeight.Location = new System.Drawing.Point(16, 112);
            this.LblCurrentWeight.Name = "LblCurrentWeight";
            this.LblCurrentWeight.Size = new System.Drawing.Size(272, 40);
            this.LblCurrentWeight.TabIndex = 2;
            this.LblCurrentWeight.Text = "Вес (кг)";
            this.LblCurrentWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCurrentName
            // 
            this.LblCurrentName.BackColor = System.Drawing.Color.DarkGray;
            this.LblCurrentName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCurrentName.ForeColor = System.Drawing.Color.White;
            this.LblCurrentName.Location = new System.Drawing.Point(312, 24);
            this.LblCurrentName.Name = "LblCurrentName";
            this.LblCurrentName.Size = new System.Drawing.Size(272, 40);
            this.LblCurrentName.TabIndex = 1;
            this.LblCurrentName.Text = "Кличка";
            this.LblCurrentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GbxNewData
            // 
            this.GbxNewData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GbxNewData.Controls.Add(this.NudAge);
            this.GbxNewData.Controls.Add(this.NudWeight);
            this.GbxNewData.Controls.Add(this.TbxOwner);
            this.GbxNewData.Controls.Add(this.CbxColors);
            this.GbxNewData.Controls.Add(this.CbxSpecials);
            this.GbxNewData.Controls.Add(this.TbxName);
            this.GbxNewData.Controls.Add(this.LblOwner);
            this.GbxNewData.Controls.Add(this.LblColor);
            this.GbxNewData.Controls.Add(this.LblAge);
            this.GbxNewData.Controls.Add(this.LblWeight);
            this.GbxNewData.Controls.Add(this.LblName);
            this.GbxNewData.Controls.Add(this.LblSpecials);
            this.GbxNewData.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxNewData.ForeColor = System.Drawing.Color.White;
            this.GbxNewData.Location = new System.Drawing.Point(8, 208);
            this.GbxNewData.Name = "GbxNewData";
            this.GbxNewData.Size = new System.Drawing.Size(896, 192);
            this.GbxNewData.TabIndex = 12;
            this.GbxNewData.TabStop = false;
            this.GbxNewData.Text = " Новые данные ";
            // 
            // NudAge
            // 
            this.NudAge.Location = new System.Drawing.Point(312, 152);
            this.NudAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudAge.Name = "NudAge";
            this.NudAge.Size = new System.Drawing.Size(272, 26);
            this.NudAge.TabIndex = 4;
            this.NudAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NudWeight
            // 
            this.NudWeight.DecimalPlaces = 5;
            this.NudWeight.Location = new System.Drawing.Point(16, 152);
            this.NudWeight.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.NudWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.NudWeight.Name = "NudWeight";
            this.NudWeight.Size = new System.Drawing.Size(272, 26);
            this.NudWeight.TabIndex = 3;
            this.NudWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudWeight.ThousandsSeparator = true;
            this.NudWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            // 
            // TbxOwner
            // 
            this.TbxOwner.Location = new System.Drawing.Point(608, 152);
            this.TbxOwner.Name = "TbxOwner";
            this.TbxOwner.Size = new System.Drawing.Size(272, 26);
            this.TbxOwner.TabIndex = 5;
            this.TbxOwner.TextChanged += new System.EventHandler(this.TbxOwner_TextChanged);
            this.TbxOwner.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Command);
            this.TbxOwner.Validating += new System.ComponentModel.CancelEventHandler(this.TbxOwner_Validating);
            // 
            // CbxColors
            // 
            this.CbxColors.BackColor = System.Drawing.Color.Gainsboro;
            this.CbxColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxColors.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbxColors.FormattingEnabled = true;
            this.CbxColors.Items.AddRange(new object[] {
            "Черный",
            "Серый",
            "Голубой",
            "Зеленый",
            "Красный",
            "Желтый",
            "Белый",
            "Коричневый"});
            this.CbxColors.Location = new System.Drawing.Point(608, 64);
            this.CbxColors.Name = "CbxColors";
            this.CbxColors.Size = new System.Drawing.Size(272, 26);
            this.CbxColors.TabIndex = 2;
            // 
            // CbxSpecials
            // 
            this.CbxSpecials.BackColor = System.Drawing.Color.Gainsboro;
            this.CbxSpecials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxSpecials.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbxSpecials.FormattingEnabled = true;
            this.CbxSpecials.Items.AddRange(new object[] {
            "Птица",
            "Бык",
            "Кошка",
            "Корова",
            "Собака",
            "Утка",
            "Слон",
            "Рыба",
            "Лошадь",
            "Божья коровка",
            "Леопард",
            "Лев",
            "Лобстер",
            "Заяц",
            "Улитка",
            "Черепаха"});
            this.CbxSpecials.Location = new System.Drawing.Point(16, 64);
            this.CbxSpecials.Name = "CbxSpecials";
            this.CbxSpecials.Size = new System.Drawing.Size(272, 26);
            this.CbxSpecials.TabIndex = 0;
            this.CbxSpecials.SelectedIndexChanged += new System.EventHandler(this.CbxSpecials_SelectedIndexChanged);
            // 
            // TbxName
            // 
            this.TbxName.Location = new System.Drawing.Point(312, 64);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(272, 26);
            this.TbxName.TabIndex = 1;
            this.TbxName.TextChanged += new System.EventHandler(this.TbxName_TextChanged);
            this.TbxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Command);
            // 
            // LblOwner
            // 
            this.LblOwner.BackColor = System.Drawing.Color.DarkGray;
            this.LblOwner.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblOwner.ForeColor = System.Drawing.Color.White;
            this.LblOwner.Location = new System.Drawing.Point(608, 112);
            this.LblOwner.Name = "LblOwner";
            this.LblOwner.Size = new System.Drawing.Size(272, 40);
            this.LblOwner.TabIndex = 5;
            this.LblOwner.Text = "Фамилия и инициалы владельца";
            this.LblOwner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblColor
            // 
            this.LblColor.BackColor = System.Drawing.Color.DarkGray;
            this.LblColor.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblColor.ForeColor = System.Drawing.Color.White;
            this.LblColor.Location = new System.Drawing.Point(608, 24);
            this.LblColor.Name = "LblColor";
            this.LblColor.Size = new System.Drawing.Size(272, 40);
            this.LblColor.TabIndex = 4;
            this.LblColor.Text = "Цвет";
            this.LblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblAge
            // 
            this.LblAge.BackColor = System.Drawing.Color.DarkGray;
            this.LblAge.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblAge.ForeColor = System.Drawing.Color.White;
            this.LblAge.Location = new System.Drawing.Point(312, 112);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(272, 40);
            this.LblAge.TabIndex = 3;
            this.LblAge.Text = "Возраст (год)";
            this.LblAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblWeight
            // 
            this.LblWeight.BackColor = System.Drawing.Color.DarkGray;
            this.LblWeight.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblWeight.ForeColor = System.Drawing.Color.White;
            this.LblWeight.Location = new System.Drawing.Point(16, 112);
            this.LblWeight.Name = "LblWeight";
            this.LblWeight.Size = new System.Drawing.Size(272, 40);
            this.LblWeight.TabIndex = 2;
            this.LblWeight.Text = "Вес (кг)";
            this.LblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblName
            // 
            this.LblName.BackColor = System.Drawing.Color.DarkGray;
            this.LblName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblName.ForeColor = System.Drawing.Color.White;
            this.LblName.Location = new System.Drawing.Point(312, 24);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(272, 40);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Кличка";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSpecials
            // 
            this.LblSpecials.BackColor = System.Drawing.Color.DarkGray;
            this.LblSpecials.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSpecials.ForeColor = System.Drawing.Color.White;
            this.LblSpecials.Location = new System.Drawing.Point(16, 24);
            this.LblSpecials.Name = "LblSpecials";
            this.LblSpecials.Size = new System.Drawing.Size(272, 40);
            this.LblSpecials.TabIndex = 0;
            this.LblSpecials.Text = "Вид животного";
            this.LblSpecials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnOK
            // 
            this.BtnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnOK.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOK.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnOK.ForeColor = System.Drawing.Color.Black;
            this.BtnOK.Location = new System.Drawing.Point(464, 424);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(200, 48);
            this.BtnOK.TabIndex = 6;
            this.BtnOK.Text = "Сохранить";
            this.BtnOK.UseVisualStyleBackColor = false;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCancel.ForeColor = System.Drawing.Color.Black;
            this.BtnCancel.Location = new System.Drawing.Point(688, 424);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(200, 48);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // ErpOwner
            // 
            this.ErpOwner.ContainerControl = this;
            // 
            // AnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(912, 497);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.GbxNewData);
            this.Controls.Add(this.GbxCurrentData);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AnimalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование животного";
            this.GbxCurrentData.ResumeLayout(false);
            this.GbxCurrentData.PerformLayout();
            this.GbxNewData.ResumeLayout(false);
            this.GbxNewData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErpOwner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblCurrentSpecials;
        private System.Windows.Forms.GroupBox GbxCurrentData;
        private System.Windows.Forms.Label LblCurrentName;
        private System.Windows.Forms.Label LblCurrentWeight;
        private System.Windows.Forms.Label LblCurrentAge;
        private System.Windows.Forms.Label LblCurrentOwner;
        private System.Windows.Forms.Label LblCurrentColor;
        private System.Windows.Forms.TextBox TbxCurrentName;
        private System.Windows.Forms.TextBox TbxCurrentSpecials;
        private System.Windows.Forms.TextBox TbxCurrentOwner;
        private System.Windows.Forms.TextBox TbxCurrentColor;
        private System.Windows.Forms.TextBox TbxCurrentAge;
        private System.Windows.Forms.TextBox TbxCurrentWeight;
        private System.Windows.Forms.GroupBox GbxNewData;
        private System.Windows.Forms.TextBox TbxOwner;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.Label LblOwner;
        private System.Windows.Forms.Label LblColor;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.Label LblWeight;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblSpecials;
        private System.Windows.Forms.ComboBox CbxSpecials;
        private System.Windows.Forms.ComboBox CbxColors;
        private System.Windows.Forms.NumericUpDown NudWeight;
        private System.Windows.Forms.NumericUpDown NudAge;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ErrorProvider ErpOwner;
    }
}