namespace HomeWork.Views
{
    partial class FormParallelepiped
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnResult = new System.Windows.Forms.Button();
            this.CbxWeight = new System.Windows.Forms.CheckBox();
            this.CbxVolume = new System.Windows.Forms.CheckBox();
            this.CbxArea = new System.Windows.Forms.CheckBox();
            this.GbxParams = new System.Windows.Forms.GroupBox();
            this.GbxImage = new System.Windows.Forms.GroupBox();
            this.IbxFigure = new System.Windows.Forms.PictureBox();
            this.IbxMaterialView = new System.Windows.Forms.PictureBox();
            this.GbxResult = new System.Windows.Forms.GroupBox();
            this.LblValueDensity = new System.Windows.Forms.Label();
            this.LblValueWeight = new System.Windows.Forms.Label();
            this.LblWeight = new System.Windows.Forms.Label();
            this.LblDensity = new System.Windows.Forms.Label();
            this.LblValueVolume = new System.Windows.Forms.Label();
            this.LblVolume = new System.Windows.Forms.Label();
            this.LblValueArea = new System.Windows.Forms.Label();
            this.LblArea = new System.Windows.Forms.Label();
            this.LblSideC = new System.Windows.Forms.Label();
            this.LblSideB = new System.Windows.Forms.Label();
            this.LblSideA = new System.Windows.Forms.Label();
            this.GbxInputData = new System.Windows.Forms.GroupBox();
            this.NudSideC = new System.Windows.Forms.NumericUpDown();
            this.NudSideB = new System.Windows.Forms.NumericUpDown();
            this.NudSideA = new System.Windows.Forms.NumericUpDown();
            this.GbxMaterialSelect = new System.Windows.Forms.GroupBox();
            this.CbxMaterial = new System.Windows.Forms.ComboBox();
            this.GbxMaterialView = new System.Windows.Forms.GroupBox();
            this.GbxParams.SuspendLayout();
            this.GbxImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IbxFigure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IbxMaterialView)).BeginInit();
            this.GbxResult.SuspendLayout();
            this.GbxInputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudSideC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSideB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSideA)).BeginInit();
            this.GbxMaterialSelect.SuspendLayout();
            this.GbxMaterialView.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.IndianRed;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClose.Location = new System.Drawing.Point(800, 352);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(240, 48);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Выход";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnResult
            // 
            this.BtnResult.BackColor = System.Drawing.Color.Silver;
            this.BtnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResult.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnResult.Location = new System.Drawing.Point(800, 280);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Size = new System.Drawing.Size(240, 48);
            this.BtnResult.TabIndex = 2;
            this.BtnResult.Text = "Вычисление результата";
            this.BtnResult.UseVisualStyleBackColor = false;
            this.BtnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // CbxWeight
            // 
            this.CbxWeight.AutoSize = true;
            this.CbxWeight.Checked = true;
            this.CbxWeight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbxWeight.Location = new System.Drawing.Point(8, 72);
            this.CbxWeight.Name = "CbxWeight";
            this.CbxWeight.Size = new System.Drawing.Size(70, 23);
            this.CbxWeight.TabIndex = 2;
            this.CbxWeight.Text = "Масса";
            this.CbxWeight.UseVisualStyleBackColor = true;
            this.CbxWeight.CheckStateChanged += new System.EventHandler(this.CbxParams_CheckStateChanged);
            // 
            // CbxVolume
            // 
            this.CbxVolume.AutoSize = true;
            this.CbxVolume.Checked = true;
            this.CbxVolume.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbxVolume.Location = new System.Drawing.Point(8, 48);
            this.CbxVolume.Name = "CbxVolume";
            this.CbxVolume.Size = new System.Drawing.Size(76, 23);
            this.CbxVolume.TabIndex = 1;
            this.CbxVolume.Text = "Объём";
            this.CbxVolume.UseVisualStyleBackColor = true;
            this.CbxVolume.CheckStateChanged += new System.EventHandler(this.CbxParams_CheckStateChanged);
            // 
            // CbxArea
            // 
            this.CbxArea.AutoSize = true;
            this.CbxArea.Checked = true;
            this.CbxArea.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbxArea.Location = new System.Drawing.Point(8, 24);
            this.CbxArea.Name = "CbxArea";
            this.CbxArea.Size = new System.Drawing.Size(193, 23);
            this.CbxArea.TabIndex = 0;
            this.CbxArea.Text = "Площадь поверхности";
            this.CbxArea.UseVisualStyleBackColor = true;
            this.CbxArea.CheckStateChanged += new System.EventHandler(this.CbxParams_CheckStateChanged);
            // 
            // GbxParams
            // 
            this.GbxParams.Controls.Add(this.CbxWeight);
            this.GbxParams.Controls.Add(this.CbxVolume);
            this.GbxParams.Controls.Add(this.CbxArea);
            this.GbxParams.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxParams.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GbxParams.Location = new System.Drawing.Point(24, 256);
            this.GbxParams.Name = "GbxParams";
            this.GbxParams.Size = new System.Drawing.Size(224, 104);
            this.GbxParams.TabIndex = 3;
            this.GbxParams.TabStop = false;
            this.GbxParams.Text = " Параметры вычисления";
            // 
            // GbxImage
            // 
            this.GbxImage.Controls.Add(this.IbxFigure);
            this.GbxImage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxImage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GbxImage.Location = new System.Drawing.Point(791, 23);
            this.GbxImage.Name = "GbxImage";
            this.GbxImage.Size = new System.Drawing.Size(256, 240);
            this.GbxImage.TabIndex = 21;
            this.GbxImage.TabStop = false;
            this.GbxImage.Text = " Фигура ";
            // 
            // IbxFigure
            // 
            this.IbxFigure.BackColor = System.Drawing.Color.Gray;
            this.IbxFigure.Image = global::HomeWork.Properties.Resources.v_parallelepipeda;
            this.IbxFigure.InitialImage = null;
            this.IbxFigure.Location = new System.Drawing.Point(8, 24);
            this.IbxFigure.Name = "IbxFigure";
            this.IbxFigure.Size = new System.Drawing.Size(240, 208);
            this.IbxFigure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IbxFigure.TabIndex = 0;
            this.IbxFigure.TabStop = false;
            // 
            // IbxMaterialView
            // 
            this.IbxMaterialView.BackColor = System.Drawing.Color.Gray;
            this.IbxMaterialView.InitialImage = null;
            this.IbxMaterialView.Location = new System.Drawing.Point(8, 24);
            this.IbxMaterialView.Name = "IbxMaterialView";
            this.IbxMaterialView.Size = new System.Drawing.Size(240, 208);
            this.IbxMaterialView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IbxMaterialView.TabIndex = 0;
            this.IbxMaterialView.TabStop = false;
            // 
            // GbxResult
            // 
            this.GbxResult.Controls.Add(this.LblValueDensity);
            this.GbxResult.Controls.Add(this.LblValueWeight);
            this.GbxResult.Controls.Add(this.LblWeight);
            this.GbxResult.Controls.Add(this.LblDensity);
            this.GbxResult.Controls.Add(this.LblValueVolume);
            this.GbxResult.Controls.Add(this.LblVolume);
            this.GbxResult.Controls.Add(this.LblValueArea);
            this.GbxResult.Controls.Add(this.LblArea);
            this.GbxResult.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxResult.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GbxResult.Location = new System.Drawing.Point(297, 25);
            this.GbxResult.Name = "GbxResult";
            this.GbxResult.Size = new System.Drawing.Size(224, 375);
            this.GbxResult.TabIndex = 20;
            this.GbxResult.TabStop = false;
            this.GbxResult.Text = " Результат ";
            // 
            // LblValueDensity
            // 
            this.LblValueDensity.BackColor = System.Drawing.Color.Gainsboro;
            this.LblValueDensity.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblValueDensity.ForeColor = System.Drawing.Color.Black;
            this.LblValueDensity.Location = new System.Drawing.Point(8, 319);
            this.LblValueDensity.Name = "LblValueDensity";
            this.LblValueDensity.Size = new System.Drawing.Size(208, 32);
            this.LblValueDensity.TabIndex = 32;
            this.LblValueDensity.Text = "————";
            this.LblValueDensity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblValueWeight
            // 
            this.LblValueWeight.BackColor = System.Drawing.Color.Gainsboro;
            this.LblValueWeight.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblValueWeight.ForeColor = System.Drawing.Color.Black;
            this.LblValueWeight.Location = new System.Drawing.Point(8, 231);
            this.LblValueWeight.Name = "LblValueWeight";
            this.LblValueWeight.Size = new System.Drawing.Size(208, 32);
            this.LblValueWeight.TabIndex = 31;
            this.LblValueWeight.Text = "————";
            this.LblValueWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblWeight
            // 
            this.LblWeight.BackColor = System.Drawing.Color.Gray;
            this.LblWeight.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblWeight.ForeColor = System.Drawing.Color.Transparent;
            this.LblWeight.Location = new System.Drawing.Point(8, 199);
            this.LblWeight.Name = "LblWeight";
            this.LblWeight.Size = new System.Drawing.Size(208, 32);
            this.LblWeight.TabIndex = 30;
            this.LblWeight.Text = "Масса";
            this.LblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblDensity
            // 
            this.LblDensity.BackColor = System.Drawing.Color.Gray;
            this.LblDensity.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblDensity.ForeColor = System.Drawing.Color.Transparent;
            this.LblDensity.Location = new System.Drawing.Point(8, 287);
            this.LblDensity.Name = "LblDensity";
            this.LblDensity.Size = new System.Drawing.Size(208, 32);
            this.LblDensity.TabIndex = 25;
            this.LblDensity.Text = "Плотность";
            this.LblDensity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblValueVolume
            // 
            this.LblValueVolume.BackColor = System.Drawing.Color.Gainsboro;
            this.LblValueVolume.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblValueVolume.ForeColor = System.Drawing.Color.Black;
            this.LblValueVolume.Location = new System.Drawing.Point(8, 143);
            this.LblValueVolume.Name = "LblValueVolume";
            this.LblValueVolume.Size = new System.Drawing.Size(208, 32);
            this.LblValueVolume.TabIndex = 29;
            this.LblValueVolume.Text = "————";
            this.LblValueVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblVolume
            // 
            this.LblVolume.BackColor = System.Drawing.Color.Gray;
            this.LblVolume.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblVolume.ForeColor = System.Drawing.Color.Transparent;
            this.LblVolume.Location = new System.Drawing.Point(8, 111);
            this.LblVolume.Name = "LblVolume";
            this.LblVolume.Size = new System.Drawing.Size(208, 32);
            this.LblVolume.TabIndex = 28;
            this.LblVolume.Text = "Объём";
            this.LblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblValueArea
            // 
            this.LblValueArea.BackColor = System.Drawing.Color.Gainsboro;
            this.LblValueArea.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblValueArea.ForeColor = System.Drawing.Color.Black;
            this.LblValueArea.Location = new System.Drawing.Point(8, 55);
            this.LblValueArea.Name = "LblValueArea";
            this.LblValueArea.Size = new System.Drawing.Size(208, 32);
            this.LblValueArea.TabIndex = 27;
            this.LblValueArea.Text = "————";
            this.LblValueArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblArea
            // 
            this.LblArea.BackColor = System.Drawing.Color.Gray;
            this.LblArea.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblArea.ForeColor = System.Drawing.Color.Transparent;
            this.LblArea.Location = new System.Drawing.Point(8, 23);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(208, 32);
            this.LblArea.TabIndex = 26;
            this.LblArea.Text = "Площадь поверхности";
            this.LblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSideC
            // 
            this.LblSideC.BackColor = System.Drawing.Color.Gray;
            this.LblSideC.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSideC.ForeColor = System.Drawing.Color.Transparent;
            this.LblSideC.Location = new System.Drawing.Point(16, 184);
            this.LblSideC.Name = "LblSideC";
            this.LblSideC.Size = new System.Drawing.Size(240, 32);
            this.LblSideC.TabIndex = 8;
            this.LblSideC.Text = "Сторона C";
            this.LblSideC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSideB
            // 
            this.LblSideB.BackColor = System.Drawing.Color.Gray;
            this.LblSideB.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSideB.ForeColor = System.Drawing.Color.Transparent;
            this.LblSideB.Location = new System.Drawing.Point(16, 104);
            this.LblSideB.Name = "LblSideB";
            this.LblSideB.Size = new System.Drawing.Size(240, 32);
            this.LblSideB.TabIndex = 6;
            this.LblSideB.Text = "Сторона B";
            this.LblSideB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSideA
            // 
            this.LblSideA.BackColor = System.Drawing.Color.Gray;
            this.LblSideA.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSideA.ForeColor = System.Drawing.Color.Transparent;
            this.LblSideA.Location = new System.Drawing.Point(16, 24);
            this.LblSideA.Name = "LblSideA";
            this.LblSideA.Size = new System.Drawing.Size(240, 32);
            this.LblSideA.TabIndex = 4;
            this.LblSideA.Text = "Сторона A";
            this.LblSideA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GbxInputData
            // 
            this.GbxInputData.Controls.Add(this.NudSideC);
            this.GbxInputData.Controls.Add(this.NudSideB);
            this.GbxInputData.Controls.Add(this.NudSideA);
            this.GbxInputData.Controls.Add(this.LblSideC);
            this.GbxInputData.Controls.Add(this.LblSideB);
            this.GbxInputData.Controls.Add(this.GbxParams);
            this.GbxInputData.Controls.Add(this.LblSideA);
            this.GbxInputData.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxInputData.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GbxInputData.Location = new System.Drawing.Point(17, 25);
            this.GbxInputData.Name = "GbxInputData";
            this.GbxInputData.Size = new System.Drawing.Size(272, 375);
            this.GbxInputData.TabIndex = 0;
            this.GbxInputData.TabStop = false;
            this.GbxInputData.Text = "Ввод данных";
            // 
            // NudSideC
            // 
            this.NudSideC.DecimalPlaces = 3;
            this.NudSideC.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NudSideC.Location = new System.Drawing.Point(16, 216);
            this.NudSideC.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            65536});
            this.NudSideC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            983040});
            this.NudSideC.Name = "NudSideC";
            this.NudSideC.Size = new System.Drawing.Size(240, 33);
            this.NudSideC.TabIndex = 2;
            this.NudSideC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudSideC.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NudSideC.ValueChanged += new System.EventHandler(this.NudSide_ValueChanged);
            this.NudSideC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NudSide_KeyDown);
            // 
            // NudSideB
            // 
            this.NudSideB.DecimalPlaces = 3;
            this.NudSideB.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NudSideB.Location = new System.Drawing.Point(16, 136);
            this.NudSideB.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            65536});
            this.NudSideB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            983040});
            this.NudSideB.Name = "NudSideB";
            this.NudSideB.Size = new System.Drawing.Size(240, 33);
            this.NudSideB.TabIndex = 1;
            this.NudSideB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudSideB.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NudSideB.ValueChanged += new System.EventHandler(this.NudSide_ValueChanged);
            this.NudSideB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NudSide_KeyDown);
            // 
            // NudSideA
            // 
            this.NudSideA.DecimalPlaces = 3;
            this.NudSideA.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NudSideA.Location = new System.Drawing.Point(16, 56);
            this.NudSideA.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            65536});
            this.NudSideA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            983040});
            this.NudSideA.Name = "NudSideA";
            this.NudSideA.Size = new System.Drawing.Size(240, 33);
            this.NudSideA.TabIndex = 0;
            this.NudSideA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudSideA.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NudSideA.ValueChanged += new System.EventHandler(this.NudSide_ValueChanged);
            this.NudSideA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NudSide_KeyDown);
            // 
            // GbxMaterialSelect
            // 
            this.GbxMaterialSelect.Controls.Add(this.CbxMaterial);
            this.GbxMaterialSelect.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxMaterialSelect.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GbxMaterialSelect.Location = new System.Drawing.Point(528, 272);
            this.GbxMaterialSelect.Name = "GbxMaterialSelect";
            this.GbxMaterialSelect.Size = new System.Drawing.Size(256, 128);
            this.GbxMaterialSelect.TabIndex = 1;
            this.GbxMaterialSelect.TabStop = false;
            this.GbxMaterialSelect.Text = " Вид материала ";
            // 
            // CbxMaterial
            // 
            this.CbxMaterial.BackColor = System.Drawing.Color.DarkGray;
            this.CbxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxMaterial.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbxMaterial.FormattingEnabled = true;
            this.CbxMaterial.Items.AddRange(new object[] {
            "Сталь",
            "Медь",
            "Водяной лед",
            "Гранит"});
            this.CbxMaterial.Location = new System.Drawing.Point(8, 24);
            this.CbxMaterial.Name = "CbxMaterial";
            this.CbxMaterial.Size = new System.Drawing.Size(240, 31);
            this.CbxMaterial.TabIndex = 0;
            this.CbxMaterial.SelectedIndexChanged += new System.EventHandler(this.CbxMaterial_SelectedIndexChanged);
            // 
            // GbxMaterialView
            // 
            this.GbxMaterialView.Controls.Add(this.IbxMaterialView);
            this.GbxMaterialView.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxMaterialView.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GbxMaterialView.Location = new System.Drawing.Point(528, 24);
            this.GbxMaterialView.Name = "GbxMaterialView";
            this.GbxMaterialView.Size = new System.Drawing.Size(256, 240);
            this.GbxMaterialView.TabIndex = 25;
            this.GbxMaterialView.TabStop = false;
            this.GbxMaterialView.Text = " Материал ";
            // 
            // FormParallelepiped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1067, 430);
            this.Controls.Add(this.GbxMaterialSelect);
            this.Controls.Add(this.GbxMaterialView);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnResult);
            this.Controls.Add(this.GbxImage);
            this.Controls.Add(this.GbxResult);
            this.Controls.Add(this.GbxInputData);
            this.MaximizeBox = false;
            this.Name = "FormParallelepiped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вычисление прямоугольного параллелепипеда";
            this.GbxParams.ResumeLayout(false);
            this.GbxParams.PerformLayout();
            this.GbxImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IbxFigure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IbxMaterialView)).EndInit();
            this.GbxResult.ResumeLayout(false);
            this.GbxInputData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NudSideC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSideB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSideA)).EndInit();
            this.GbxMaterialSelect.ResumeLayout(false);
            this.GbxMaterialView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox IbxFigure;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnResult;
        private System.Windows.Forms.GroupBox GbxParams;
        private System.Windows.Forms.CheckBox CbxWeight;
        private System.Windows.Forms.CheckBox CbxVolume;
        private System.Windows.Forms.CheckBox CbxArea;
        private System.Windows.Forms.GroupBox GbxImage;
        private System.Windows.Forms.GroupBox GbxResult;
        private System.Windows.Forms.GroupBox GbxInputData;
        private System.Windows.Forms.Label LblSideC;
        private System.Windows.Forms.Label LblSideB;
        private System.Windows.Forms.Label LblSideA;
        private System.Windows.Forms.GroupBox GbxMaterialSelect;
        private System.Windows.Forms.GroupBox GbxMaterialView;
        private System.Windows.Forms.PictureBox IbxMaterialView;
        private System.Windows.Forms.Label LblValueDensity;
        private System.Windows.Forms.Label LblValueWeight;
        private System.Windows.Forms.Label LblWeight;
        private System.Windows.Forms.Label LblDensity;
        private System.Windows.Forms.Label LblValueVolume;
        private System.Windows.Forms.Label LblVolume;
        private System.Windows.Forms.Label LblValueArea;
        private System.Windows.Forms.Label LblArea;
        private System.Windows.Forms.NumericUpDown NudSideB;
        private System.Windows.Forms.NumericUpDown NudSideA;
        private System.Windows.Forms.NumericUpDown NudSideC;
        private System.Windows.Forms.ComboBox CbxMaterial;
    }
}