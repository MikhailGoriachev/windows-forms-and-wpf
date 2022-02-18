
namespace UiElements
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
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.TxbText1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxbMultiLine = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxbSrcFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MtbInput = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NudNumber = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.TrbNumber = new System.Windows.Forms.TrackBar();
            this.PrbNumber = new System.Windows.Forms.ProgressBar();
            this.LnlItstep = new System.Windows.Forms.LinkLabel();
            this.LnlCalc = new System.Windows.Forms.LinkLabel();
            this.LnlBackColor = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.NudNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // TxbText1
            // 
            this.TxbText1.AutoCompleteCustomSource.AddRange(new string[] {
            "автомобиль",
            "букварь",
            "телега",
            "кофе",
            "чай",
            "яблоко"});
            this.TxbText1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxbText1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.TxbText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxbText1.Location = new System.Drawing.Point(32, 100);
            this.TxbText1.Margin = new System.Windows.Forms.Padding(4);
            this.TxbText1.Name = "TxbText1";
            this.TxbText1.Size = new System.Drawing.Size(360, 23);
            this.TxbText1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Строка ввода с автодополнением:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Строка ввода пароля:";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "автомобиль",
            "букварь",
            "телега",
            "кофе",
            "чай",
            "яблоко"});
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(32, 152);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(360, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(32, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Многострочная строка ввода:";
            // 
            // TxbMultiLine
            // 
            this.TxbMultiLine.AutoCompleteCustomSource.AddRange(new string[] {
            "автомобиль",
            "букварь",
            "телега",
            "кофе",
            "чай",
            "яблоко"});
            this.TxbMultiLine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxbMultiLine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.TxbMultiLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxbMultiLine.Location = new System.Drawing.Point(32, 212);
            this.TxbMultiLine.Margin = new System.Windows.Forms.Padding(4);
            this.TxbMultiLine.Multiline = true;
            this.TxbMultiLine.Name = "TxbMultiLine";
            this.TxbMultiLine.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxbMultiLine.Size = new System.Drawing.Size(360, 196);
            this.TxbMultiLine.TabIndex = 5;
            this.TxbMultiLine.Text = "Текст для отображения\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(432, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Текст из файла:";
            // 
            // TxbSrcFile
            // 
            this.TxbSrcFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbSrcFile.AutoCompleteCustomSource.AddRange(new string[] {
            "автомобиль",
            "букварь",
            "телега",
            "кофе",
            "чай",
            "яблоко"});
            this.TxbSrcFile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxbSrcFile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.TxbSrcFile.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxbSrcFile.Location = new System.Drawing.Point(432, 68);
            this.TxbSrcFile.Margin = new System.Windows.Forms.Padding(4);
            this.TxbSrcFile.Multiline = true;
            this.TxbSrcFile.Name = "TxbSrcFile";
            this.TxbSrcFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxbSrcFile.Size = new System.Drawing.Size(608, 340);
            this.TxbSrcFile.TabIndex = 7;
            this.TxbSrcFile.WordWrap = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(32, 448);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Строка ввода по шаблону:";
            // 
            // MtbInput
            // 
            this.MtbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MtbInput.Location = new System.Drawing.Point(32, 472);
            this.MtbInput.Mask = "00/00/0000";
            this.MtbInput.Name = "MtbInput";
            this.MtbInput.Size = new System.Drawing.Size(328, 23);
            this.MtbInput.TabIndex = 10;
            this.MtbInput.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(432, 448);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ввод числовых данных:";
            // 
            // NudNumber
            // 
            this.NudNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NudNumber.DecimalPlaces = 5;
            this.NudNumber.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NudNumber.InterceptArrowKeys = false;
            this.NudNumber.Location = new System.Drawing.Point(432, 472);
            this.NudNumber.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NudNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.NudNumber.Name = "NudNumber";
            this.NudNumber.Size = new System.Drawing.Size(216, 23);
            this.NudNumber.TabIndex = 12;
            this.NudNumber.ThousandsSeparator = true;
            this.NudNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.NudNumber.ValueChanged += new System.EventHandler(this.NudNumber_ValueChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(728, 448);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ввод данных регулятором:";
            // 
            // TrbNumber
            // 
            this.TrbNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TrbNumber.AutoSize = false;
            this.TrbNumber.LargeChange = 20;
            this.TrbNumber.Location = new System.Drawing.Point(728, 464);
            this.TrbNumber.Maximum = 210;
            this.TrbNumber.Minimum = 10;
            this.TrbNumber.Name = "TrbNumber";
            this.TrbNumber.Size = new System.Drawing.Size(312, 48);
            this.TrbNumber.SmallChange = 10;
            this.TrbNumber.TabIndex = 14;
            this.TrbNumber.TickFrequency = 20;
            this.TrbNumber.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TrbNumber.Value = 10;
            this.TrbNumber.Scroll += new System.EventHandler(this.TrbNumber_Scroll);
            // 
            // PrbNumber
            // 
            this.PrbNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PrbNumber.Location = new System.Drawing.Point(728, 424);
            this.PrbNumber.Maximum = 210;
            this.PrbNumber.Minimum = 10;
            this.PrbNumber.Name = "PrbNumber";
            this.PrbNumber.Size = new System.Drawing.Size(312, 15);
            this.PrbNumber.TabIndex = 15;
            this.PrbNumber.Value = 10;
            // 
            // LnlItstep
            // 
            this.LnlItstep.AutoSize = true;
            this.LnlItstep.Location = new System.Drawing.Point(32, 24);
            this.LnlItstep.Name = "LnlItstep";
            this.LnlItstep.Size = new System.Drawing.Size(186, 17);
            this.LnlItstep.TabIndex = 16;
            this.LnlItstep.TabStop = true;
            this.LnlItstep.Text = "Переход на сайт академии";
            this.LnlItstep.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnlItstep_LinkClicked);
            // 
            // LnlCalc
            // 
            this.LnlCalc.AutoSize = true;
            this.LnlCalc.Location = new System.Drawing.Point(243, 24);
            this.LnlCalc.Name = "LnlCalc";
            this.LnlCalc.Size = new System.Drawing.Size(149, 17);
            this.LnlCalc.TabIndex = 17;
            this.LnlCalc.TabStop = true;
            this.LnlCalc.Text = "Запуск калькулятора";
            this.LnlCalc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnlCalc_LinkClicked);
            // 
            // LnlBackColor
            // 
            this.LnlBackColor.AutoSize = true;
            this.LnlBackColor.Location = new System.Drawing.Point(246, 56);
            this.LnlBackColor.Name = "LnlBackColor";
            this.LnlBackColor.Size = new System.Drawing.Size(146, 17);
            this.LnlBackColor.TabIndex = 18;
            this.LnlBackColor.TabStop = true;
            this.LnlBackColor.Text = "Переключение фона";
            this.LnlBackColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnlBackColor_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.LnlBackColor);
            this.Controls.Add(this.LnlCalc);
            this.Controls.Add(this.LnlItstep);
            this.Controls.Add(this.PrbNumber);
            this.Controls.Add(this.TrbNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NudNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MtbInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxbSrcFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxbMultiLine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbText1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1083, 593);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Занятие 28.10.2021. Элементы интерфейса пользователя";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxbText1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxbMultiLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxbSrcFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MtbInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NudNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar TrbNumber;
        private System.Windows.Forms.ProgressBar PrbNumber;
        private System.Windows.Forms.LinkLabel LnlItstep;
        private System.Windows.Forms.LinkLabel LnlCalc;
        private System.Windows.Forms.LinkLabel LnlBackColor;
    }
}

