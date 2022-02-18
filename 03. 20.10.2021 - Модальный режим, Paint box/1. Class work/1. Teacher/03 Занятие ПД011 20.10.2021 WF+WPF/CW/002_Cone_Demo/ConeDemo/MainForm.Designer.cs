namespace ConeDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblRadius = new System.Windows.Forms.Label();
            this.txbRadius = new System.Windows.Forms.TextBox();
            this.grbData = new System.Windows.Forms.GroupBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txbHeight = new System.Windows.Forms.TextBox();
            this.lblDensity = new System.Windows.Forms.Label();
            this.txbDensity = new System.Windows.Forms.TextBox();
            this.chbVolume = new System.Windows.Forms.CheckBox();
            this.chbMassa = new System.Windows.Forms.CheckBox();
            this.grbResult = new System.Windows.Forms.GroupBox();
            this.lblMassa = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbData.SuspendLayout();
            this.grbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(24, 32);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(84, 13);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Радиус конуса:";
            // 
            // txbRadius
            // 
            this.txbRadius.Location = new System.Drawing.Point(112, 28);
            this.txbRadius.Name = "txbRadius";
            this.txbRadius.Size = new System.Drawing.Size(184, 20);
            this.txbRadius.TabIndex = 1;
            this.txbRadius.Text = "0";
            this.txbRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grbData
            // 
            this.grbData.Controls.Add(this.lblHeight);
            this.grbData.Controls.Add(this.txbHeight);
            this.grbData.Controls.Add(this.lblRadius);
            this.grbData.Controls.Add(this.txbRadius);
            this.grbData.Location = new System.Drawing.Point(16, 16);
            this.grbData.Name = "grbData";
            this.grbData.Size = new System.Drawing.Size(312, 136);
            this.grbData.TabIndex = 2;
            this.grbData.TabStop = false;
            this.grbData.Text = " Исходные данные: ";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(24, 64);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(86, 13);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Высота конуса:";
            // 
            // txbHeight
            // 
            this.txbHeight.Location = new System.Drawing.Point(112, 60);
            this.txbHeight.Name = "txbHeight";
            this.txbHeight.Size = new System.Drawing.Size(184, 20);
            this.txbHeight.TabIndex = 3;
            this.txbHeight.Text = "0";
            this.txbHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDensity
            // 
            this.lblDensity.AutoSize = true;
            this.lblDensity.Location = new System.Drawing.Point(40, 112);
            this.lblDensity.Name = "lblDensity";
            this.lblDensity.Size = new System.Drawing.Size(122, 13);
            this.lblDensity.TabIndex = 4;
            this.lblDensity.Text = "Плотность материала:";
            // 
            // txbDensity
            // 
            this.txbDensity.Enabled = false;
            this.txbDensity.Location = new System.Drawing.Point(168, 108);
            this.txbDensity.Name = "txbDensity";
            this.txbDensity.Size = new System.Drawing.Size(144, 20);
            this.txbDensity.TabIndex = 5;
            this.txbDensity.Text = "0";
            this.txbDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chbVolume
            // 
            this.chbVolume.AutoSize = true;
            this.chbVolume.Checked = true;
            this.chbVolume.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbVolume.ForeColor = System.Drawing.Color.Navy;
            this.chbVolume.Location = new System.Drawing.Point(360, 48);
            this.chbVolume.Name = "chbVolume";
            this.chbVolume.Size = new System.Drawing.Size(134, 17);
            this.chbVolume.TabIndex = 6;
            this.chbVolume.Text = "Рассчитывать объем";
            this.chbVolume.UseVisualStyleBackColor = true;
            // 
            // chbMassa
            // 
            this.chbMassa.AutoSize = true;
            this.chbMassa.ForeColor = System.Drawing.Color.Navy;
            this.chbMassa.Location = new System.Drawing.Point(360, 80);
            this.chbMassa.Name = "chbMassa";
            this.chbMassa.Size = new System.Drawing.Size(132, 17);
            this.chbMassa.TabIndex = 7;
            this.chbMassa.Text = "Рассчитывать массу";
            this.chbMassa.UseVisualStyleBackColor = true;
            // 
            // grbResult
            // 
            this.grbResult.Controls.Add(this.lblMassa);
            this.grbResult.Controls.Add(this.lblVolume);
            this.grbResult.Enabled = false;
            this.grbResult.Location = new System.Drawing.Point(16, 160);
            this.grbResult.Name = "grbResult";
            this.grbResult.Size = new System.Drawing.Size(312, 80);
            this.grbResult.TabIndex = 8;
            this.grbResult.TabStop = false;
            this.grbResult.Text = " Результаты расчета: ";
            // 
            // lblMassa
            // 
            this.lblMassa.AutoSize = true;
            this.lblMassa.Location = new System.Drawing.Point(24, 56);
            this.lblMassa.Name = "lblMassa";
            this.lblMassa.Size = new System.Drawing.Size(78, 13);
            this.lblMassa.TabIndex = 1;
            this.lblMassa.Text = "Масса конуса";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(24, 32);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(80, 13);
            this.lblVolume.TabIndex = 0;
            this.lblVolume.Text = "Объем конуса";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(352, 167);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(136, 28);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(352, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 28);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(504, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grbResult);
            this.Controls.Add(this.chbMassa);
            this.Controls.Add(this.chbVolume);
            this.Controls.Add(this.lblDensity);
            this.Controls.Add(this.txbDensity);
            this.Controls.Add(this.grbData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 300);
            this.MinimumSize = new System.Drawing.Size(520, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчет параметров конуса";
            this.grbData.ResumeLayout(false);
            this.grbData.PerformLayout();
            this.grbResult.ResumeLayout(false);
            this.grbResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.TextBox txbRadius;
        private System.Windows.Forms.GroupBox grbData;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txbHeight;
        private System.Windows.Forms.Label lblDensity;
        private System.Windows.Forms.TextBox txbDensity;
        private System.Windows.Forms.CheckBox chbVolume;
        private System.Windows.Forms.CheckBox chbMassa;
        private System.Windows.Forms.GroupBox grbResult;
        private System.Windows.Forms.Label lblMassa;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

