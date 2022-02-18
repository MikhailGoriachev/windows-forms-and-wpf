
namespace BindingListBoxContextMenu.Views
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.пункт1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пункт2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.пункт1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.пункт2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LbxWorkers = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьРаботникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьРаботникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LblWorkes = new System.Windows.Forms.Label();
            this.GrbWorker = new System.Windows.Forms.GroupBox();
            this.TxbWorker = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выходToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.GrbWorker.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolToolStripMenuItem,
            this.работникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1036, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.toolToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = global::BindingListBoxContextMenu.Properties.Resources.door_out;
            this.выходToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(142, 38);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.Exit_Command);
            // 
            // работникиToolStripMenuItem
            // 
            this.работникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.работникиToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.работникиToolStripMenuItem.Name = "работникиToolStripMenuItem";
            this.работникиToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.работникиToolStripMenuItem.Text = "Работники";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Image = global::BindingListBoxContextMenu.Properties.Resources.user_add;
            this.добавитьToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(265, 38);
            this.добавитьToolStripMenuItem.Text = "Добавить работника...";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.AddWorker_Command);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Image = global::BindingListBoxContextMenu.Properties.Resources.user_delete;
            this.удалитьToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(265, 38);
            this.удалитьToolStripMenuItem.Text = "Удалить работнка";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.Delete_Command);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton4,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripSplitButton1,
            this.toolStripSeparator2,
            this.toolStripDropDownButton1,
            this.toolStripComboBox1,
            this.toolStripProgressBar1,
            this.toolStripTextBox1,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 26);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1036, 36);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::BindingListBoxContextMenu.Properties.Resources.user_add;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 33);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Добавление работника";
            this.toolStripButton1.Click += new System.EventHandler(this.AddWorker_Command);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::BindingListBoxContextMenu.Properties.Resources.user_edit;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(36, 33);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.ToolTipText = "Редактирование данных\r\nработника";
            this.toolStripButton4.Click += new System.EventHandler(this.WorkerEdit_Command);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::BindingListBoxContextMenu.Properties.Resources.user_delete;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 33);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Удаление работника";
            this.toolStripButton2.Click += new System.EventHandler(this.Delete_Command);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(244, 33);
            this.toolStripLabel1.Text = "метка на панели инструментов";
            this.toolStripLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пункт1ToolStripMenuItem,
            this.пункт2ToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::BindingListBoxContextMenu.Properties.Resources.user_batman;
            this.toolStripSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(48, 33);
            this.toolStripSplitButton1.ToolTipText = "Кнопка с разделителем и выпадающим меню";
            // 
            // пункт1ToolStripMenuItem
            // 
            this.пункт1ToolStripMenuItem.Name = "пункт1ToolStripMenuItem";
            this.пункт1ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.пункт1ToolStripMenuItem.Text = "Пункт 1";
            // 
            // пункт2ToolStripMenuItem
            // 
            this.пункт2ToolStripMenuItem.Name = "пункт2ToolStripMenuItem";
            this.пункт2ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.пункт2ToolStripMenuItem.Text = "Пункт 2";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пункт1ToolStripMenuItem1,
            this.пункт2ToolStripMenuItem1});
            this.toolStripDropDownButton1.Image = global::BindingListBoxContextMenu.Properties.Resources.user_catwomen;
            this.toolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(45, 33);
            this.toolStripDropDownButton1.ToolTipText = "Кнопка без разделителя, но с выпадающим меню ";
            // 
            // пункт1ToolStripMenuItem1
            // 
            this.пункт1ToolStripMenuItem1.Name = "пункт1ToolStripMenuItem1";
            this.пункт1ToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.пункт1ToolStripMenuItem1.Text = "Пункт 1";
            // 
            // пункт2ToolStripMenuItem1
            // 
            this.пункт2ToolStripMenuItem1.Name = "пункт2ToolStripMenuItem1";
            this.пункт2ToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.пункт2ToolStripMenuItem1.Text = "Пункт 2";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Элемент 1",
            "Элемент 2",
            "Элемент 3",
            "Элемент 4",
            "Элемент 5"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 36);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 33);
            this.toolStripProgressBar1.ToolTipText = "Пример прогресс-бара на панели инструментов";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AutoToolTip = true;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 36);
            this.toolStripTextBox1.ToolTipText = "Пример TextBox на панели инструментов";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::BindingListBoxContextMenu.Properties.Resources.door_out;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(36, 33);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTipText = "Завершение работы приложения";
            this.toolStripButton3.Click += new System.EventHandler(this.Exit_Command);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusStrip1.Location = new System.Drawing.Point(0, 582);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1036, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LbxWorkers
            // 
            this.LbxWorkers.ContextMenuStrip = this.contextMenuStrip1;
            this.LbxWorkers.DataSource = this.LbxWorkers.CustomTabOffsets;
            this.LbxWorkers.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbxWorkers.FormattingEnabled = true;
            this.LbxWorkers.HorizontalScrollbar = true;
            this.LbxWorkers.ItemHeight = 22;
            this.LbxWorkers.Location = new System.Drawing.Point(24, 128);
            this.LbxWorkers.Name = "LbxWorkers";
            this.LbxWorkers.Size = new System.Drawing.Size(568, 334);
            this.LbxWorkers.TabIndex = 3;
            this.LbxWorkers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LbxWokers_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьРаботникаToolStripMenuItem,
            this.удалитьРаботникаToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(281, 124);
            // 
            // добавитьРаботникаToolStripMenuItem
            // 
            this.добавитьРаботникаToolStripMenuItem.Image = global::BindingListBoxContextMenu.Properties.Resources.user_add;
            this.добавитьРаботникаToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.добавитьРаботникаToolStripMenuItem.Name = "добавитьРаботникаToolStripMenuItem";
            this.добавитьРаботникаToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.добавитьРаботникаToolStripMenuItem.Text = "Добавить работника...";
            // 
            // удалитьРаботникаToolStripMenuItem
            // 
            this.удалитьРаботникаToolStripMenuItem.Image = global::BindingListBoxContextMenu.Properties.Resources.user_delete;
            this.удалитьРаботникаToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.удалитьРаботникаToolStripMenuItem.Name = "удалитьРаботникаToolStripMenuItem";
            this.удалитьРаботникаToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.удалитьРаботникаToolStripMenuItem.Text = "Удалить работника";
            this.удалитьРаботникаToolStripMenuItem.Click += new System.EventHandler(this.Delete_Command);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(277, 6);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Image = global::BindingListBoxContextMenu.Properties.Resources.door_out;
            this.выходToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(280, 38);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.Exit_Command);
            // 
            // LblWorkes
            // 
            this.LblWorkes.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblWorkes.Location = new System.Drawing.Point(24, 80);
            this.LblWorkes.Name = "LblWorkes";
            this.LblWorkes.Size = new System.Drawing.Size(568, 48);
            this.LblWorkes.TabIndex = 4;
            this.LblWorkes.Text = "Работники:\r\nИд      Фамилия И.О.           должность       возраст";
            // 
            // GrbWorker
            // 
            this.GrbWorker.Controls.Add(this.TxbWorker);
            this.GrbWorker.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GrbWorker.Location = new System.Drawing.Point(648, 112);
            this.GrbWorker.Name = "GrbWorker";
            this.GrbWorker.Size = new System.Drawing.Size(360, 200);
            this.GrbWorker.TabIndex = 5;
            this.GrbWorker.TabStop = false;
            this.GrbWorker.Text = "Выбран работник:";
            // 
            // TxbWorker
            // 
            this.TxbWorker.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxbWorker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxbWorker.Location = new System.Drawing.Point(3, 22);
            this.TxbWorker.Multiline = true;
            this.TxbWorker.Name = "TxbWorker";
            this.TxbWorker.ReadOnly = true;
            this.TxbWorker.Size = new System.Drawing.Size(354, 175);
            this.TxbWorker.TabIndex = 0;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem2});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(145, 42);
            // 
            // выходToolStripMenuItem2
            // 
            this.выходToolStripMenuItem2.Image = global::BindingListBoxContextMenu.Properties.Resources.door_out;
            this.выходToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.выходToolStripMenuItem2.Name = "выходToolStripMenuItem2";
            this.выходToolStripMenuItem2.Size = new System.Drawing.Size(144, 38);
            this.выходToolStripMenuItem2.Text = "Выход";
            this.выходToolStripMenuItem2.Click += new System.EventHandler(this.Exit_Command);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 604);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Controls.Add(this.GrbWorker);
            this.Controls.Add(this.LblWorkes);
            this.Controls.Add(this.LbxWorkers);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Занятие 08.11.2021";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.GrbWorker.ResumeLayout(false);
            this.GrbWorker.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListBox LbxWorkers;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label LblWorkes;
        private System.Windows.Forms.GroupBox GrbWorker;
        private System.Windows.Forms.TextBox TxbWorker;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem пункт1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пункт2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem пункт1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem пункт2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem работникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьРаботникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьРаботникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}

