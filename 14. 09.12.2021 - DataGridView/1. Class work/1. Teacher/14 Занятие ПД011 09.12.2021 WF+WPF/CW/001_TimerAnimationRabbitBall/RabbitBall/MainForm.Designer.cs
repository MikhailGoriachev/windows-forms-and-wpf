namespace RabbitBall
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
            this.pbxMain = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tmrAnimation = new System.Windows.Forms.Timer(this.components);
            this.TrbInterval = new System.Windows.Forms.TrackBar();
            this.LblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxMain
            // 
            this.pbxMain.Image = global::RabbitBall.Properties.Resources.a1;
            this.pbxMain.Location = new System.Drawing.Point(16, 16);
            this.pbxMain.Name = "pbxMain";
            this.pbxMain.Size = new System.Drawing.Size(432, 376);
            this.pbxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMain.TabIndex = 1;
            this.pbxMain.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(464, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MistyRose;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(624, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Стоп";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // tmrAnimation
            // 
            this.tmrAnimation.Interval = 300;
            this.tmrAnimation.Tick += new System.EventHandler(this.Animation_Tick);
            // 
            // TrbInterval
            // 
            this.TrbInterval.LargeChange = 100;
            this.TrbInterval.Location = new System.Drawing.Point(464, 184);
            this.TrbInterval.Maximum = 1000;
            this.TrbInterval.Minimum = 50;
            this.TrbInterval.Name = "TrbInterval";
            this.TrbInterval.Size = new System.Drawing.Size(304, 45);
            this.TrbInterval.SmallChange = 10;
            this.TrbInterval.TabIndex = 4;
            this.TrbInterval.TickFrequency = 100;
            this.TrbInterval.Value = 100;
            this.TrbInterval.Scroll += new System.EventHandler(this.TrbInterval_Scroll);
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblInfo.Location = new System.Drawing.Point(464, 144);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(132, 18);
            this.LblInfo.TabIndex = 5;
            this.LblInfo.Text = "Период анимации";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.TrbInterval);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbxMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 453);
            this.MinimumSize = new System.Drawing.Size(816, 453);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Занятие 09.12.2021 - пример покадровой анимации с таймером";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer tmrAnimation;
        private System.Windows.Forms.Label LblInfo;
        protected System.Windows.Forms.TrackBar TrbInterval;
    }
}

