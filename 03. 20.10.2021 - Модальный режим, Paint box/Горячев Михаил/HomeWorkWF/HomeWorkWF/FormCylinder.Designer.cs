namespace HomeWorkWF
{
    partial class FormCylinder
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
            this.ErrDensity = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrRadius = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrHeight = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnResult = new System.Windows.Forms.Button();
            this.CbxWeight = new System.Windows.Forms.CheckBox();
            this.CbxVolume = new System.Windows.Forms.CheckBox();
            this.CbxArea = new System.Windows.Forms.CheckBox();
            this.GbxParams = new System.Windows.Forms.GroupBox();
            this.LblValueWeight = new System.Windows.Forms.Label();
            this.LblWeight = new System.Windows.Forms.Label();
            this.LblValueVolume = new System.Windows.Forms.Label();
            this.GbxImage = new System.Windows.Forms.GroupBox();
            this.LblVolume = new System.Windows.Forms.Label();
            this.LblArea = new System.Windows.Forms.Label();
            this.GbxResult = new System.Windows.Forms.GroupBox();
            this.LblValueArea = new System.Windows.Forms.Label();
            this.TxbInputDensity = new System.Windows.Forms.TextBox();
            this.LblDensity = new System.Windows.Forms.Label();
            this.TxbInputRadius = new System.Windows.Forms.TextBox();
            this.LblRadius = new System.Windows.Forms.Label();
            this.TxbInputHeight = new System.Windows.Forms.TextBox();
            this.LblHeight = new System.Windows.Forms.Label();
            this.GbxInputData = new System.Windows.Forms.GroupBox();
            this.IbxFigure = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrHeight)).BeginInit();
            this.GbxParams.SuspendLayout();
            this.GbxImage.SuspendLayout();
            this.GbxResult.SuspendLayout();
            this.GbxInputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IbxFigure)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrDensity
            // 
            this.ErrDensity.ContainerControl = this;
            // 
            // ErrRadius
            // 
            this.ErrRadius.ContainerControl = this;
            // 
            // ErrHeight
            // 
            this.ErrHeight.ContainerControl = this;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.IndianRed;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClose.Location = new System.Drawing.Point(537, 329);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(240, 48);
            this.BtnClose.TabIndex = 24;
            this.BtnClose.Text = "Выход";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnResult
            // 
            this.BtnResult.BackColor = System.Drawing.Color.Silver;
            this.BtnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResult.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnResult.Location = new System.Drawing.Point(537, 273);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Size = new System.Drawing.Size(240, 48);
            this.BtnResult.TabIndex = 23;
            this.BtnResult.Text = "Вычисление результата";
            this.BtnResult.UseVisualStyleBackColor = false;
            this.BtnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // CbxWeight
            // 
            this.CbxWeight.AutoSize = true;
            this.CbxWeight.Location = new System.Drawing.Point(8, 72);
            this.CbxWeight.Name = "CbxWeight";
            this.CbxWeight.Size = new System.Drawing.Size(70, 23);
            this.CbxWeight.TabIndex = 2;
            this.CbxWeight.Text = "Масса";
            this.CbxWeight.UseVisualStyleBackColor = true;
            // 
            // CbxVolume
            // 
            this.CbxVolume.AutoSize = true;
            this.CbxVolume.Location = new System.Drawing.Point(8, 48);
            this.CbxVolume.Name = "CbxVolume";
            this.CbxVolume.Size = new System.Drawing.Size(76, 23);
            this.CbxVolume.TabIndex = 1;
            this.CbxVolume.Text = "Объём";
            this.CbxVolume.UseVisualStyleBackColor = true;
            // 
            // CbxArea
            // 
            this.CbxArea.AutoSize = true;
            this.CbxArea.Location = new System.Drawing.Point(8, 24);
            this.CbxArea.Name = "CbxArea";
            this.CbxArea.Size = new System.Drawing.Size(193, 23);
            this.CbxArea.TabIndex = 0;
            this.CbxArea.Text = "Площадь поверхности";
            this.CbxArea.UseVisualStyleBackColor = true;
            // 
            // GbxParams
            // 
            this.GbxParams.Controls.Add(this.CbxWeight);
            this.GbxParams.Controls.Add(this.CbxVolume);
            this.GbxParams.Controls.Add(this.CbxArea);
            this.GbxParams.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxParams.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GbxParams.Location = new System.Drawing.Point(297, 273);
            this.GbxParams.Name = "GbxParams";
            this.GbxParams.Size = new System.Drawing.Size(224, 104);
            this.GbxParams.TabIndex = 22;
            this.GbxParams.TabStop = false;
            this.GbxParams.Text = " Параметры вычисления";
            // 
            // LblValueWeight
            // 
            this.LblValueWeight.BackColor = System.Drawing.Color.Gainsboro;
            this.LblValueWeight.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblValueWeight.ForeColor = System.Drawing.Color.Black;
            this.LblValueWeight.Location = new System.Drawing.Point(8, 200);
            this.LblValueWeight.Name = "LblValueWeight";
            this.LblValueWeight.Size = new System.Drawing.Size(208, 32);
            this.LblValueWeight.TabIndex = 15;
            this.LblValueWeight.Text = "————";
            this.LblValueWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblWeight
            // 
            this.LblWeight.BackColor = System.Drawing.Color.Gray;
            this.LblWeight.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblWeight.ForeColor = System.Drawing.Color.Transparent;
            this.LblWeight.Location = new System.Drawing.Point(8, 168);
            this.LblWeight.Name = "LblWeight";
            this.LblWeight.Size = new System.Drawing.Size(208, 32);
            this.LblWeight.TabIndex = 14;
            this.LblWeight.Text = "Масса";
            this.LblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblValueVolume
            // 
            this.LblValueVolume.BackColor = System.Drawing.Color.Gainsboro;
            this.LblValueVolume.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblValueVolume.ForeColor = System.Drawing.Color.Black;
            this.LblValueVolume.Location = new System.Drawing.Point(8, 128);
            this.LblValueVolume.Name = "LblValueVolume";
            this.LblValueVolume.Size = new System.Drawing.Size(208, 32);
            this.LblValueVolume.TabIndex = 13;
            this.LblValueVolume.Text = "————";
            this.LblValueVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GbxImage
            // 
            this.GbxImage.Controls.Add(this.IbxFigure);
            this.GbxImage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxImage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GbxImage.Location = new System.Drawing.Point(529, 25);
            this.GbxImage.Name = "GbxImage";
            this.GbxImage.Size = new System.Drawing.Size(256, 240);
            this.GbxImage.TabIndex = 21;
            this.GbxImage.TabStop = false;
            this.GbxImage.Text = " Фигура ";
            // 
            // LblVolume
            // 
            this.LblVolume.BackColor = System.Drawing.Color.Gray;
            this.LblVolume.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblVolume.ForeColor = System.Drawing.Color.Transparent;
            this.LblVolume.Location = new System.Drawing.Point(8, 96);
            this.LblVolume.Name = "LblVolume";
            this.LblVolume.Size = new System.Drawing.Size(208, 32);
            this.LblVolume.TabIndex = 12;
            this.LblVolume.Text = "Объём";
            this.LblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblArea
            // 
            this.LblArea.BackColor = System.Drawing.Color.Gray;
            this.LblArea.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblArea.ForeColor = System.Drawing.Color.Transparent;
            this.LblArea.Location = new System.Drawing.Point(8, 24);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(208, 32);
            this.LblArea.TabIndex = 10;
            this.LblArea.Text = "Площадь поверхности";
            this.LblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GbxResult
            // 
            this.GbxResult.Controls.Add(this.LblValueWeight);
            this.GbxResult.Controls.Add(this.LblWeight);
            this.GbxResult.Controls.Add(this.LblValueVolume);
            this.GbxResult.Controls.Add(this.LblVolume);
            this.GbxResult.Controls.Add(this.LblValueArea);
            this.GbxResult.Controls.Add(this.LblArea);
            this.GbxResult.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxResult.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GbxResult.Location = new System.Drawing.Point(297, 25);
            this.GbxResult.Name = "GbxResult";
            this.GbxResult.Size = new System.Drawing.Size(224, 240);
            this.GbxResult.TabIndex = 20;
            this.GbxResult.TabStop = false;
            this.GbxResult.Text = " Результат ";
            // 
            // LblValueArea
            // 
            this.LblValueArea.BackColor = System.Drawing.Color.Gainsboro;
            this.LblValueArea.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblValueArea.ForeColor = System.Drawing.Color.Black;
            this.LblValueArea.Location = new System.Drawing.Point(8, 56);
            this.LblValueArea.Name = "LblValueArea";
            this.LblValueArea.Size = new System.Drawing.Size(208, 32);
            this.LblValueArea.TabIndex = 11;
            this.LblValueArea.Text = "————";
            this.LblValueArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxbInputDensity
            // 
            this.TxbInputDensity.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxbInputDensity.Location = new System.Drawing.Point(16, 216);
            this.TxbInputDensity.Multiline = true;
            this.TxbInputDensity.Name = "TxbInputDensity";
            this.TxbInputDensity.Size = new System.Drawing.Size(240, 32);
            this.TxbInputDensity.TabIndex = 11;
            this.TxbInputDensity.Text = "0";
            this.TxbInputDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxbInputDensity.TextChanged += new System.EventHandler(this.TxbInputDensity_TextChanged);
            this.TxbInputDensity.Validating += new System.ComponentModel.CancelEventHandler(this.TxbInputDensity_Validating);
            // 
            // LblDensity
            // 
            this.LblDensity.BackColor = System.Drawing.Color.Gray;
            this.LblDensity.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblDensity.ForeColor = System.Drawing.Color.Transparent;
            this.LblDensity.Location = new System.Drawing.Point(16, 184);
            this.LblDensity.Name = "LblDensity";
            this.LblDensity.Size = new System.Drawing.Size(240, 32);
            this.LblDensity.TabIndex = 10;
            this.LblDensity.Text = "Плотность";
            this.LblDensity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxbInputRadius
            // 
            this.TxbInputRadius.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxbInputRadius.Location = new System.Drawing.Point(16, 136);
            this.TxbInputRadius.Multiline = true;
            this.TxbInputRadius.Name = "TxbInputRadius";
            this.TxbInputRadius.Size = new System.Drawing.Size(240, 32);
            this.TxbInputRadius.TabIndex = 7;
            this.TxbInputRadius.Text = "0";
            this.TxbInputRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxbInputRadius.TextChanged += new System.EventHandler(this.TxbInputRadius_TextChanged);
            this.TxbInputRadius.Validating += new System.ComponentModel.CancelEventHandler(this.TxbInputRadius_Validating);
            // 
            // LblRadius
            // 
            this.LblRadius.BackColor = System.Drawing.Color.Gray;
            this.LblRadius.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblRadius.ForeColor = System.Drawing.Color.Transparent;
            this.LblRadius.Location = new System.Drawing.Point(16, 104);
            this.LblRadius.Name = "LblRadius";
            this.LblRadius.Size = new System.Drawing.Size(240, 32);
            this.LblRadius.TabIndex = 6;
            this.LblRadius.Text = "Радиус";
            this.LblRadius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxbInputHeight
            // 
            this.TxbInputHeight.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxbInputHeight.Location = new System.Drawing.Point(16, 56);
            this.TxbInputHeight.Multiline = true;
            this.TxbInputHeight.Name = "TxbInputHeight";
            this.TxbInputHeight.Size = new System.Drawing.Size(240, 32);
            this.TxbInputHeight.TabIndex = 5;
            this.TxbInputHeight.Text = "0";
            this.TxbInputHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxbInputHeight.TextChanged += new System.EventHandler(this.TxbInputHeight_TextChanged);
            this.TxbInputHeight.Validating += new System.ComponentModel.CancelEventHandler(this.TxbInputHeight_Validating);
            // 
            // LblHeight
            // 
            this.LblHeight.BackColor = System.Drawing.Color.Gray;
            this.LblHeight.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblHeight.ForeColor = System.Drawing.Color.Transparent;
            this.LblHeight.Location = new System.Drawing.Point(16, 24);
            this.LblHeight.Name = "LblHeight";
            this.LblHeight.Size = new System.Drawing.Size(240, 32);
            this.LblHeight.TabIndex = 4;
            this.LblHeight.Text = "Высота";
            this.LblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GbxInputData
            // 
            this.GbxInputData.Controls.Add(this.TxbInputDensity);
            this.GbxInputData.Controls.Add(this.LblDensity);
            this.GbxInputData.Controls.Add(this.TxbInputRadius);
            this.GbxInputData.Controls.Add(this.LblRadius);
            this.GbxInputData.Controls.Add(this.TxbInputHeight);
            this.GbxInputData.Controls.Add(this.LblHeight);
            this.GbxInputData.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxInputData.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GbxInputData.Location = new System.Drawing.Point(17, 25);
            this.GbxInputData.Name = "GbxInputData";
            this.GbxInputData.Size = new System.Drawing.Size(272, 352);
            this.GbxInputData.TabIndex = 19;
            this.GbxInputData.TabStop = false;
            this.GbxInputData.Text = "Ввод данных";
            // 
            // IbxFigure
            // 
            this.IbxFigure.BackColor = System.Drawing.Color.Gray;
            this.ErrDensity.SetIconAlignment(this.IbxFigure, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.IbxFigure.Image = global::HomeWorkWF.Properties.Resources.v_silindra2;
            this.IbxFigure.InitialImage = null;
            this.IbxFigure.Location = new System.Drawing.Point(8, 24);
            this.IbxFigure.Name = "IbxFigure";
            this.IbxFigure.Size = new System.Drawing.Size(240, 208);
            this.IbxFigure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IbxFigure.TabIndex = 0;
            this.IbxFigure.TabStop = false;
            // 
            // FormCylinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(802, 402);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnResult);
            this.Controls.Add(this.GbxParams);
            this.Controls.Add(this.GbxImage);
            this.Controls.Add(this.GbxResult);
            this.Controls.Add(this.GbxInputData);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.MaximizeBox = false;
            this.Name = "FormCylinder";
            this.Text = "Вычисление цилиндра";
            ((System.ComponentModel.ISupportInitialize)(this.ErrDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrHeight)).EndInit();
            this.GbxParams.ResumeLayout(false);
            this.GbxParams.PerformLayout();
            this.GbxImage.ResumeLayout(false);
            this.GbxResult.ResumeLayout(false);
            this.GbxInputData.ResumeLayout(false);
            this.GbxInputData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IbxFigure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ErrDensity;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnResult;
        private System.Windows.Forms.GroupBox GbxParams;
        private System.Windows.Forms.CheckBox CbxWeight;
        private System.Windows.Forms.CheckBox CbxVolume;
        private System.Windows.Forms.CheckBox CbxArea;
        private System.Windows.Forms.GroupBox GbxImage;
        private System.Windows.Forms.PictureBox IbxFigure;
        private System.Windows.Forms.GroupBox GbxResult;
        private System.Windows.Forms.Label LblValueWeight;
        private System.Windows.Forms.Label LblWeight;
        private System.Windows.Forms.Label LblValueVolume;
        private System.Windows.Forms.Label LblVolume;
        private System.Windows.Forms.Label LblValueArea;
        private System.Windows.Forms.Label LblArea;
        private System.Windows.Forms.GroupBox GbxInputData;
        private System.Windows.Forms.TextBox TxbInputDensity;
        private System.Windows.Forms.Label LblDensity;
        private System.Windows.Forms.TextBox TxbInputRadius;
        private System.Windows.Forms.Label LblRadius;
        private System.Windows.Forms.TextBox TxbInputHeight;
        private System.Windows.Forms.Label LblHeight;
        private System.Windows.Forms.ErrorProvider ErrRadius;
        private System.Windows.Forms.ErrorProvider ErrHeight;
    }
}