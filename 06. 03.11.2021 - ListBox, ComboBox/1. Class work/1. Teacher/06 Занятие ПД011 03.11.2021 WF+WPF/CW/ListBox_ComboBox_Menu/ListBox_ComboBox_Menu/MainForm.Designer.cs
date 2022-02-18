
namespace ListBox_ComboBox_Menu
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
        protected override void Dispose (bool disposing) {
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
        private void InitializeComponent () {
            this.LbxFruits = new System.Windows.Forms.ListBox();
            this.CbxFruits = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAddToListBox = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CbxSimple = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxDropdownList = new System.Windows.Forms.ComboBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.MnuMain = new System.Windows.Forms.MenuStrip();
            this.MniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MniCollections = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьИзListBoxaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.стеретьListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MniHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MniAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbxFruits
            // 
            this.LbxFruits.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbxFruits.FormattingEnabled = true;
            this.LbxFruits.ItemHeight = 17;
            this.LbxFruits.Items.AddRange(new object[] {
            "Вишни",
            "Груши",
            "Сливы",
            "Яблоки"});
            this.LbxFruits.Location = new System.Drawing.Point(48, 52);
            this.LbxFruits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LbxFruits.Name = "LbxFruits";
            this.LbxFruits.ScrollAlwaysVisible = true;
            this.LbxFruits.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LbxFruits.Size = new System.Drawing.Size(217, 225);
            this.LbxFruits.TabIndex = 0;
            this.LbxFruits.SelectedIndexChanged += new System.EventHandler(this.LbxFruits_SelectedIndexChanged);
            // 
            // CbxFruits
            // 
            this.CbxFruits.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbxFruits.FormattingEnabled = true;
            this.CbxFruits.Items.AddRange(new object[] {
            "Яблоки",
            "Груши",
            "Вишни",
            "Сливы"});
            this.CbxFruits.Location = new System.Drawing.Point(48, 332);
            this.CbxFruits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbxFruits.Name = "CbxFruits";
            this.CbxFruits.Size = new System.Drawing.Size(217, 25);
            this.CbxFruits.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "ListBox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(48, 312);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "ComboBox - DropDown";
            // 
            // BtnAddToListBox
            // 
            this.BtnAddToListBox.Font = new System.Drawing.Font("Tahoma", 9F);
            this.BtnAddToListBox.Image = global::ListBox_ComboBox_Menu.Properties.Resources.horse;
            this.BtnAddToListBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddToListBox.Location = new System.Drawing.Point(18, 400);
            this.BtnAddToListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAddToListBox.Name = "BtnAddToListBox";
            this.BtnAddToListBox.Size = new System.Drawing.Size(186, 65);
            this.BtnAddToListBox.TabIndex = 4;
            this.BtnAddToListBox.Text = "Добавить в ListBox";
            this.BtnAddToListBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddToListBox.UseVisualStyleBackColor = true;
            this.BtnAddToListBox.Click += new System.EventHandler(this.BtnAddToListBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(328, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "ComboBox - Simple";
            // 
            // CbxSimple
            // 
            this.CbxSimple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CbxSimple.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbxSimple.FormattingEnabled = true;
            this.CbxSimple.Items.AddRange(new object[] {
            "Уголь",
            "Сера",
            "Селитра",
            "Порох",
            "Сахар",
            "Жидкий кислород"});
            this.CbxSimple.Location = new System.Drawing.Point(328, 65);
            this.CbxSimple.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbxSimple.Name = "CbxSimple";
            this.CbxSimple.Size = new System.Drawing.Size(208, 215);
            this.CbxSimple.TabIndex = 5;
            this.CbxSimple.SelectedIndexChanged += new System.EventHandler(this.CbxSimple_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(328, 312);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "ComboBox  - DropdownList ";
            // 
            // CbxDropdownList
            // 
            this.CbxDropdownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxDropdownList.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbxDropdownList.FormattingEnabled = true;
            this.CbxDropdownList.Items.AddRange(new object[] {
            "Огурцы",
            "Рис",
            "Капуста",
            "Брокколи",
            "Морковь",
            "Помидоры"});
            this.CbxDropdownList.Location = new System.Drawing.Point(328, 332);
            this.CbxDropdownList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbxDropdownList.Name = "CbxDropdownList";
            this.CbxDropdownList.Size = new System.Drawing.Size(208, 25);
            this.CbxDropdownList.TabIndex = 7;
            this.CbxDropdownList.SelectedIndexChanged += new System.EventHandler(this.CbxDropdownList_SelectedIndexChanged);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Tahoma", 9F);
            this.BtnDelete.Image = global::ListBox_ComboBox_Menu.Properties.Resources.turtle;
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.Location = new System.Drawing.Point(216, 400);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(210, 65);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Удалить из ListBox\'a";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnClear.Font = new System.Drawing.Font("Tahoma", 9F);
            this.BtnClear.Image = global::ListBox_ComboBox_Menu.Properties.Resources.bull;
            this.BtnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClear.Location = new System.Drawing.Point(438, 400);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(168, 65);
            this.BtnClear.TabIndex = 10;
            this.BtnClear.Text = "Стереть ListBox";
            this.BtnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // MnuMain
            // 
            this.MnuMain.Font = new System.Drawing.Font("Tahoma", 10F);
            this.MnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MniFile,
            this.listBoxToolStripMenuItem,
            this.MniHelp});
            this.MnuMain.Location = new System.Drawing.Point(0, 0);
            this.MnuMain.Name = "MnuMain";
            this.MnuMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MnuMain.Size = new System.Drawing.Size(617, 25);
            this.MnuMain.TabIndex = 11;
            this.MnuMain.Text = "menuStrip1";
            // 
            // MniFile
            // 
            this.MniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MniCollections,
            this.toolStripMenuItem1,
            this.MniExit});
            this.MniFile.Name = "MniFile";
            this.MniFile.Size = new System.Drawing.Size(53, 21);
            this.MniFile.Text = "Ф&айл";
            // 
            // MniCollections
            // 
            this.MniCollections.Image = global::ListBox_ComboBox_Menu.Properties.Resources.cat;
            this.MniCollections.Name = "MniCollections";
            this.MniCollections.Size = new System.Drawing.Size(215, 26);
            this.MniCollections.Text = "К&оллекции объектов";
            this.MniCollections.Click += new System.EventHandler(this.MniCollections_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(212, 6);
            // 
            // MniExit
            // 
            this.MniExit.Image = global::ListBox_ComboBox_Menu.Properties.Resources.ladybug;
            this.MniExit.Name = "MniExit";
            this.MniExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MniExit.Size = new System.Drawing.Size(215, 26);
            this.MniExit.Text = "В&ыход";
            this.MniExit.Click += new System.EventHandler(this.MniExit_Click);
            // 
            // listBoxToolStripMenuItem
            // 
            this.listBoxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьВListBoxToolStripMenuItem,
            this.удалитьИзListBoxaToolStripMenuItem,
            this.toolStripMenuItem2,
            this.стеретьListBoxToolStripMenuItem});
            this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.listBoxToolStripMenuItem.Text = "ListBox";
            // 
            // добавитьВListBoxToolStripMenuItem
            // 
            this.добавитьВListBoxToolStripMenuItem.Image = global::ListBox_ComboBox_Menu.Properties.Resources.horse;
            this.добавитьВListBoxToolStripMenuItem.Name = "добавитьВListBoxToolStripMenuItem";
            this.добавитьВListBoxToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.добавитьВListBoxToolStripMenuItem.Text = "Добавить в ListBox";
            this.добавитьВListBoxToolStripMenuItem.Click += new System.EventHandler(this.BtnAddToListBox_Click);
            // 
            // удалитьИзListBoxaToolStripMenuItem
            // 
            this.удалитьИзListBoxaToolStripMenuItem.Image = global::ListBox_ComboBox_Menu.Properties.Resources.turtle;
            this.удалитьИзListBoxaToolStripMenuItem.Name = "удалитьИзListBoxaToolStripMenuItem";
            this.удалитьИзListBoxaToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.удалитьИзListBoxaToolStripMenuItem.Text = "Удалить из ListBox\'a";
            this.удалитьИзListBoxaToolStripMenuItem.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(207, 6);
            // 
            // стеретьListBoxToolStripMenuItem
            // 
            this.стеретьListBoxToolStripMenuItem.Image = global::ListBox_ComboBox_Menu.Properties.Resources.bull;
            this.стеретьListBoxToolStripMenuItem.Name = "стеретьListBoxToolStripMenuItem";
            this.стеретьListBoxToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.стеретьListBoxToolStripMenuItem.Text = "Стереть ListBox";
            this.стеретьListBoxToolStripMenuItem.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // MniHelp
            // 
            this.MniHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MniHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MniAbout});
            this.MniHelp.Name = "MniHelp";
            this.MniHelp.Size = new System.Drawing.Size(72, 21);
            this.MniHelp.Text = "П&омощь";
            // 
            // MniAbout
            // 
            this.MniAbout.Image = global::ListBox_ComboBox_Menu.Properties.Resources.elephant;
            this.MniAbout.Name = "MniAbout";
            this.MniAbout.Size = new System.Drawing.Size(176, 26);
            this.MniAbout.Text = "О про&грамме...";
            this.MniAbout.Click += new System.EventHandler(this.MniAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 493);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbxDropdownList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbxSimple);
            this.Controls.Add(this.BtnAddToListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbxFruits);
            this.Controls.Add(this.LbxFruits);
            this.Controls.Add(this.MnuMain);
            this.MainMenuStrip = this.MnuMain;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(633, 532);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(633, 532);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Исследование элементов интерфейса ListBox, ComboBox";
            this.MnuMain.ResumeLayout(false);
            this.MnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbxFruits;
        private System.Windows.Forms.ComboBox CbxFruits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAddToListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxSimple;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbxDropdownList;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.MenuStrip MnuMain;
        private System.Windows.Forms.ToolStripMenuItem MniFile;
        private System.Windows.Forms.ToolStripMenuItem MniCollections;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MniExit;
        private System.Windows.Forms.ToolStripMenuItem MniHelp;
        private System.Windows.Forms.ToolStripMenuItem MniAbout;
        private System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьВListBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьИзListBoxaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem стеретьListBoxToolStripMenuItem;
    }
}

