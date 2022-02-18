namespace TableFunctions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ctg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTable = new System.Windows.Forms.ToolStripMenuItem();
            this.примерЗаполненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проимерЗаполненияИзКоллекцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.stlMain = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.stsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.AllowUserToOrderColumns = true;
            this.dgvTable.AllowUserToResizeColumns = false;
            this.dgvTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.sin,
            this.Cos,
            this.Tan,
            this.Ctg});
            this.dgvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTable.Location = new System.Drawing.Point(0, 24);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RowHeadersVisible = false;
            this.dgvTable.RowTemplate.DividerHeight = 2;
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.Size = new System.Drawing.Size(904, 415);
            this.dgvTable.TabIndex = 0;
            // 
            // x
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.x.DefaultCellStyle = dataGridViewCellStyle3;
            this.x.FillWeight = 22.22217F;
            this.x.HeaderText = "x";
            this.x.Name = "x";
            this.x.ReadOnly = true;
            // 
            // sin
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.sin.DefaultCellStyle = dataGridViewCellStyle4;
            this.sin.FillWeight = 49.16654F;
            this.sin.HeaderText = "Sin(x + π)";
            this.sin.Name = "sin";
            this.sin.ReadOnly = true;
            // 
            // Cos
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Cos.DefaultCellStyle = dataGridViewCellStyle5;
            this.Cos.FillWeight = 49.16654F;
            this.Cos.HeaderText = "Cos(x + π)";
            this.Cos.Name = "Cos";
            this.Cos.ReadOnly = true;
            // 
            // Tan
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Tan.DefaultCellStyle = dataGridViewCellStyle6;
            this.Tan.FillWeight = 49.16654F;
            this.Tan.HeaderText = "Tan(x + π)";
            this.Tan.Name = "Tan";
            this.Tan.ReadOnly = true;
            // 
            // Ctg
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Ctg.DefaultCellStyle = dataGridViewCellStyle7;
            this.Ctg.FillWeight = 49.16654F;
            this.Ctg.HeaderText = "Ctg(x + π)";
            this.Ctg.Name = "Ctg";
            this.Ctg.ReadOnly = true;
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.mniTable,
            this.mniHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(904, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(48, 20);
            this.mniFile.Text = "Ф&айл";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(180, 22);
            this.mniExit.Text = "Вы&ход";
            this.mniExit.Click += new System.EventHandler(this.ExitCommand);
            // 
            // mniTable
            // 
            this.mniTable.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.примерЗаполненияToolStripMenuItem,
            this.проимерЗаполненияИзКоллекцииToolStripMenuItem});
            this.mniTable.Name = "mniTable";
            this.mniTable.Size = new System.Drawing.Size(65, 20);
            this.mniTable.Text = "Таблица";
            // 
            // примерЗаполненияToolStripMenuItem
            // 
            this.примерЗаполненияToolStripMenuItem.Name = "примерЗаполненияToolStripMenuItem";
            this.примерЗаполненияToolStripMenuItem.Size = new System.Drawing.Size(353, 22);
            this.примерЗаполненияToolStripMenuItem.Text = "Пример заполнения сгенерированными данными";
            this.примерЗаполненияToolStripMenuItem.Click += new System.EventHandler(this.MniSimpleTable_Click);
            // 
            // проимерЗаполненияИзКоллекцииToolStripMenuItem
            // 
            this.проимерЗаполненияИзКоллекцииToolStripMenuItem.Name = "проимерЗаполненияИзКоллекцииToolStripMenuItem";
            this.проимерЗаполненияИзКоллекцииToolStripMenuItem.Size = new System.Drawing.Size(353, 22);
            this.проимерЗаполненияИзКоллекцииToolStripMenuItem.Text = "Пример заполнения из коллекции";
            this.проимерЗаполненияИзКоллекцииToolStripMenuItem.Click += new System.EventHandler(this.MniCollectionTable_Click);
            // 
            // mniHelp
            // 
            this.mniHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniAbout});
            this.mniHelp.Name = "mniHelp";
            this.mniHelp.Size = new System.Drawing.Size(65, 20);
            this.mniHelp.Text = "Спра&вка";
            // 
            // mniAbout
            // 
            this.mniAbout.Name = "mniAbout";
            this.mniAbout.Size = new System.Drawing.Size(180, 22);
            this.mniAbout.Text = "О пр&ограмме...";
            this.mniAbout.Click += new System.EventHandler(this.AboutCommand);
            // 
            // stsMain
            // 
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlMain});
            this.stsMain.Location = new System.Drawing.Point(0, 439);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(904, 22);
            this.stsMain.TabIndex = 2;
            this.stsMain.Text = "statusStrip1";
            // 
            // stlMain
            // 
            this.stlMain.Name = "stlMain";
            this.stlMain.Size = new System.Drawing.Size(889, 17);
            this.stlMain.Spring = true;
            this.stlMain.Text = "Готов";
            this.stlMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 461);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.stsMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Занятие 09.12.2021 - демонстрация DataGridView: Таблица тригонометрических функци" +
    "й";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.ToolStripStatusLabel stlMain;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniHelp;
        private System.Windows.Forms.ToolStripMenuItem mniAbout;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn sin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ctg;
        private System.Windows.Forms.ToolStripMenuItem mniTable;
        private System.Windows.Forms.ToolStripMenuItem примерЗаполненияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проимерЗаполненияИзКоллекцииToolStripMenuItem;
    }
}

