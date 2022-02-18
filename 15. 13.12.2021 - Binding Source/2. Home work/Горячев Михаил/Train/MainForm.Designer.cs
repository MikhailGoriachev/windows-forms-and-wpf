
namespace Train
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MspMain = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MsiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OfdMain = new System.Windows.Forms.OpenFileDialog();
            this.SfdMain = new System.Windows.Forms.SaveFileDialog();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GbxTrain = new System.Windows.Forms.GroupBox();
            this.TrvTrain = new System.Windows.Forms.TreeView();
            this.GbxWagon = new System.Windows.Forms.GroupBox();
            this.DgvWagon = new System.Windows.Forms.DataGridView();
            this.StateTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImlTreeView = new System.Windows.Forms.ImageList(this.components);
            this.ClmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BndTrain = new System.Windows.Forms.BindingSource(this.components);
            this.MspMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.GbxTrain.SuspendLayout();
            this.GbxWagon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvWagon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BndTrain)).BeginInit();
            this.SuspendLayout();
            // 
            // MspMain
            // 
            this.MspMain.BackColor = System.Drawing.Color.Gray;
            this.MspMain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MspMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MspMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.MspMain.Location = new System.Drawing.Point(0, 0);
            this.MspMain.Name = "MspMain";
            this.MspMain.Size = new System.Drawing.Size(1091, 28);
            this.MspMain.TabIndex = 0;
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsiOpen,
            this.MsiSaveAs,
            this.toolStripMenuItem1,
            this.MsiExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // MsiOpen
            // 
            this.MsiOpen.Name = "MsiOpen";
            this.MsiOpen.Size = new System.Drawing.Size(187, 24);
            this.MsiOpen.Text = "&Открыть...";
            this.MsiOpen.Click += new System.EventHandler(this.Open_Command);
            // 
            // MsiSaveAs
            // 
            this.MsiSaveAs.Name = "MsiSaveAs";
            this.MsiSaveAs.Size = new System.Drawing.Size(187, 24);
            this.MsiSaveAs.Text = "&Сохранить как...";
            this.MsiSaveAs.Click += new System.EventHandler(this.SaveAs_Command);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 6);
            // 
            // MsiExit
            // 
            this.MsiExit.Name = "MsiExit";
            this.MsiExit.Size = new System.Drawing.Size(187, 24);
            this.MsiExit.Text = "&Выход";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 509);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1091, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1091, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OfdMain
            // 
            this.OfdMain.DefaultExt = "json";
            this.OfdMain.FileName = "train.json";
            this.OfdMain.Filter = "Файлы JSON (*.json)|*.json| Все файлы (*.*)|*.*";
            this.OfdMain.InitialDirectory = "./";
            // 
            // SfdMain
            // 
            this.SfdMain.DefaultExt = "json";
            this.SfdMain.FileName = "train.json";
            this.SfdMain.Filter = "Файлы JSON (*.json)|*.json| Все файлы (*.*)|*.*";
            this.SfdMain.InitialDirectory = "./";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 53);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 456);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 53);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GbxTrain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GbxWagon);
            this.splitContainer1.Size = new System.Drawing.Size(1088, 456);
            this.splitContainer1.SplitterDistance = 470;
            this.splitContainer1.TabIndex = 5;
            // 
            // GbxTrain
            // 
            this.GbxTrain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxTrain.Controls.Add(this.TrvTrain);
            this.GbxTrain.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxTrain.ForeColor = System.Drawing.Color.White;
            this.GbxTrain.Location = new System.Drawing.Point(8, 8);
            this.GbxTrain.Name = "GbxTrain";
            this.GbxTrain.Size = new System.Drawing.Size(457, 440);
            this.GbxTrain.TabIndex = 0;
            this.GbxTrain.TabStop = false;
            this.GbxTrain.Text = " Обзор поезда ";
            // 
            // TrvTrain
            // 
            this.TrvTrain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrvTrain.BackColor = System.Drawing.Color.DarkGray;
            this.TrvTrain.ImageIndex = 0;
            this.TrvTrain.ImageList = this.ImlTreeView;
            this.TrvTrain.Location = new System.Drawing.Point(8, 24);
            this.TrvTrain.Name = "TrvTrain";
            this.TrvTrain.SelectedImageIndex = 0;
            this.TrvTrain.Size = new System.Drawing.Size(439, 408);
            this.TrvTrain.TabIndex = 0;
            this.TrvTrain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrvTrain_AfterSelect);
            // 
            // GbxWagon
            // 
            this.GbxWagon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxWagon.Controls.Add(this.DgvWagon);
            this.GbxWagon.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.GbxWagon.ForeColor = System.Drawing.Color.White;
            this.GbxWagon.Location = new System.Drawing.Point(0, 8);
            this.GbxWagon.Name = "GbxWagon";
            this.GbxWagon.Size = new System.Drawing.Size(607, 440);
            this.GbxWagon.TabIndex = 0;
            this.GbxWagon.TabStop = false;
            this.GbxWagon.Text = " Вагон: №";
            // 
            // DgvWagon
            // 
            this.DgvWagon.AllowUserToAddRows = false;
            this.DgvWagon.AllowUserToDeleteRows = false;
            this.DgvWagon.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            this.DgvWagon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvWagon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvWagon.AutoGenerateColumns = false;
            this.DgvWagon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvWagon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvWagon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvWagon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvWagon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvWagon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmNumber,
            this.StateTitle});
            this.DgvWagon.DataSource = this.BndTrain;
            this.DgvWagon.GridColor = System.Drawing.Color.DarkGray;
            this.DgvWagon.Location = new System.Drawing.Point(8, 24);
            this.DgvWagon.MultiSelect = false;
            this.DgvWagon.Name = "DgvWagon";
            this.DgvWagon.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvWagon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvWagon.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.DgvWagon.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvWagon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvWagon.Size = new System.Drawing.Size(593, 408);
            this.DgvWagon.TabIndex = 0;
            // 
            // StateTitle
            // 
            this.StateTitle.DataPropertyName = "StateTitle";
            this.StateTitle.HeaderText = "Состояние билета";
            this.StateTitle.Name = "StateTitle";
            this.StateTitle.ReadOnly = true;
            // 
            // ImlTreeView
            // 
            this.ImlTreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImlTreeView.ImageStream")));
            this.ImlTreeView.TransparentColor = System.Drawing.Color.Transparent;
            this.ImlTreeView.Images.SetKeyName(0, "train.png");
            this.ImlTreeView.Images.SetKeyName(1, "train_metro.png");
            this.ImlTreeView.Images.SetKeyName(2, "curtain.png");
            this.ImlTreeView.Images.SetKeyName(3, "terminal_seats_blue.png");
            this.ImlTreeView.Images.SetKeyName(4, "terminal_seats_red.png");
            // 
            // ClmNumber
            // 
            this.ClmNumber.DataPropertyName = "Number";
            this.ClmNumber.HeaderText = "Номер места";
            this.ClmNumber.Name = "ClmNumber";
            this.ClmNumber.ReadOnly = true;
            // 
            // BndTrain
            // 
            this.BndTrain.DataSource = typeof(Train.Models.Seat);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1091, 531);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MspMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MspMain;
            this.MinimumSize = new System.Drawing.Size(1107, 570);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Домашняя работа на 16.12.2021";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MspMain.ResumeLayout(false);
            this.MspMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.GbxTrain.ResumeLayout(false);
            this.GbxWagon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvWagon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BndTrain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MspMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MsiOpen;
        private System.Windows.Forms.ToolStripMenuItem MsiSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MsiExit;
        private System.Windows.Forms.OpenFileDialog OfdMain;
        private System.Windows.Forms.SaveFileDialog SfdMain;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox GbxTrain;
        private System.Windows.Forms.TreeView TrvTrain;
        private System.Windows.Forms.GroupBox GbxWagon;
        private System.Windows.Forms.DataGridView DgvWagon;
        private System.Windows.Forms.BindingSource BndTrain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateTitle;
        private System.Windows.Forms.ImageList ImlTreeView;
    }
}

