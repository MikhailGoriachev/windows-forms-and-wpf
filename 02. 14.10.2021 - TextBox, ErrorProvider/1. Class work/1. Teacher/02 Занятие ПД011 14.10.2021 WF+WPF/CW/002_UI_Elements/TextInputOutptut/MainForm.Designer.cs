
namespace TextInputOutptut
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
            if (disposing && (components != null))
            {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GrbInputData = new System.Windows.Forms.GroupBox();
            this.TbxThirdNumber = new System.Windows.Forms.TextBox();
            this.LblThirdNumber = new System.Windows.Forms.Label();
            this.TbxSecndNumber = new System.Windows.Forms.TextBox();
            this.LblSecndNumber = new System.Windows.Forms.Label();
            this.TbxFirstNumber = new System.Windows.Forms.TextBox();
            this.LblFirstNumber = new System.Windows.Forms.Label();
            this.GrbResult = new System.Windows.Forms.GroupBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.BtnMinimum = new System.Windows.Forms.Button();
            this.BtnMaximum = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.ErpNumberA = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErpNumberB = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErpNumberC = new System.Windows.Forms.ErrorProvider(this.components);
            this.GrbInputData.SuspendLayout();
            this.GrbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErpNumberA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErpNumberB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErpNumberC)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbInputData
            // 
            this.GrbInputData.Controls.Add(this.TbxThirdNumber);
            this.GrbInputData.Controls.Add(this.LblThirdNumber);
            this.GrbInputData.Controls.Add(this.TbxSecndNumber);
            this.GrbInputData.Controls.Add(this.LblSecndNumber);
            this.GrbInputData.Controls.Add(this.TbxFirstNumber);
            this.GrbInputData.Controls.Add(this.LblFirstNumber);
            this.GrbInputData.Location = new System.Drawing.Point(24, 29);
            this.GrbInputData.Name = "GrbInputData";
            this.GrbInputData.Size = new System.Drawing.Size(401, 278);
            this.GrbInputData.TabIndex = 0;
            this.GrbInputData.TabStop = false;
            this.GrbInputData.Text = " Исходные данные: ";
            // 
            // TbxThirdNumber
            // 
            this.TbxThirdNumber.Location = new System.Drawing.Point(18, 212);
            this.TbxThirdNumber.Name = "TbxThirdNumber";
            this.TbxThirdNumber.Size = new System.Drawing.Size(364, 27);
            this.TbxThirdNumber.TabIndex = 5;
            this.TbxThirdNumber.TextChanged += new System.EventHandler(this.TbxThirdNumber_TextChanged);
            // 
            // LblThirdNumber
            // 
            this.LblThirdNumber.AutoSize = true;
            this.LblThirdNumber.Location = new System.Drawing.Point(18, 190);
            this.LblThirdNumber.Name = "LblThirdNumber";
            this.LblThirdNumber.Size = new System.Drawing.Size(126, 18);
            this.LblThirdNumber.TabIndex = 4;
            this.LblThirdNumber.Text = "Третье число:";
            // 
            // TbxSecndNumber
            // 
            this.TbxSecndNumber.Location = new System.Drawing.Point(15, 142);
            this.TbxSecndNumber.Name = "TbxSecndNumber";
            this.TbxSecndNumber.Size = new System.Drawing.Size(364, 27);
            this.TbxSecndNumber.TabIndex = 3;
            this.TbxSecndNumber.TextChanged += new System.EventHandler(this.TbxSecndNumber_TextChanged);
            // 
            // LblSecndNumber
            // 
            this.LblSecndNumber.AutoSize = true;
            this.LblSecndNumber.Location = new System.Drawing.Point(15, 120);
            this.LblSecndNumber.Name = "LblSecndNumber";
            this.LblSecndNumber.Size = new System.Drawing.Size(128, 18);
            this.LblSecndNumber.TabIndex = 2;
            this.LblSecndNumber.Text = "Второе число:";
            // 
            // TbxFirstNumber
            // 
            this.TbxFirstNumber.Location = new System.Drawing.Point(18, 69);
            this.TbxFirstNumber.Name = "TbxFirstNumber";
            this.TbxFirstNumber.Size = new System.Drawing.Size(364, 27);
            this.TbxFirstNumber.TabIndex = 1;
            this.TbxFirstNumber.TextChanged += new System.EventHandler(this.TbxFirstNumber_TextChanged);
            // 
            // LblFirstNumber
            // 
            this.LblFirstNumber.AutoSize = true;
            this.LblFirstNumber.Location = new System.Drawing.Point(18, 47);
            this.LblFirstNumber.Name = "LblFirstNumber";
            this.LblFirstNumber.Size = new System.Drawing.Size(132, 18);
            this.LblFirstNumber.TabIndex = 0;
            this.LblFirstNumber.Text = "Первое число:";
            // 
            // GrbResult
            // 
            this.GrbResult.Controls.Add(this.LblResult);
            this.GrbResult.Location = new System.Drawing.Point(444, 29);
            this.GrbResult.Name = "GrbResult";
            this.GrbResult.Size = new System.Drawing.Size(350, 278);
            this.GrbResult.TabIndex = 1;
            this.GrbResult.TabStop = false;
            this.GrbResult.Text = " Результат: ";
            // 
            // LblResult
            // 
            this.LblResult.BackColor = System.Drawing.Color.Honeydew;
            this.LblResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblResult.Location = new System.Drawing.Point(3, 23);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(344, 252);
            this.LblResult.TabIndex = 0;
            this.LblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnMinimum
            // 
            this.BtnMinimum.Image = global::TextInputOutptut.Properties.Resources.fish;
            this.BtnMinimum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMinimum.Location = new System.Drawing.Point(24, 345);
            this.BtnMinimum.Name = "BtnMinimum";
            this.BtnMinimum.Size = new System.Drawing.Size(322, 65);
            this.BtnMinimum.TabIndex = 2;
            this.BtnMinimum.Text = "Минимальное число";
            this.BtnMinimum.UseVisualStyleBackColor = true;
            this.BtnMinimum.Click += new System.EventHandler(this.BtnMinimum_Click);
            // 
            // BtnMaximum
            // 
            this.BtnMaximum.Image = global::TextInputOutptut.Properties.Resources.cat;
            this.BtnMaximum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMaximum.Location = new System.Drawing.Point(375, 345);
            this.BtnMaximum.Name = "BtnMaximum";
            this.BtnMaximum.Size = new System.Drawing.Size(322, 65);
            this.BtnMaximum.TabIndex = 3;
            this.BtnMaximum.Text = "Максимальное число";
            this.BtnMaximum.UseVisualStyleBackColor = true;
            this.BtnMaximum.Click += new System.EventHandler(this.BtnMaximum_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Image = global::TextInputOutptut.Properties.Resources.leopard;
            this.BtnQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnQuit.Location = new System.Drawing.Point(719, 345);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(75, 65);
            this.BtnQuit.TabIndex = 4;
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // ErpNumberA
            // 
            this.ErpNumberA.ContainerControl = this;
            // 
            // ErpNumberB
            // 
            this.ErpNumberB.ContainerControl = this;
            // 
            // ErpNumberC
            // 
            this.ErpNumberC.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnMaximum);
            this.Controls.Add(this.BtnMinimum);
            this.Controls.Add(this.GrbResult);
            this.Controls.Add(this.GrbInputData);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(842, 489);
            this.MinimumSize = new System.Drawing.Size(842, 489);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Занятие 14.10.2021 - элементы ввода";
            this.GrbInputData.ResumeLayout(false);
            this.GrbInputData.PerformLayout();
            this.GrbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErpNumberA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErpNumberB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErpNumberC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbInputData;
        private System.Windows.Forms.GroupBox GrbResult;
        private System.Windows.Forms.TextBox TbxThirdNumber;
        private System.Windows.Forms.Label LblThirdNumber;
        private System.Windows.Forms.TextBox TbxSecndNumber;
        private System.Windows.Forms.Label LblSecndNumber;
        private System.Windows.Forms.TextBox TbxFirstNumber;
        private System.Windows.Forms.Label LblFirstNumber;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Button BtnMinimum;
        private System.Windows.Forms.Button BtnMaximum;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.ErrorProvider ErpNumberA;
        private System.Windows.Forms.ErrorProvider ErpNumberB;
        private System.Windows.Forms.ErrorProvider ErpNumberC;
    }
}

