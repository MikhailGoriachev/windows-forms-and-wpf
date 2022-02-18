namespace ManyForms
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
            this.btnFirstForm = new System.Windows.Forms.Button();
            this.btnSecndForm = new System.Windows.Forms.Button();
            this.btnThirdForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnFourhForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFirstForm
            // 
            this.btnFirstForm.Location = new System.Drawing.Point(24, 16);
            this.btnFirstForm.Name = "btnFirstForm";
            this.btnFirstForm.Size = new System.Drawing.Size(232, 40);
            this.btnFirstForm.TabIndex = 0;
            this.btnFirstForm.Text = "Форма 1";
            this.btnFirstForm.UseVisualStyleBackColor = true;
            this.btnFirstForm.Click += new System.EventHandler(this.btnFirstForm_Click);
            // 
            // btnSecndForm
            // 
            this.btnSecndForm.Location = new System.Drawing.Point(24, 65);
            this.btnSecndForm.Name = "btnSecndForm";
            this.btnSecndForm.Size = new System.Drawing.Size(232, 40);
            this.btnSecndForm.TabIndex = 1;
            this.btnSecndForm.Text = "Форма 2";
            this.btnSecndForm.UseVisualStyleBackColor = true;
            this.btnSecndForm.Click += new System.EventHandler(this.btnSecndForm_Click);
            // 
            // btnThirdForm
            // 
            this.btnThirdForm.Location = new System.Drawing.Point(24, 114);
            this.btnThirdForm.Name = "btnThirdForm";
            this.btnThirdForm.Size = new System.Drawing.Size(232, 40);
            this.btnThirdForm.TabIndex = 2;
            this.btnThirdForm.Text = "Форма 3";
            this.btnThirdForm.UseVisualStyleBackColor = true;
            this.btnThirdForm.Click += new System.EventHandler(this.btnThirdForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(24, 293);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(232, 40);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(24, 360);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(35, 13);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "label1";
            // 
            // btnFourhForm
            // 
            this.btnFourhForm.Location = new System.Drawing.Point(24, 163);
            this.btnFourhForm.Name = "btnFourhForm";
            this.btnFourhForm.Size = new System.Drawing.Size(232, 40);
            this.btnFourhForm.TabIndex = 5;
            this.btnFourhForm.Text = "Форма 4";
            this.btnFourhForm.UseVisualStyleBackColor = true;
            this.btnFourhForm.Click += new System.EventHandler(this.btnFourhForm_Click);
            // 
            // button1
            // 
            this.button1.Image = global::ManyForms.Properties.Resources.coffee;
            this.button1.Location = new System.Drawing.Point(24, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 72);
            this.button1.TabIndex = 6;
            this.button1.Text = "Форма 5";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFourhForm);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnThirdForm);
            this.Controls.Add(this.btnSecndForm);
            this.Controls.Add(this.btnFirstForm);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 430);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с несколькими формами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirstForm;
        private System.Windows.Forms.Button btnSecndForm;
        private System.Windows.Forms.Button btnThirdForm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnFourhForm;
        private System.Windows.Forms.Button button1;
    }
}

