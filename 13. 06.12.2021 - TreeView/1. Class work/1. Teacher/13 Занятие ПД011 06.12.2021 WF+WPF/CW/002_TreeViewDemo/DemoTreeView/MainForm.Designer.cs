namespace DemoTreeView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Узел2");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Корень1", new System.Windows.Forms.TreeNode[] {
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Узел1");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Узел2");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Узел3");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Запросы к таблице Абитуриентов", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32,
            treeNode33});
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Узел1");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Узел5");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Узел4", new System.Windows.Forms.TreeNode[] {
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Узел3", new System.Windows.Forms.TreeNode[] {
            treeNode37});
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Узел7");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Узел8");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Узел2", new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode39,
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Узел10");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Узел9", new System.Windows.Forms.TreeNode[] {
            treeNode42});
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Корень3", new System.Windows.Forms.TreeNode[] {
            treeNode35,
            treeNode41,
            treeNode43});
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Корень4");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Подветвь1 Ветвь1");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Подветвь2 Ветвь1");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Ветвь1", new System.Windows.Forms.TreeNode[] {
            treeNode46,
            treeNode47});
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Ветвь2");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Ветвь3");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Корень5", new System.Windows.Forms.TreeNode[] {
            treeNode48,
            treeNode49,
            treeNode50});
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Иванов И.Л.");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("42в");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Автобус АР888О", new System.Windows.Forms.TreeNode[] {
            treeNode52,
            treeNode53});
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Автобус АР775О");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Автобаза", new System.Windows.Forms.TreeNode[] {
            treeNode54,
            treeNode55});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MnsMain = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTree = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAddNode = new System.Windows.Forms.ToolStripMenuItem();
            this.mniREmoveNode = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExpandAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCollapseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.окноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьForm1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StsMain = new System.Windows.Forms.StatusStrip();
            this.TslNodeText = new System.Windows.Forms.ToolStripStatusLabel();
            this.TstMain = new System.Windows.Forms.ToolStrip();
            this.tsbAddNode = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoveNode = new System.Windows.Forms.ToolStripButton();
            this.tsbGenerate = new System.Windows.Forms.ToolStripButton();
            this.tsbSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TrvMain = new System.Windows.Forms.TreeView();
            this.CmnTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiAddNode = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiRemoveNode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.развернутьВсеУзлыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CmiTreeNodeEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ImlMain = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.LsvLog = new System.Windows.Forms.ListView();
            this.CmnToolStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьУзелToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьУзелToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnsMain.SuspendLayout();
            this.StsMain.SuspendLayout();
            this.TstMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.CmnTree.SuspendLayout();
            this.CmnToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnsMain
            // 
            this.MnsMain.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.MnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.mniTree,
            this.mniHelp,
            this.toolStripMenuItem4,
            this.окноToolStripMenuItem});
            this.MnsMain.Location = new System.Drawing.Point(0, 0);
            this.MnsMain.Name = "MnsMain";
            this.MnsMain.Size = new System.Drawing.Size(883, 28);
            this.MnsMain.TabIndex = 0;
            this.MnsMain.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.toolStripMenuItem1,
            this.загрузитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.toolStripMenuItem2,
            this.mniExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.новыйToolStripMenuItem.Text = "Новый";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Image = global::DemoTreeView.Properties.Resources.data_table;
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.Load_Command);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = global::DemoTreeView.Properties.Resources.save_data;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.Save_Command);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // mniExit
            // 
            this.mniExit.Image = global::DemoTreeView.Properties.Resources.door_out;
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 24);
            this.mniExit.Text = "Выход";
            this.mniExit.Click += new System.EventHandler(this.MniExit_Click);
            this.mniExit.MouseHover += new System.EventHandler(this.MniExit_MouseHover);
            // 
            // mniTree
            // 
            this.mniTree.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniAddNode,
            this.mniREmoveNode,
            this.mniExpandAll,
            this.mniCollapseAll});
            this.mniTree.Name = "mniTree";
            this.mniTree.Size = new System.Drawing.Size(73, 24);
            this.mniTree.Text = "Дерево";
            // 
            // mniAddNode
            // 
            this.mniAddNode.Image = global::DemoTreeView.Properties.Resources.add;
            this.mniAddNode.Name = "mniAddNode";
            this.mniAddNode.Size = new System.Drawing.Size(220, 24);
            this.mniAddNode.Text = "Добавить узел";
            this.mniAddNode.Click += new System.EventHandler(this.MniAddNode_Click);
            // 
            // mniREmoveNode
            // 
            this.mniREmoveNode.Image = global::DemoTreeView.Properties.Resources.delete;
            this.mniREmoveNode.Name = "mniREmoveNode";
            this.mniREmoveNode.Size = new System.Drawing.Size(220, 24);
            this.mniREmoveNode.Text = "Удалить узел";
            this.mniREmoveNode.Click += new System.EventHandler(this.MniRemoveNode_Click);
            // 
            // mniExpandAll
            // 
            this.mniExpandAll.Name = "mniExpandAll";
            this.mniExpandAll.Size = new System.Drawing.Size(220, 24);
            this.mniExpandAll.Text = "Развернуть все узлы";
            this.mniExpandAll.Click += new System.EventHandler(this.MniExpandAll_Click);
            // 
            // mniCollapseAll
            // 
            this.mniCollapseAll.Name = "mniCollapseAll";
            this.mniCollapseAll.Size = new System.Drawing.Size(220, 24);
            this.mniCollapseAll.Text = "Свернуть все узлы";
            this.mniCollapseAll.Click += new System.EventHandler(this.MniCollapseAll_Click);
            // 
            // mniHelp
            // 
            this.mniHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniAbout});
            this.mniHelp.Name = "mniHelp";
            this.mniHelp.Size = new System.Drawing.Size(79, 24);
            this.mniHelp.Text = "Справка";
            // 
            // mniAbout
            // 
            this.mniAbout.Name = "mniAbout";
            this.mniAbout.Size = new System.Drawing.Size(173, 24);
            this.mniAbout.Text = "О программе";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(12, 24);
            // 
            // окноToolStripMenuItem
            // 
            this.окноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьForm1ToolStripMenuItem});
            this.окноToolStripMenuItem.Name = "окноToolStripMenuItem";
            this.окноToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.окноToolStripMenuItem.Text = "Окно";
            // 
            // открытьForm1ToolStripMenuItem
            // 
            this.открытьForm1ToolStripMenuItem.Name = "открытьForm1ToolStripMenuItem";
            this.открытьForm1ToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.открытьForm1ToolStripMenuItem.Text = "Открыть Form1...";
            this.открытьForm1ToolStripMenuItem.Click += new System.EventHandler(this.OpenForm1_Command);
            // 
            // StsMain
            // 
            this.StsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TslNodeText});
            this.StsMain.Location = new System.Drawing.Point(0, 408);
            this.StsMain.Name = "StsMain";
            this.StsMain.Size = new System.Drawing.Size(883, 22);
            this.StsMain.TabIndex = 1;
            this.StsMain.Text = "statusStrip1";
            // 
            // TslNodeText
            // 
            this.TslNodeText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TslNodeText.Name = "TslNodeText";
            this.TslNodeText.Size = new System.Drawing.Size(868, 17);
            this.TslNodeText.Spring = true;
            this.TslNodeText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TstMain
            // 
            this.TstMain.AutoSize = false;
            this.TstMain.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.TstMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.TstMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddNode,
            this.tsbRemoveNode,
            this.tsbGenerate,
            this.tsbSep1,
            this.tsbExit});
            this.TstMain.Location = new System.Drawing.Point(0, 28);
            this.TstMain.Name = "TstMain";
            this.TstMain.Size = new System.Drawing.Size(883, 44);
            this.TstMain.TabIndex = 2;
            this.TstMain.Text = "toolStrip1";
            // 
            // tsbAddNode
            // 
            this.tsbAddNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddNode.Image = global::DemoTreeView.Properties.Resources.add;
            this.tsbAddNode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddNode.Name = "tsbAddNode";
            this.tsbAddNode.Size = new System.Drawing.Size(36, 41);
            this.tsbAddNode.Text = "Добавить";
            this.tsbAddNode.ToolTipText = "Добавить узел ";
            this.tsbAddNode.Click += new System.EventHandler(this.MniAddNode_Click);
            // 
            // tsbRemoveNode
            // 
            this.tsbRemoveNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemoveNode.Image = global::DemoTreeView.Properties.Resources.delete;
            this.tsbRemoveNode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveNode.Name = "tsbRemoveNode";
            this.tsbRemoveNode.Size = new System.Drawing.Size(36, 41);
            this.tsbRemoveNode.Text = "Удалить";
            this.tsbRemoveNode.ToolTipText = "Удалить узел";
            this.tsbRemoveNode.Click += new System.EventHandler(this.MniRemoveNode_Click);
            // 
            // tsbGenerate
            // 
            this.tsbGenerate.Image = global::DemoTreeView.Properties.Resources.control_play_blue;
            this.tsbGenerate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGenerate.Name = "tsbGenerate";
            this.tsbGenerate.Size = new System.Drawing.Size(151, 41);
            this.tsbGenerate.Text = "Сгенерировать";
            this.tsbGenerate.ToolTipText = "Сгенерировать дерево в коде";
            this.tsbGenerate.Click += new System.EventHandler(this.TsbGenerate_Click);
            // 
            // tsbSep1
            // 
            this.tsbSep1.AutoSize = false;
            this.tsbSep1.Name = "tsbSep1";
            this.tsbSep1.Size = new System.Drawing.Size(30, 25);
            // 
            // tsbExit
            // 
            this.tsbExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExit.Image = global::DemoTreeView.Properties.Resources.door_out;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(36, 41);
            this.tsbExit.Text = "Выход";
            this.tsbExit.ToolTipText = "Выход из приложения";
            this.tsbExit.Click += new System.EventHandler(this.MniExit_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 72);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TrvMain);
            this.splitContainer1.Panel1.Controls.Add(this.splitter1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.LsvLog);
            this.splitContainer1.Size = new System.Drawing.Size(883, 336);
            this.splitContainer1.SplitterDistance = 316;
            this.splitContainer1.TabIndex = 3;
            // 
            // TrvMain
            // 
            this.TrvMain.ContextMenuStrip = this.CmnTree;
            this.TrvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrvMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrvMain.ImageIndex = 0;
            this.TrvMain.ImageList = this.ImlMain;
            this.TrvMain.LabelEdit = true;
            this.TrvMain.Location = new System.Drawing.Point(3, 0);
            this.TrvMain.Name = "TrvMain";
            treeNode29.Name = "Узел2";
            treeNode29.Text = "Узел2";
            treeNode30.Name = "Узел1";
            treeNode30.Text = "Корень1";
            treeNode30.ToolTipText = "Корень дерева";
            treeNode31.Name = "Узел1";
            treeNode31.Text = "Узел1";
            treeNode32.Name = "Узел2";
            treeNode32.Text = "Узел2";
            treeNode33.Name = "Узел3";
            treeNode33.Text = "Узел3";
            treeNode34.Name = "Узел0";
            treeNode34.Text = "Запросы к таблице Абитуриентов";
            treeNode35.Name = "Узел1";
            treeNode35.Text = "Узел1";
            treeNode36.Name = "Узел5";
            treeNode36.Text = "Узел5";
            treeNode37.Name = "Узел4";
            treeNode37.Text = "Узел4";
            treeNode38.Name = "Узел3";
            treeNode38.Text = "Узел3";
            treeNode39.Name = "Узел7";
            treeNode39.Text = "Узел7";
            treeNode40.Name = "Узел8";
            treeNode40.Text = "Узел8";
            treeNode41.Name = "Узел2";
            treeNode41.Text = "Узел2";
            treeNode42.Name = "Узел10";
            treeNode42.Text = "Узел10";
            treeNode43.Name = "Узел9";
            treeNode43.Text = "Узел9";
            treeNode44.Name = "Узел0";
            treeNode44.Text = "Корень3";
            treeNode45.Name = "Узел6";
            treeNode45.Text = "Корень4";
            treeNode46.Name = "Узел15";
            treeNode46.Text = "Подветвь1 Ветвь1";
            treeNode47.Name = "Узел16";
            treeNode47.Text = "Подветвь2 Ветвь1";
            treeNode48.Name = "Узел12";
            treeNode48.Text = "Ветвь1";
            treeNode49.Name = "Узел13";
            treeNode49.Text = "Ветвь2";
            treeNode50.Name = "Узел14";
            treeNode50.Text = "Ветвь3";
            treeNode51.Name = "Узел11";
            treeNode51.Text = "Корень5";
            treeNode52.Name = "Узел4";
            treeNode52.Text = "Иванов И.Л.";
            treeNode53.Name = "Узел5";
            treeNode53.Text = "42в";
            treeNode54.Name = "Узел3";
            treeNode54.Text = "Автобус АР888О";
            treeNode55.Name = "Узел6";
            treeNode55.Text = "Автобус АР775О";
            treeNode56.Name = "Узел2";
            treeNode56.Text = "Автобаза";
            this.TrvMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode30,
            treeNode34,
            treeNode44,
            treeNode45,
            treeNode51,
            treeNode56});
            this.TrvMain.SelectedImageIndex = 1;
            this.TrvMain.ShowNodeToolTips = true;
            this.TrvMain.Size = new System.Drawing.Size(313, 336);
            this.TrvMain.TabIndex = 1;
            this.TrvMain.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.TrvMain_AfterLabelEdit);
            this.TrvMain.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TrvMain_NodeMouseClick);
            this.TrvMain.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TrvMain_NodeMouseDoubleClick);
            this.TrvMain.Click += new System.EventHandler(this.TrvMain_Click);
            this.TrvMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trvMain_MouseClick);
            this.TrvMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trvMain_MouseDoubleClick);
            // 
            // CmnTree
            // 
            this.CmnTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiAddNode,
            this.cmiRemoveNode,
            this.toolStripMenuItem3,
            this.развернутьВсеУзлыToolStripMenuItem,
            this.CmiTreeNodeEdit});
            this.CmnTree.Name = "cmnTree";
            this.CmnTree.Size = new System.Drawing.Size(187, 98);
            // 
            // cmiAddNode
            // 
            this.cmiAddNode.Image = global::DemoTreeView.Properties.Resources.add;
            this.cmiAddNode.Name = "cmiAddNode";
            this.cmiAddNode.Size = new System.Drawing.Size(186, 22);
            this.cmiAddNode.Text = "Добавить узел";
            this.cmiAddNode.Click += new System.EventHandler(this.MniAddNode_Click);
            // 
            // cmiRemoveNode
            // 
            this.cmiRemoveNode.Image = global::DemoTreeView.Properties.Resources.delete;
            this.cmiRemoveNode.Name = "cmiRemoveNode";
            this.cmiRemoveNode.Size = new System.Drawing.Size(186, 22);
            this.cmiRemoveNode.Text = "Удалить узел";
            this.cmiRemoveNode.Click += new System.EventHandler(this.MniRemoveNode_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(183, 6);
            // 
            // развернутьВсеУзлыToolStripMenuItem
            // 
            this.развернутьВсеУзлыToolStripMenuItem.Name = "развернутьВсеУзлыToolStripMenuItem";
            this.развернутьВсеУзлыToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.развернутьВсеУзлыToolStripMenuItem.Text = "Развернуть все узлы";
            this.развернутьВсеУзлыToolStripMenuItem.Click += new System.EventHandler(this.MniExpandAll_Click);
            // 
            // CmiTreeNodeEdit
            // 
            this.CmiTreeNodeEdit.Name = "CmiTreeNodeEdit";
            this.CmiTreeNodeEdit.Size = new System.Drawing.Size(186, 22);
            this.CmiTreeNodeEdit.Text = "Редактировать узел";
            this.CmiTreeNodeEdit.Click += new System.EventHandler(this.NodeEdit_Command);
            // 
            // ImlMain
            // 
            this.ImlMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImlMain.ImageStream")));
            this.ImlMain.TransparentColor = System.Drawing.Color.Transparent;
            this.ImlMain.Images.SetKeyName(0, "folder_blue.ico");
            this.ImlMain.Images.SetKeyName(1, "open_folder.ico");
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 336);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // LsvLog
            // 
            this.LsvLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LsvLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LsvLog.HideSelection = false;
            this.LsvLog.Location = new System.Drawing.Point(0, 0);
            this.LsvLog.Name = "LsvLog";
            this.LsvLog.Size = new System.Drawing.Size(563, 336);
            this.LsvLog.TabIndex = 0;
            this.LsvLog.UseCompatibleStateImageBehavior = false;
            this.LsvLog.View = System.Windows.Forms.View.List;
            // 
            // CmnToolStrip
            // 
            this.CmnToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьУзелToolStripMenuItem,
            this.удалитьУзелToolStripMenuItem});
            this.CmnToolStrip.Name = "contextMenuStrip1";
            this.CmnToolStrip.Size = new System.Drawing.Size(154, 48);
            // 
            // добавитьУзелToolStripMenuItem
            // 
            this.добавитьУзелToolStripMenuItem.Name = "добавитьУзелToolStripMenuItem";
            this.добавитьУзелToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.добавитьУзелToolStripMenuItem.Text = "Добавить узел";
            this.добавитьУзелToolStripMenuItem.Click += new System.EventHandler(this.MniAddNode_Click);
            // 
            // удалитьУзелToolStripMenuItem
            // 
            this.удалитьУзелToolStripMenuItem.Name = "удалитьУзелToolStripMenuItem";
            this.удалитьУзелToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.удалитьУзелToolStripMenuItem.Text = "Удалить узел";
            this.удалитьУзелToolStripMenuItem.Click += new System.EventHandler(this.MniRemoveNode_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 430);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.TstMain);
            this.Controls.Add(this.StsMain);
            this.Controls.Add(this.MnsMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MnsMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Занятие 06.12.2021 - Работа с элементом TreeView";
            this.MnsMain.ResumeLayout(false);
            this.MnsMain.PerformLayout();
            this.StsMain.ResumeLayout(false);
            this.StsMain.PerformLayout();
            this.TstMain.ResumeLayout(false);
            this.TstMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.CmnTree.ResumeLayout(false);
            this.CmnToolStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnsMain;
        private System.Windows.Forms.StatusStrip StsMain;
        private System.Windows.Forms.ToolStrip TstMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView TrvMain;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListView LsvLog;
        private System.Windows.Forms.ImageList ImlMain;
        private System.Windows.Forms.ToolStripMenuItem mniTree;
        private System.Windows.Forms.ToolStripMenuItem mniAddNode;
        private System.Windows.Forms.ToolStripMenuItem mniREmoveNode;
        private System.Windows.Forms.ToolStripMenuItem mniHelp;
        private System.Windows.Forms.ToolStripButton tsbAddNode;
        private System.Windows.Forms.ToolStripButton tsbRemoveNode;
        private System.Windows.Forms.ToolStripSeparator tsbSep1;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ContextMenuStrip CmnTree;
        private System.Windows.Forms.ToolStripMenuItem mniAbout;
        private System.Windows.Forms.ToolStripMenuItem cmiAddNode;
        private System.Windows.Forms.ToolStripMenuItem cmiRemoveNode;
        private System.Windows.Forms.ToolStripMenuItem mniExpandAll;
        private System.Windows.Forms.ToolStripMenuItem mniCollapseAll;
        private System.Windows.Forms.ToolStripButton tsbGenerate;
        private System.Windows.Forms.ContextMenuStrip CmnToolStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьУзелToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьУзелToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem развернутьВсеУзлыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem окноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьForm1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CmiTreeNodeEdit;
        private System.Windows.Forms.ToolStripStatusLabel TslNodeText;
    }
}

