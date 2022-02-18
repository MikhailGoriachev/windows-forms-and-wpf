namespace HomeWork
{
    partial class MainForm
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
            this.LilSum = new System.Windows.Forms.LinkLabel();
            this.LilSubstract = new System.Windows.Forms.LinkLabel();
            this.LilMulti = new System.Windows.Forms.LinkLabel();
            this.LilSinus = new System.Windows.Forms.LinkLabel();
            this.LilDivision = new System.Windows.Forms.LinkLabel();
            this.LilLog = new System.Windows.Forms.LinkLabel();
            this.LilDigree = new System.Windows.Forms.LinkLabel();
            this.LilSquareRoot = new System.Windows.Forms.LinkLabel();
            this.LilInfo = new System.Windows.Forms.LinkLabel();
            this.LilExit = new System.Windows.Forms.LinkLabel();
            this.LblType = new System.Windows.Forms.Label();
            this.GbxMode = new System.Windows.Forms.GroupBox();
            this.LblViewType = new System.Windows.Forms.Label();
            this.GbxInput = new System.Windows.Forms.GroupBox();
            this.NudInputB = new System.Windows.Forms.NumericUpDown();
            this.NudInputA = new System.Windows.Forms.NumericUpDown();
            this.LblInputB = new System.Windows.Forms.Label();
            this.LblInputA = new System.Windows.Forms.Label();
            this.GbxSelectType = new System.Windows.Forms.GroupBox();
            this.RbnRadians = new System.Windows.Forms.RadioButton();
            this.RbnDegree = new System.Windows.Forms.RadioButton();
            this.GbxResult = new System.Windows.Forms.GroupBox();
            this.TbxResult = new System.Windows.Forms.TextBox();
            this.LblResultDateTime = new System.Windows.Forms.Label();
            this.BtnResult = new System.Windows.Forms.Button();
            this.GbxHistory = new System.Windows.Forms.GroupBox();
            this.TbxHistory = new System.Windows.Forms.TextBox();
            this.GbxMode.SuspendLayout();
            this.GbxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudInputB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudInputA)).BeginInit();
            this.GbxSelectType.SuspendLayout();
            this.GbxResult.SuspendLayout();
            this.GbxHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // LilSum
            // 
            this.LilSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LilSum.BackColor = System.Drawing.Color.Gray;
            this.LilSum.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LilSum.LinkColor = System.Drawing.Color.White;
            this.LilSum.Location = new System.Drawing.Point(880, 104);
            this.LilSum.Name = "LilSum";
            this.LilSum.Size = new System.Drawing.Size(416, 48);
            this.LilSum.TabIndex = 0;
            this.LilSum.TabStop = true;
            this.LilSum.Text = "Сложение";
            this.LilSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LilSum.VisitedLinkColor = System.Drawing.Color.Gainsboro;
            this.LilSum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LilSum_LinkClicked);
            // 
            // LilSubstract
            // 
            this.LilSubstract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LilSubstract.BackColor = System.Drawing.Color.Gray;
            this.LilSubstract.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LilSubstract.LinkColor = System.Drawing.Color.White;
            this.LilSubstract.Location = new System.Drawing.Point(880, 160);
            this.LilSubstract.Name = "LilSubstract";
            this.LilSubstract.Size = new System.Drawing.Size(416, 48);
            this.LilSubstract.TabIndex = 1;
            this.LilSubstract.TabStop = true;
            this.LilSubstract.Text = "Вычитание";
            this.LilSubstract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LilSubstract.VisitedLinkColor = System.Drawing.Color.Gainsboro;
            this.LilSubstract.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LilSubstract_LinkClicked);
            // 
            // LilMulti
            // 
            this.LilMulti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LilMulti.BackColor = System.Drawing.Color.Gray;
            this.LilMulti.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LilMulti.LinkColor = System.Drawing.Color.White;
            this.LilMulti.Location = new System.Drawing.Point(880, 216);
            this.LilMulti.Name = "LilMulti";
            this.LilMulti.Size = new System.Drawing.Size(416, 48);
            this.LilMulti.TabIndex = 2;
            this.LilMulti.TabStop = true;
            this.LilMulti.Text = "Умножение";
            this.LilMulti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LilMulti.VisitedLinkColor = System.Drawing.Color.Gainsboro;
            this.LilMulti.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LilMulti_LinkClicked);
            // 
            // LilSinus
            // 
            this.LilSinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LilSinus.BackColor = System.Drawing.Color.Gray;
            this.LilSinus.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LilSinus.LinkColor = System.Drawing.Color.White;
            this.LilSinus.Location = new System.Drawing.Point(880, 384);
            this.LilSinus.Name = "LilSinus";
            this.LilSinus.Size = new System.Drawing.Size(416, 48);
            this.LilSinus.TabIndex = 5;
            this.LilSinus.TabStop = true;
            this.LilSinus.Text = "Вычисление синуса";
            this.LilSinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LilSinus.VisitedLinkColor = System.Drawing.Color.Gainsboro;
            this.LilSinus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LilSinus_LinkClicked);
            // 
            // LilDivision
            // 
            this.LilDivision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LilDivision.BackColor = System.Drawing.Color.Gray;
            this.LilDivision.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LilDivision.LinkColor = System.Drawing.Color.White;
            this.LilDivision.Location = new System.Drawing.Point(880, 272);
            this.LilDivision.Name = "LilDivision";
            this.LilDivision.Size = new System.Drawing.Size(416, 48);
            this.LilDivision.TabIndex = 3;
            this.LilDivision.TabStop = true;
            this.LilDivision.Text = "Деление";
            this.LilDivision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LilDivision.VisitedLinkColor = System.Drawing.Color.Gainsboro;
            this.LilDivision.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LilDivision_LinkClicked);
            // 
            // LilLog
            // 
            this.LilLog.BackColor = System.Drawing.Color.DarkGray;
            this.LilLog.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LilLog.LinkColor = System.Drawing.Color.White;
            this.LilLog.Location = new System.Drawing.Point(16, 16);
            this.LilLog.Name = "LilLog";
            this.LilLog.Size = new System.Drawing.Size(416, 48);
            this.LilLog.TabIndex = 10;
            this.LilLog.TabStop = true;
            this.LilLog.Text = "Журнал";
            this.LilLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LilLog.VisitedLinkColor = System.Drawing.Color.Gainsboro;
            this.LilLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LilLog_LinkClicked);
            // 
            // LilDigree
            // 
            this.LilDigree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LilDigree.BackColor = System.Drawing.Color.Gray;
            this.LilDigree.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LilDigree.LinkColor = System.Drawing.Color.White;
            this.LilDigree.Location = new System.Drawing.Point(880, 328);
            this.LilDigree.Name = "LilDigree";
            this.LilDigree.Size = new System.Drawing.Size(416, 48);
            this.LilDigree.TabIndex = 4;
            this.LilDigree.TabStop = true;
            this.LilDigree.Text = "Вычисление степени";
            this.LilDigree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LilDigree.VisitedLinkColor = System.Drawing.Color.Gainsboro;
            this.LilDigree.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LilDigree_LinkClicked);
            // 
            // LilSquareRoot
            // 
            this.LilSquareRoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LilSquareRoot.BackColor = System.Drawing.Color.Gray;
            this.LilSquareRoot.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LilSquareRoot.LinkColor = System.Drawing.Color.White;
            this.LilSquareRoot.Location = new System.Drawing.Point(880, 440);
            this.LilSquareRoot.Name = "LilSquareRoot";
            this.LilSquareRoot.Size = new System.Drawing.Size(416, 48);
            this.LilSquareRoot.TabIndex = 6;
            this.LilSquareRoot.TabStop = true;
            this.LilSquareRoot.Text = "Вычисление квадратного корня";
            this.LilSquareRoot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LilSquareRoot.VisitedLinkColor = System.Drawing.Color.Gainsboro;
            this.LilSquareRoot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LilSquareRoot_LinkClicked);
            // 
            // LilInfo
            // 
            this.LilInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LilInfo.BackColor = System.Drawing.Color.DarkGray;
            this.LilInfo.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LilInfo.LinkColor = System.Drawing.Color.White;
            this.LilInfo.Location = new System.Drawing.Point(448, 16);
            this.LilInfo.Name = "LilInfo";
            this.LilInfo.Size = new System.Drawing.Size(416, 48);
            this.LilInfo.TabIndex = 11;
            this.LilInfo.TabStop = true;
            this.LilInfo.Text = "О программе";
            this.LilInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LilInfo.VisitedLinkColor = System.Drawing.Color.Gainsboro;
            this.LilInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LilInfo_LinkClicked);
            // 
            // LilExit
            // 
            this.LilExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LilExit.BackColor = System.Drawing.Color.IndianRed;
            this.LilExit.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LilExit.LinkColor = System.Drawing.Color.White;
            this.LilExit.Location = new System.Drawing.Point(880, 16);
            this.LilExit.Name = "LilExit";
            this.LilExit.Size = new System.Drawing.Size(416, 48);
            this.LilExit.TabIndex = 12;
            this.LilExit.TabStop = true;
            this.LilExit.Text = "Выход";
            this.LilExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LilExit.VisitedLinkColor = System.Drawing.Color.Gainsboro;
            this.LilExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LilExit_LinkClicked);
            // 
            // LblType
            // 
            this.LblType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblType.BackColor = System.Drawing.Color.Gray;
            this.LblType.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblType.Location = new System.Drawing.Point(8, 32);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(400, 64);
            this.LblType.TabIndex = 15;
            this.LblType.Text = "Выберите тип вычисления";
            this.LblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GbxMode
            // 
            this.GbxMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxMode.Controls.Add(this.LblViewType);
            this.GbxMode.Controls.Add(this.LblType);
            this.GbxMode.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxMode.ForeColor = System.Drawing.Color.White;
            this.GbxMode.Location = new System.Drawing.Point(448, 96);
            this.GbxMode.Name = "GbxMode";
            this.GbxMode.Size = new System.Drawing.Size(416, 192);
            this.GbxMode.TabIndex = 16;
            this.GbxMode.TabStop = false;
            this.GbxMode.Text = " Выбранный тип вычисления ";
            // 
            // LblViewType
            // 
            this.LblViewType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblViewType.BackColor = System.Drawing.Color.Gray;
            this.LblViewType.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblViewType.Location = new System.Drawing.Point(8, 112);
            this.LblViewType.Name = "LblViewType";
            this.LblViewType.Size = new System.Drawing.Size(400, 64);
            this.LblViewType.TabIndex = 16;
            this.LblViewType.Text = " Вид вычисления ";
            this.LblViewType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GbxInput
            // 
            this.GbxInput.Controls.Add(this.NudInputB);
            this.GbxInput.Controls.Add(this.NudInputA);
            this.GbxInput.Controls.Add(this.LblInputB);
            this.GbxInput.Controls.Add(this.LblInputA);
            this.GbxInput.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxInput.ForeColor = System.Drawing.Color.White;
            this.GbxInput.Location = new System.Drawing.Point(16, 96);
            this.GbxInput.Name = "GbxInput";
            this.GbxInput.Size = new System.Drawing.Size(416, 232);
            this.GbxInput.TabIndex = 7;
            this.GbxInput.TabStop = false;
            this.GbxInput.Text = " Ввод данных ";
            // 
            // NudInputB
            // 
            this.NudInputB.DecimalPlaces = 3;
            this.NudInputB.Enabled = false;
            this.NudInputB.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NudInputB.Location = new System.Drawing.Point(8, 184);
            this.NudInputB.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NudInputB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.NudInputB.Name = "NudInputB";
            this.NudInputB.Size = new System.Drawing.Size(400, 33);
            this.NudInputB.TabIndex = 18;
            this.NudInputB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudInputB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudInputB.ValueChanged += new System.EventHandler(this.NudInput_ValueChanged);
            // 
            // NudInputA
            // 
            this.NudInputA.DecimalPlaces = 3;
            this.NudInputA.Enabled = false;
            this.NudInputA.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NudInputA.Location = new System.Drawing.Point(8, 80);
            this.NudInputA.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NudInputA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.NudInputA.Name = "NudInputA";
            this.NudInputA.Size = new System.Drawing.Size(400, 33);
            this.NudInputA.TabIndex = 0;
            this.NudInputA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudInputA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudInputA.ValueChanged += new System.EventHandler(this.NudInput_ValueChanged);
            // 
            // LblInputB
            // 
            this.LblInputB.BackColor = System.Drawing.Color.Gray;
            this.LblInputB.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblInputB.Location = new System.Drawing.Point(8, 128);
            this.LblInputB.Name = "LblInputB";
            this.LblInputB.Size = new System.Drawing.Size(400, 56);
            this.LblInputB.TabIndex = 16;
            this.LblInputB.Text = "Число B";
            this.LblInputB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblInputA
            // 
            this.LblInputA.BackColor = System.Drawing.Color.Gray;
            this.LblInputA.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblInputA.Location = new System.Drawing.Point(8, 24);
            this.LblInputA.Name = "LblInputA";
            this.LblInputA.Size = new System.Drawing.Size(400, 56);
            this.LblInputA.TabIndex = 15;
            this.LblInputA.Text = "Число A";
            this.LblInputA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GbxSelectType
            // 
            this.GbxSelectType.Controls.Add(this.RbnRadians);
            this.GbxSelectType.Controls.Add(this.RbnDegree);
            this.GbxSelectType.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxSelectType.ForeColor = System.Drawing.Color.White;
            this.GbxSelectType.Location = new System.Drawing.Point(16, 344);
            this.GbxSelectType.Name = "GbxSelectType";
            this.GbxSelectType.Size = new System.Drawing.Size(416, 144);
            this.GbxSelectType.TabIndex = 8;
            this.GbxSelectType.TabStop = false;
            this.GbxSelectType.Text = " Единица измерения ";
            // 
            // RbnRadians
            // 
            this.RbnRadians.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RbnRadians.Enabled = false;
            this.RbnRadians.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RbnRadians.Location = new System.Drawing.Point(24, 80);
            this.RbnRadians.Name = "RbnRadians";
            this.RbnRadians.Size = new System.Drawing.Size(152, 48);
            this.RbnRadians.TabIndex = 1;
            this.RbnRadians.TabStop = true;
            this.RbnRadians.Text = "Радианы";
            this.RbnRadians.UseVisualStyleBackColor = true;
            this.RbnRadians.CheckedChanged += new System.EventHandler(this.RbnDegree_CheckedChanged);
            // 
            // RbnDegree
            // 
            this.RbnDegree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RbnDegree.Enabled = false;
            this.RbnDegree.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RbnDegree.Location = new System.Drawing.Point(24, 32);
            this.RbnDegree.Name = "RbnDegree";
            this.RbnDegree.Size = new System.Drawing.Size(152, 40);
            this.RbnDegree.TabIndex = 0;
            this.RbnDegree.TabStop = true;
            this.RbnDegree.Text = "Градусы";
            this.RbnDegree.UseVisualStyleBackColor = true;
            this.RbnDegree.CheckedChanged += new System.EventHandler(this.RbnDegree_CheckedChanged);
            // 
            // GbxResult
            // 
            this.GbxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxResult.Controls.Add(this.TbxResult);
            this.GbxResult.Controls.Add(this.LblResultDateTime);
            this.GbxResult.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxResult.ForeColor = System.Drawing.Color.White;
            this.GbxResult.Location = new System.Drawing.Point(448, 296);
            this.GbxResult.Name = "GbxResult";
            this.GbxResult.Size = new System.Drawing.Size(416, 192);
            this.GbxResult.TabIndex = 17;
            this.GbxResult.TabStop = false;
            this.GbxResult.Text = " Результат ";
            // 
            // TbxResult
            // 
            this.TbxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxResult.BackColor = System.Drawing.Color.DarkGray;
            this.TbxResult.ForeColor = System.Drawing.Color.Black;
            this.TbxResult.Location = new System.Drawing.Point(8, 32);
            this.TbxResult.Multiline = true;
            this.TbxResult.Name = "TbxResult";
            this.TbxResult.ReadOnly = true;
            this.TbxResult.Size = new System.Drawing.Size(400, 72);
            this.TbxResult.TabIndex = 1;
            this.TbxResult.TabStop = false;
            this.TbxResult.Text = "\r\nРезультат";
            this.TbxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblResultDateTime
            // 
            this.LblResultDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblResultDateTime.BackColor = System.Drawing.Color.Gray;
            this.LblResultDateTime.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblResultDateTime.Location = new System.Drawing.Point(8, 112);
            this.LblResultDateTime.Name = "LblResultDateTime";
            this.LblResultDateTime.Size = new System.Drawing.Size(400, 64);
            this.LblResultDateTime.TabIndex = 16;
            this.LblResultDateTime.Text = "Дата и время";
            this.LblResultDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnResult
            // 
            this.BtnResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnResult.BackColor = System.Drawing.Color.Green;
            this.BtnResult.Enabled = false;
            this.BtnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResult.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnResult.ForeColor = System.Drawing.Color.White;
            this.BtnResult.Location = new System.Drawing.Point(880, 552);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Size = new System.Drawing.Size(416, 80);
            this.BtnResult.TabIndex = 9;
            this.BtnResult.Text = "Получить результат";
            this.BtnResult.UseVisualStyleBackColor = false;
            this.BtnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // GbxHistory
            // 
            this.GbxHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxHistory.Controls.Add(this.TbxHistory);
            this.GbxHistory.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxHistory.ForeColor = System.Drawing.Color.White;
            this.GbxHistory.Location = new System.Drawing.Point(16, 496);
            this.GbxHistory.Name = "GbxHistory";
            this.GbxHistory.Size = new System.Drawing.Size(848, 176);
            this.GbxHistory.TabIndex = 22;
            this.GbxHistory.TabStop = false;
            this.GbxHistory.Text = " История вычислений ";
            // 
            // TbxHistory
            // 
            this.TbxHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxHistory.BackColor = System.Drawing.Color.DarkGray;
            this.TbxHistory.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxHistory.Location = new System.Drawing.Point(8, 32);
            this.TbxHistory.Multiline = true;
            this.TbxHistory.Name = "TbxHistory";
            this.TbxHistory.ReadOnly = true;
            this.TbxHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbxHistory.Size = new System.Drawing.Size(832, 136);
            this.TbxHistory.TabIndex = 0;
            this.TbxHistory.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1313, 674);
            this.Controls.Add(this.GbxHistory);
            this.Controls.Add(this.BtnResult);
            this.Controls.Add(this.GbxResult);
            this.Controls.Add(this.GbxSelectType);
            this.Controls.Add(this.GbxInput);
            this.Controls.Add(this.GbxMode);
            this.Controls.Add(this.LilExit);
            this.Controls.Add(this.LilInfo);
            this.Controls.Add(this.LilLog);
            this.Controls.Add(this.LilDigree);
            this.Controls.Add(this.LilSquareRoot);
            this.Controls.Add(this.LilSinus);
            this.Controls.Add(this.LilDivision);
            this.Controls.Add(this.LilMulti);
            this.Controls.Add(this.LilSubstract);
            this.Controls.Add(this.LilSum);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(1329, 713);
            this.Name = "MainForm";
            this.Text = "Домашнее задание на 03.11.2021";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GbxMode.ResumeLayout(false);
            this.GbxInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NudInputB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudInputA)).EndInit();
            this.GbxSelectType.ResumeLayout(false);
            this.GbxResult.ResumeLayout(false);
            this.GbxResult.PerformLayout();
            this.GbxHistory.ResumeLayout(false);
            this.GbxHistory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel LilSum;
        private System.Windows.Forms.LinkLabel LilSubstract;
        private System.Windows.Forms.LinkLabel LilMulti;
        private System.Windows.Forms.LinkLabel LilSinus;
        private System.Windows.Forms.LinkLabel LilDivision;
        private System.Windows.Forms.LinkLabel LilLog;
        private System.Windows.Forms.LinkLabel LilDigree;
        private System.Windows.Forms.LinkLabel LilSquareRoot;
        private System.Windows.Forms.LinkLabel LilInfo;
        private System.Windows.Forms.LinkLabel LilExit;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.GroupBox GbxMode;
        private System.Windows.Forms.GroupBox GbxInput;
        private System.Windows.Forms.NumericUpDown NudInputA;
        private System.Windows.Forms.Label LblInputB;
        private System.Windows.Forms.Label LblInputA;
        private System.Windows.Forms.NumericUpDown NudInputB;
        private System.Windows.Forms.GroupBox GbxSelectType;
        private System.Windows.Forms.RadioButton RbnRadians;
        private System.Windows.Forms.RadioButton RbnDegree;
        private System.Windows.Forms.GroupBox GbxResult;
        private System.Windows.Forms.Label LblViewType;
        private System.Windows.Forms.Label LblResultDateTime;
        private System.Windows.Forms.Button BtnResult;
        private System.Windows.Forms.GroupBox GbxHistory;
        private System.Windows.Forms.TextBox TbxHistory;
        private System.Windows.Forms.TextBox TbxResult;
    }
}

