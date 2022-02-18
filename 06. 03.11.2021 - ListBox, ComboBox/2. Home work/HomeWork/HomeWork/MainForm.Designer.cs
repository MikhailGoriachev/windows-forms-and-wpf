namespace HomeWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MspMainMenu = new System.Windows.Forms.MenuStrip();
            this.MniFigure = new System.Windows.Forms.ToolStripMenuItem();
            this.MniConoid = new System.Windows.Forms.ToolStripMenuItem();
            this.MniSphere = new System.Windows.Forms.ToolStripMenuItem();
            this.MniCylinder = new System.Windows.Forms.ToolStripMenuItem();
            this.MniParallelepiped = new System.Windows.Forms.ToolStripMenuItem();
            this.журналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MniViewHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.MniClear = new System.Windows.Forms.ToolStripMenuItem();
            this.MniHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MniInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TbxHistory = new System.Windows.Forms.TextBox();
            this.LblHistory = new System.Windows.Forms.Label();
            this.MniLists = new System.Windows.Forms.ToolStripMenuItem();
            this.MspMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MspMainMenu
            // 
            this.MspMainMenu.BackColor = System.Drawing.Color.Silver;
            this.MspMainMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MspMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MniFigure,
            this.журналToolStripMenuItem,
            this.MniLists,
            this.MniHelp});
            this.MspMainMenu.Location = new System.Drawing.Point(0, 0);
            this.MspMainMenu.Name = "MspMainMenu";
            this.MspMainMenu.Size = new System.Drawing.Size(800, 29);
            this.MspMainMenu.TabIndex = 0;
            this.MspMainMenu.Text = "menuStrip1";
            // 
            // MniFigure
            // 
            this.MniFigure.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MniConoid,
            this.MniSphere,
            this.MniCylinder,
            this.MniParallelepiped});
            this.MniFigure.Name = "MniFigure";
            this.MniFigure.Size = new System.Drawing.Size(134, 25);
            this.MniFigure.Text = "&Объёмные тела";
            // 
            // MniConoid
            // 
            this.MniConoid.Image = ((System.Drawing.Image)(resources.GetObject("MniConoid.Image")));
            this.MniConoid.Name = "MniConoid";
            this.MniConoid.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.MniConoid.Size = new System.Drawing.Size(268, 26);
            this.MniConoid.Text = "&Усеченный конус...";
            this.MniConoid.Click += new System.EventHandler(this.MniFigure_Click);
            // 
            // MniSphere
            // 
            this.MniSphere.Image = ((System.Drawing.Image)(resources.GetObject("MniSphere.Image")));
            this.MniSphere.Name = "MniSphere";
            this.MniSphere.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.MniSphere.Size = new System.Drawing.Size(268, 26);
            this.MniSphere.Text = "&Сфера...";
            this.MniSphere.Click += new System.EventHandler(this.MniFigure_Click);
            // 
            // MniCylinder
            // 
            this.MniCylinder.Image = ((System.Drawing.Image)(resources.GetObject("MniCylinder.Image")));
            this.MniCylinder.Name = "MniCylinder";
            this.MniCylinder.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.MniCylinder.Size = new System.Drawing.Size(268, 26);
            this.MniCylinder.Text = "&Цилиндр...";
            this.MniCylinder.Click += new System.EventHandler(this.MniFigure_Click);
            // 
            // MniParallelepiped
            // 
            this.MniParallelepiped.Image = ((System.Drawing.Image)(resources.GetObject("MniParallelepiped.Image")));
            this.MniParallelepiped.Name = "MniParallelepiped";
            this.MniParallelepiped.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.MniParallelepiped.Size = new System.Drawing.Size(268, 26);
            this.MniParallelepiped.Text = "&Параллелепипед...";
            this.MniParallelepiped.Click += new System.EventHandler(this.MniFigure_Click);
            // 
            // журналToolStripMenuItem
            // 
            this.журналToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MniViewHistory,
            this.MniClear});
            this.журналToolStripMenuItem.Name = "журналToolStripMenuItem";
            this.журналToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.журналToolStripMenuItem.Text = "&Журнал";
            // 
            // MniViewHistory
            // 
            this.MniViewHistory.Name = "MniViewHistory";
            this.MniViewHistory.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MniViewHistory.Size = new System.Drawing.Size(219, 26);
            this.MniViewHistory.Text = "&Просмотр...";
            this.MniViewHistory.Click += new System.EventHandler(this.MniViewHistory_Click);
            // 
            // MniClear
            // 
            this.MniClear.Name = "MniClear";
            this.MniClear.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.MniClear.Size = new System.Drawing.Size(219, 26);
            this.MniClear.Text = "&Очистка";
            this.MniClear.Click += new System.EventHandler(this.MniClear_Click);
            // 
            // MniHelp
            // 
            this.MniHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MniInfo});
            this.MniHelp.Name = "MniHelp";
            this.MniHelp.Size = new System.Drawing.Size(83, 25);
            this.MniHelp.Text = "&Помощь";
            // 
            // MniInfo
            // 
            this.MniInfo.Name = "MniInfo";
            this.MniInfo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.MniInfo.Size = new System.Drawing.Size(242, 26);
            this.MniInfo.Text = "&О программе...";
            this.MniInfo.Click += new System.EventHandler(this.MniInfo_Click);
            // 
            // TbxHistory
            // 
            this.TbxHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxHistory.BackColor = System.Drawing.Color.DarkGray;
            this.TbxHistory.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxHistory.Location = new System.Drawing.Point(32, 88);
            this.TbxHistory.Multiline = true;
            this.TbxHistory.Name = "TbxHistory";
            this.TbxHistory.ReadOnly = true;
            this.TbxHistory.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbxHistory.Size = new System.Drawing.Size(736, 352);
            this.TbxHistory.TabIndex = 1;
            this.TbxHistory.TabStop = false;
            this.TbxHistory.WordWrap = false;
            // 
            // LblHistory
            // 
            this.LblHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblHistory.BackColor = System.Drawing.Color.Gray;
            this.LblHistory.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblHistory.ForeColor = System.Drawing.Color.White;
            this.LblHistory.Location = new System.Drawing.Point(264, 39);
            this.LblHistory.Name = "LblHistory";
            this.LblHistory.Size = new System.Drawing.Size(272, 40);
            this.LblHistory.TabIndex = 2;
            this.LblHistory.Text = "Журнал";
            this.LblHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MniLists
            // 
            this.MniLists.Name = "MniLists";
            this.MniLists.Size = new System.Drawing.Size(83, 25);
            this.MniLists.Text = "&Списки...";
            this.MniLists.Click += new System.EventHandler(this.MniLists_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblHistory);
            this.Controls.Add(this.TbxHistory);
            this.Controls.Add(this.MspMainMenu);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.MspMainMenu;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.Text = "Домашнее задание на 08.11.2021";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MspMainMenu.ResumeLayout(false);
            this.MspMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MspMainMenu;
        private System.Windows.Forms.ToolStripMenuItem MniFigure;
        private System.Windows.Forms.ToolStripMenuItem MniConoid;
        private System.Windows.Forms.ToolStripMenuItem MniSphere;
        private System.Windows.Forms.ToolStripMenuItem MniCylinder;
        private System.Windows.Forms.ToolStripMenuItem MniParallelepiped;
        private System.Windows.Forms.ToolStripMenuItem MniHelp;
        private System.Windows.Forms.ToolStripMenuItem MniInfo;
        private System.Windows.Forms.ToolStripMenuItem журналToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MniClear;
        private System.Windows.Forms.ToolStripMenuItem MniViewHistory;
        private System.Windows.Forms.TextBox TbxHistory;
        private System.Windows.Forms.Label LblHistory;
        private System.Windows.Forms.ToolStripMenuItem MniLists;
    }
}

