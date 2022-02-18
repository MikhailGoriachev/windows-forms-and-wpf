
namespace HelloWorld2
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
            this.LblHeader = new System.Windows.Forms.Label();
            this.BtnGreeting = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.LblGreeting = new System.Windows.Forms.Label();
            this.tmrFirst = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblHeader
            // 
            this.LblHeader.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblHeader.Location = new System.Drawing.Point(50, 46);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(539, 38);
            this.LblHeader.TabIndex = 1;
            this.LblHeader.Text = "Вывод текстового приветствия";
            this.LblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnGreeting
            // 
            this.BtnGreeting.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnGreeting.Location = new System.Drawing.Point(50, 345);
            this.BtnGreeting.Name = "BtnGreeting";
            this.BtnGreeting.Size = new System.Drawing.Size(218, 44);
            this.BtnGreeting.TabIndex = 2;
            this.BtnGreeting.Text = "Приветствовать";
            this.BtnGreeting.UseVisualStyleBackColor = true;
            this.BtnGreeting.Click += new System.EventHandler(this.BtnGreeting_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnQuit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnQuit.Location = new System.Drawing.Point(371, 345);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(218, 44);
            this.BtnQuit.TabIndex = 3;
            this.BtnQuit.Text = "Выход";
            this.BtnQuit.UseVisualStyleBackColor = false;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // LblGreeting
            // 
            this.LblGreeting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LblGreeting.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblGreeting.Location = new System.Drawing.Point(50, 103);
            this.LblGreeting.Name = "LblGreeting";
            this.LblGreeting.Size = new System.Drawing.Size(539, 206);
            this.LblGreeting.TabIndex = 4;
            this.LblGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrFirst
            // 
            this.tmrFirst.Interval = 5000;
            this.tmrFirst.Tick += new System.EventHandler(this.tmrFirst_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.LblGreeting);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnGreeting);
            this.Controls.Add(this.LblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Первое приложение Windows Forms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Button BtnGreeting;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.Label LblGreeting;
        private System.Windows.Forms.Timer tmrFirst;
    }
}

