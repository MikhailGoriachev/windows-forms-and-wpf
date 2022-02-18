namespace DragAndDropDemo
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
            this.BtnExit = new System.Windows.Forms.Button();
            this.TxtData = new System.Windows.Forms.TextBox();
            this.LblData = new System.Windows.Forms.Label();
            this.ChbEnable = new System.Windows.Forms.CheckBox();
            this.LblInfo2 = new System.Windows.Forms.Label();
            this.LblInfo1 = new System.Windows.Forms.Label();
            this.MnuMain = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAddition = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTabPages = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.AllowDrop = true;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExit.Location = new System.Drawing.Point(448, 417);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(219, 36);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "Выход";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnExit_DragDrop);
            this.BtnExit.DragEnter += new System.Windows.Forms.DragEventHandler(this.elements_DragEnter);
            // 
            // TxtData
            // 
            this.TxtData.AllowDrop = true;
            this.TxtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtData.Location = new System.Drawing.Point(16, 64);
            this.TxtData.Multiline = true;
            this.TxtData.Name = "TxtData";
            this.TxtData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtData.Size = new System.Drawing.Size(648, 152);
            this.TxtData.TabIndex = 1;
            this.TxtData.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtData_DragDrop);
            this.TxtData.DragEnter += new System.Windows.Forms.DragEventHandler(this.elements_DragEnter);
            this.TxtData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSource_MouseDown);
            // 
            // LblData
            // 
            this.LblData.AllowDrop = true;
            this.LblData.BackColor = System.Drawing.Color.Honeydew;
            this.LblData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblData.Location = new System.Drawing.Point(16, 256);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(648, 144);
            this.LblData.TabIndex = 2;
            this.LblData.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblData_DragDrop);
            this.LblData.DragEnter += new System.Windows.Forms.DragEventHandler(this.elements_DragEnter);
            // 
            // ChbEnable
            // 
            this.ChbEnable.AutoSize = true;
            this.ChbEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChbEnable.Location = new System.Drawing.Point(16, 424);
            this.ChbEnable.Name = "ChbEnable";
            this.ChbEnable.Size = new System.Drawing.Size(368, 22);
            this.ChbEnable.TabIndex = 3;
            this.ChbEnable.Text = "Разрешить перетаскивание на кнопку из TextBox";
            this.ChbEnable.UseVisualStyleBackColor = true;
            this.ChbEnable.CheckStateChanged += new System.EventHandler(this.chbEnable_CheckStateChanged);
            // 
            // LblInfo2
            // 
            this.LblInfo2.AutoSize = true;
            this.LblInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblInfo2.Location = new System.Drawing.Point(16, 232);
            this.LblInfo2.Name = "LblInfo2";
            this.LblInfo2.Size = new System.Drawing.Size(438, 18);
            this.LblInfo2.TabIndex = 4;
            this.LblInfo2.Text = "Label. Сюда можно перетаскивать текст из верхнего TextBox:";
            // 
            // LblInfo1
            // 
            this.LblInfo1.AutoSize = true;
            this.LblInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblInfo1.Location = new System.Drawing.Point(16, 40);
            this.LblInfo1.Name = "LblInfo1";
            this.LblInfo1.Size = new System.Drawing.Size(573, 18);
            this.LblInfo1.TabIndex = 5;
            this.LblInfo1.Text = "TextBox. Сюда можно перетаскивать файлы, выделенный текст, и отсюда тоже:";
            // 
            // MnuMain
            // 
            this.MnuMain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.mniAddition});
            this.MnuMain.Location = new System.Drawing.Point(0, 0);
            this.MnuMain.Name = "MnuMain";
            this.MnuMain.Size = new System.Drawing.Size(685, 28);
            this.MnuMain.TabIndex = 6;
            this.MnuMain.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFileExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(57, 24);
            this.mniFile.Text = "Файл";
            // 
            // mniFileExit
            // 
            this.mniFileExit.Name = "mniFileExit";
            this.mniFileExit.Size = new System.Drawing.Size(180, 24);
            this.mniFileExit.Text = "Выход";
            this.mniFileExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // mniAddition
            // 
            this.mniAddition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniTabPages});
            this.mniAddition.Name = "mniAddition";
            this.mniAddition.Size = new System.Drawing.Size(132, 24);
            this.mniAddition.Text = "Дополнительно";
            // 
            // mniTabPages
            // 
            this.mniTabPages.Name = "mniTabPages";
            this.mniTabPages.Size = new System.Drawing.Size(148, 24);
            this.mniTabPages.Text = "Страницы";
            this.mniTabPages.Click += new System.EventHandler(this.MniTabPages_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.BtnExit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(685, 466);
            this.Controls.Add(this.LblInfo1);
            this.Controls.Add(this.LblInfo2);
            this.Controls.Add(this.ChbEnable);
            this.Controls.Add(this.LblData);
            this.Controls.Add(this.TxtData);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.MnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Демонстрация Drag and Drop - техника перетаскивания";
            this.MnuMain.ResumeLayout(false);
            this.MnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox TxtData;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.CheckBox ChbEnable;
        private System.Windows.Forms.Label LblInfo2;
        private System.Windows.Forms.Label LblInfo1;
        private System.Windows.Forms.MenuStrip MnuMain;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniFileExit;
        private System.Windows.Forms.ToolStripMenuItem mniAddition;
        private System.Windows.Forms.ToolStripMenuItem mniTabPages;
    }
}

