
namespace StandardDialogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MnuMain = new System.Windows.Forms.MenuStrip();
            this.MniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MniFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MniFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MniFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MniFileSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.MniFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MniService = new System.Windows.Forms.ToolStripMenuItem();
            this.MniServiceFont = new System.Windows.Forms.ToolStripMenuItem();
            this.MniServiceBackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.MniServiceColor = new System.Windows.Forms.ToolStripMenuItem();
            this.OfdMain = new System.Windows.Forms.OpenFileDialog();
            this.SfdMain = new System.Windows.Forms.SaveFileDialog();
            this.TxbText = new System.Windows.Forms.TextBox();
            this.StsMain = new System.Windows.Forms.StatusStrip();
            this.StlMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.FdlTextFont = new System.Windows.Forms.FontDialog();
            this.CdlBackColor = new System.Windows.Forms.ColorDialog();
            this.MnuMain.SuspendLayout();
            this.StsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuMain
            // 
            this.MnuMain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MniFile,
            this.MniService});
            this.MnuMain.Location = new System.Drawing.Point(0, 0);
            this.MnuMain.Name = "MnuMain";
            this.MnuMain.Size = new System.Drawing.Size(800, 28);
            this.MnuMain.TabIndex = 0;
            // 
            // MniFile
            // 
            this.MniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MniFileNew,
            this.MniFileOpen,
            this.MniFileSave,
            this.MniFileSep1,
            this.MniFileExit});
            this.MniFile.Name = "MniFile";
            this.MniFile.Size = new System.Drawing.Size(57, 24);
            this.MniFile.Text = "Файл";
            // 
            // MniFileNew
            // 
            this.MniFileNew.Name = "MniFileNew";
            this.MniFileNew.Size = new System.Drawing.Size(161, 24);
            this.MniFileNew.Text = "Новый";
            this.MniFileNew.Click += new System.EventHandler(this.New_Click);
            // 
            // MniFileOpen
            // 
            this.MniFileOpen.Name = "MniFileOpen";
            this.MniFileOpen.Size = new System.Drawing.Size(161, 24);
            this.MniFileOpen.Text = "Открыть...";
            this.MniFileOpen.Click += new System.EventHandler(this.Open_Click);
            // 
            // MniFileSave
            // 
            this.MniFileSave.Name = "MniFileSave";
            this.MniFileSave.Size = new System.Drawing.Size(161, 24);
            this.MniFileSave.Text = "Сохранить...";
            this.MniFileSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // MniFileSep1
            // 
            this.MniFileSep1.Name = "MniFileSep1";
            this.MniFileSep1.Size = new System.Drawing.Size(158, 6);
            // 
            // MniFileExit
            // 
            this.MniFileExit.Name = "MniFileExit";
            this.MniFileExit.Size = new System.Drawing.Size(161, 24);
            this.MniFileExit.Text = "Выход";
            this.MniFileExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MniService
            // 
            this.MniService.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MniServiceFont,
            this.MniServiceBackColor,
            this.MniServiceColor});
            this.MniService.Name = "MniService";
            this.MniService.Size = new System.Drawing.Size(71, 24);
            this.MniService.Text = "Сервис";
            // 
            // MniServiceFont
            // 
            this.MniServiceFont.Name = "MniServiceFont";
            this.MniServiceFont.Size = new System.Drawing.Size(193, 24);
            this.MniServiceFont.Text = "Шрифт...";
            this.MniServiceFont.Click += new System.EventHandler(this.Font_Click);
            // 
            // MniServiceBackColor
            // 
            this.MniServiceBackColor.Name = "MniServiceBackColor";
            this.MniServiceBackColor.Size = new System.Drawing.Size(193, 24);
            this.MniServiceBackColor.Text = "Цвет фона...";
            this.MniServiceBackColor.Click += new System.EventHandler(this.Backcolor_Click);
            // 
            // MniServiceColor
            // 
            this.MniServiceColor.Name = "MniServiceColor";
            this.MniServiceColor.Size = new System.Drawing.Size(193, 24);
            this.MniServiceColor.Text = "Цвет символов...";
            this.MniServiceColor.Click += new System.EventHandler(this.Color_Click);
            // 
            // OfdMain
            // 
            this.OfdMain.Filter = "Текстовые файлы (*.txt)|*.txt|Файлы XML (*.xml)|*.xml|Файлы JSON(*.json)|*.json|В" +
    "се файлы (*.*)|*.*";
            this.OfdMain.InitialDirectory = "d:\\students";
            this.OfdMain.SupportMultiDottedExtensions = true;
            this.OfdMain.Title = "Открыть текстовый документ";
            // 
            // SfdMain
            // 
            this.SfdMain.Filter = "Текстовые файлы (*.txt)|*.txt|Файлы XML (*.xml)|*.xml|Файлы JSON(*.json)|*.json|В" +
    "се файлы (*.*)|*.*";
            this.SfdMain.InitialDirectory = "d:\\students";
            this.SfdMain.SupportMultiDottedExtensions = true;
            this.SfdMain.Title = "Сохранить текстовый документ";
            // 
            // TxbText
            // 
            this.TxbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxbText.Location = new System.Drawing.Point(0, 28);
            this.TxbText.Multiline = true;
            this.TxbText.Name = "TxbText";
            this.TxbText.Size = new System.Drawing.Size(800, 400);
            this.TxbText.TabIndex = 1;
            // 
            // StsMain
            // 
            this.StsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StlMain});
            this.StsMain.Location = new System.Drawing.Point(0, 428);
            this.StsMain.Name = "StsMain";
            this.StsMain.Size = new System.Drawing.Size(800, 22);
            this.StsMain.TabIndex = 2;
            this.StsMain.Text = "statusStrip1";
            // 
            // StlMain
            // 
            this.StlMain.Name = "StlMain";
            this.StlMain.Size = new System.Drawing.Size(785, 17);
            this.StlMain.Spring = true;
            this.StlMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CdlBackColor
            // 
            this.CdlBackColor.AnyColor = true;
            this.CdlBackColor.FullOpen = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxbText);
            this.Controls.Add(this.StsMain);
            this.Controls.Add(this.MnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MnuMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Занятие 17.11.2021 - стандартные диалоги";
            this.MnuMain.ResumeLayout(false);
            this.MnuMain.PerformLayout();
            this.StsMain.ResumeLayout(false);
            this.StsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuMain;
        private System.Windows.Forms.ToolStripMenuItem MniFile;
        private System.Windows.Forms.ToolStripMenuItem MniFileNew;
        private System.Windows.Forms.ToolStripMenuItem MniFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MniFileSave;
        private System.Windows.Forms.ToolStripSeparator MniFileSep1;
        private System.Windows.Forms.ToolStripMenuItem MniFileExit;
        private System.Windows.Forms.OpenFileDialog OfdMain;
        private System.Windows.Forms.SaveFileDialog SfdMain;
        private System.Windows.Forms.TextBox TxbText;
        private System.Windows.Forms.StatusStrip StsMain;
        private System.Windows.Forms.ToolStripStatusLabel StlMain;
        private System.Windows.Forms.ToolStripMenuItem MniService;
        private System.Windows.Forms.ToolStripMenuItem MniServiceFont;
        private System.Windows.Forms.FontDialog FdlTextFont;
        private System.Windows.Forms.ToolStripMenuItem MniServiceBackColor;
        private System.Windows.Forms.ColorDialog CdlBackColor;
        private System.Windows.Forms.ToolStripMenuItem MniServiceColor;
    }
}

