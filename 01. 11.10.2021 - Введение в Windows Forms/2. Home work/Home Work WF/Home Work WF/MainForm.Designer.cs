namespace Home_Work_WF
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
            this.components = new System.ComponentModel.Container();
            this.TmrDrawing = new System.Windows.Forms.Timer(this.components);
            this.LblDrawing = new System.Windows.Forms.Label();
            this.BtnDrawing = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.BtnGreetings = new System.Windows.Forms.Button();
            this.LblGreetings = new System.Windows.Forms.Label();
            this.TmrGreetings = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TmrDrawing
            // 
            this.TmrDrawing.Interval = 5000;
            this.TmrDrawing.Tick += new System.EventHandler(this.TmrDrawing_Tick);
            // 
            // LblDrawing
            // 
            this.LblDrawing.BackColor = System.Drawing.Color.Gray;
            this.LblDrawing.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblDrawing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblDrawing.Location = new System.Drawing.Point(125, 97);
            this.LblDrawing.Name = "LblDrawing";
            this.LblDrawing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblDrawing.Size = new System.Drawing.Size(532, 300);
            this.LblDrawing.TabIndex = 0;
            this.LblDrawing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnDrawing
            // 
            this.BtnDrawing.BackColor = System.Drawing.Color.Silver;
            this.BtnDrawing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDrawing.Location = new System.Drawing.Point(128, 453);
            this.BtnDrawing.Name = "BtnDrawing";
            this.BtnDrawing.Size = new System.Drawing.Size(146, 63);
            this.BtnDrawing.TabIndex = 1;
            this.BtnDrawing.Text = "Рисунок";
            this.BtnDrawing.UseVisualStyleBackColor = false;
            this.BtnDrawing.Click += new System.EventHandler(this.BtnDrawing_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.BackColor = System.Drawing.Color.IndianRed;
            this.BtnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuit.Location = new System.Drawing.Point(511, 453);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(146, 63);
            this.BtnQuit.TabIndex = 2;
            this.BtnQuit.Text = "Выход";
            this.BtnQuit.UseVisualStyleBackColor = false;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // BtnGreetings
            // 
            this.BtnGreetings.BackColor = System.Drawing.Color.Silver;
            this.BtnGreetings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGreetings.Location = new System.Drawing.Point(308, 453);
            this.BtnGreetings.Name = "BtnGreetings";
            this.BtnGreetings.Size = new System.Drawing.Size(165, 63);
            this.BtnGreetings.TabIndex = 3;
            this.BtnGreetings.Text = "Приветствие";
            this.BtnGreetings.UseVisualStyleBackColor = false;
            this.BtnGreetings.Click += new System.EventHandler(this.BtnGreetings_Click);
            // 
            // LblGreetings
            // 
            this.LblGreetings.BackColor = System.Drawing.Color.Gray;
            this.LblGreetings.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblGreetings.Location = new System.Drawing.Point(124, 25);
            this.LblGreetings.Name = "LblGreetings";
            this.LblGreetings.Size = new System.Drawing.Size(533, 40);
            this.LblGreetings.TabIndex = 4;
            this.LblGreetings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TmrGreetings
            // 
            this.TmrGreetings.Interval = 5000;
            this.TmrGreetings.Tick += new System.EventHandler(this.TmrGreetings_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.LblGreetings);
            this.Controls.Add(this.BtnGreetings);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnDrawing);
            this.Controls.Add(this.LblDrawing);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Домашнее задание на 13.10.2021";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TmrDrawing;
        private System.Windows.Forms.Label LblDrawing;
        private System.Windows.Forms.Button BtnDrawing;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.Button BtnGreetings;
        private System.Windows.Forms.Label LblGreetings;
        private System.Windows.Forms.Timer TmrGreetings;
    }
}

