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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StsMain = new System.Windows.Forms.StatusStrip();
            this.StiAmount = new System.Windows.Forms.ToolStripStatusLabel();
            this.StiSaveFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.MspMain = new System.Windows.Forms.MenuStrip();
            this.MsiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MsiMainExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiHome = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiHomeCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiHomeEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiControl = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiAddRange = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.MsiAddElem = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiEditElem = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiDeleteElem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.MsiStateOnAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiStateOffAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.MsiStateOnElem = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiStateOffElem = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiOrderBy = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiOrderByTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiOrderByState = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiOrderByPower = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiOrderByPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiSelectionWhere = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiSelectionWhereState = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiSelectionWhereTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiInfoProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MniToTray = new System.Windows.Forms.ToolStripMenuItem();
            this.TspMain = new System.Windows.Forms.ToolStrip();
            this.TsiAddElem = new System.Windows.Forms.ToolStripButton();
            this.TsiDeleteElem = new System.Windows.Forms.ToolStripButton();
            this.TsiEditElem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.TsiTurnOnElem = new System.Windows.Forms.ToolStripButton();
            this.TsiTurnOffElem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.TsiOrderBy = new System.Windows.Forms.ToolStripDropDownButton();
            this.TsiOrderByTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.TsiOrderByState = new System.Windows.Forms.ToolStripMenuItem();
            this.TsiOrderByPower = new System.Windows.Forms.ToolStripMenuItem();
            this.TsiOrderByPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.TsiSelectionWhere = new System.Windows.Forms.ToolStripDropDownButton();
            this.TsiSelectionWhereState = new System.Windows.Forms.ToolStripMenuItem();
            this.TsiSelectionWhereTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.CmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TsiMainToTray = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.CmiMainExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ImlState = new System.Windows.Forms.ImageList(this.components);
            this.TbpMain = new System.Windows.Forms.TabPage();
            this.GbxInfoAppliance = new System.Windows.Forms.GroupBox();
            this.TbxDateTime = new System.Windows.Forms.TextBox();
            this.LblDateTime = new System.Windows.Forms.Label();
            this.TbxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxPower = new System.Windows.Forms.TextBox();
            this.LblPower = new System.Windows.Forms.Label();
            this.TbxTitle = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.TbxState = new System.Windows.Forms.TextBox();
            this.LblState = new System.Windows.Forms.Label();
            this.GbxAppliances = new System.Windows.Forms.GroupBox();
            this.LviAppliances = new System.Windows.Forms.ListView();
            this.LvcStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvcTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvcPower = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvcPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CmsAppliances = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CmiAppliancesAddRange = new System.Windows.Forms.ToolStripMenuItem();
            this.CmiAppliancesClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CmiAppliancesAddElem = new System.Windows.Forms.ToolStripMenuItem();
            this.CmiEditElem = new System.Windows.Forms.ToolStripMenuItem();
            this.CmiAppliancesDeleteElem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CmiAppliancesStateAllOn = new System.Windows.Forms.ToolStripMenuItem();
            this.CmiAppliancesStateAllOff = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.CmiAppliancesStateOnElem = new System.Windows.Forms.ToolStripMenuItem();
            this.CmiAppliancesStateOffElem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripSeparator();
            this.CmiAppliancesOrderBy = new System.Windows.Forms.ToolStripMenuItem();
            this.CmiAppliancesOrderByTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.CmiAppliancesOrderByState = new System.Windows.Forms.ToolStripMenuItem();
            this.CmiAppliancesOrderByPower = new System.Windows.Forms.ToolStripMenuItem();
            this.CmiAppliancesOrderByPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.CmiAppliancesSelectionWhere = new System.Windows.Forms.ToolStripMenuItem();
            this.CmiAppliancesSelectionWhereState = new System.Windows.Forms.ToolStripMenuItem();
            this.CmiAppliancesSelectionWhereTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripSeparator();
            this.CmiAppliancesToTray = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripSeparator();
            this.CmiAppliancesExit = new System.Windows.Forms.ToolStripMenuItem();
            this.GrbHome = new System.Windows.Forms.GroupBox();
            this.CmsHome = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CmiHomeCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.CmiHomeEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.TbxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.TbpOrderBy = new System.Windows.Forms.TabPage();
            this.GbxOrderByParams = new System.Windows.Forms.GroupBox();
            this.CbxOrderBy = new System.Windows.Forms.ComboBox();
            this.lblOrderBy = new System.Windows.Forms.Label();
            this.GbxApplincesOrderBy = new System.Windows.Forms.GroupBox();
            this.LviAppliancesOrderBy = new System.Windows.Forms.ListView();
            this.ClmState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmPower = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TbcMain = new System.Windows.Forms.TabControl();
            this.TbpSelectionBy = new System.Windows.Forms.TabPage();
            this.GbxSelectionParams = new System.Windows.Forms.GroupBox();
            this.CbxSelectionParams = new System.Windows.Forms.ComboBox();
            this.LblParams = new System.Windows.Forms.Label();
            this.CbxSelectionWhere = new System.Windows.Forms.ComboBox();
            this.LblSelectionBy = new System.Windows.Forms.Label();
            this.GbxAppliancesSelectionWhere = new System.Windows.Forms.GroupBox();
            this.LviAppliancesSelection = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SfdAppliances = new System.Windows.Forms.SaveFileDialog();
            this.OfdAppliances = new System.Windows.Forms.OpenFileDialog();
            this.NtiTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.CmsTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CmsTrayFromTray = new System.Windows.Forms.ToolStripMenuItem();
            this.CmsTrayInfoProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.CmsTrayExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.StsMain.SuspendLayout();
            this.MspMain.SuspendLayout();
            this.TspMain.SuspendLayout();
            this.CmsMain.SuspendLayout();
            this.TbpMain.SuspendLayout();
            this.GbxInfoAppliance.SuspendLayout();
            this.GbxAppliances.SuspendLayout();
            this.CmsAppliances.SuspendLayout();
            this.GrbHome.SuspendLayout();
            this.CmsHome.SuspendLayout();
            this.TbpOrderBy.SuspendLayout();
            this.GbxOrderByParams.SuspendLayout();
            this.GbxApplincesOrderBy.SuspendLayout();
            this.TbcMain.SuspendLayout();
            this.TbpSelectionBy.SuspendLayout();
            this.GbxSelectionParams.SuspendLayout();
            this.GbxAppliancesSelectionWhere.SuspendLayout();
            this.CmsTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // StsMain
            // 
            this.StsMain.BackColor = System.Drawing.Color.Gray;
            this.StsMain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StiAmount,
            this.StiSaveFile});
            this.StsMain.Location = new System.Drawing.Point(0, 671);
            this.StsMain.Name = "StsMain";
            this.StsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.StsMain.Size = new System.Drawing.Size(1272, 25);
            this.StsMain.TabIndex = 1;
            // 
            // StiAmount
            // 
            this.StiAmount.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.StiAmount.Name = "StiAmount";
            this.StiAmount.Size = new System.Drawing.Size(172, 20);
            this.StiAmount.Text = "Количество приборов: ";
            this.StiAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StiSaveFile
            // 
            this.StiSaveFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.StiSaveFile.Margin = new System.Windows.Forms.Padding(40, 3, 0, 2);
            this.StiSaveFile.Name = "StiSaveFile";
            this.StiSaveFile.Size = new System.Drawing.Size(1035, 20);
            this.StiSaveFile.Spring = true;
            this.StiSaveFile.Text = "Файл сохранения: ";
            this.StiSaveFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MspMain
            // 
            this.MspMain.BackColor = System.Drawing.Color.DarkGray;
            this.MspMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MspMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MspMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsiFile,
            this.MsiHome,
            this.MsiControl,
            this.MsiOrderBy,
            this.MsiSelectionWhere,
            this.MsiHelp,
            this.MsiSettings});
            this.MspMain.Location = new System.Drawing.Point(0, 0);
            this.MspMain.Name = "MspMain";
            this.MspMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MspMain.Size = new System.Drawing.Size(1272, 40);
            this.MspMain.TabIndex = 2;
            // 
            // MsiFile
            // 
            this.MsiFile.AutoSize = false;
            this.MsiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsiLoad,
            this.MsiSaveAs,
            this.toolStripMenuItem1,
            this.MsiMainExit});
            this.MsiFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MsiFile.Image = global::HomeWork.Properties.Resources.Address_book;
            this.MsiFile.Name = "MsiFile";
            this.MsiFile.Size = new System.Drawing.Size(107, 32);
            this.MsiFile.Text = "&Файл";
            // 
            // MsiLoad
            // 
            this.MsiLoad.AutoSize = false;
            this.MsiLoad.Image = global::HomeWork.Properties.Resources.Folder_Go;
            this.MsiLoad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MsiLoad.Name = "MsiLoad";
            this.MsiLoad.Size = new System.Drawing.Size(225, 38);
            this.MsiLoad.Text = "&Загрузить...";
            this.MsiLoad.Click += new System.EventHandler(this.Load_Command);
            // 
            // MsiSaveAs
            // 
            this.MsiSaveAs.Image = global::HomeWork.Properties.Resources.Folder_Star;
            this.MsiSaveAs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MsiSaveAs.Name = "MsiSaveAs";
            this.MsiSaveAs.Size = new System.Drawing.Size(209, 38);
            this.MsiSaveAs.Text = "&Сохранить как...";
            this.MsiSaveAs.Click += new System.EventHandler(this.SaveAs_Command);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(206, 6);
            // 
            // MsiMainExit
            // 
            this.MsiMainExit.Image = global::HomeWork.Properties.Resources.door_in;
            this.MsiMainExit.Name = "MsiMainExit";
            this.MsiMainExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MsiMainExit.Size = new System.Drawing.Size(209, 38);
            this.MsiMainExit.Text = "&Выход";
            this.MsiMainExit.Click += new System.EventHandler(this.Exit_Command);
            // 
            // MsiHome
            // 
            this.MsiHome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsiHomeCreate,
            this.MsiHomeEdit});
            this.MsiHome.Image = global::HomeWork.Properties.Resources.Home;
            this.MsiHome.Name = "MsiHome";
            this.MsiHome.Size = new System.Drawing.Size(78, 36);
            this.MsiHome.Text = "&Дом";
            // 
            // MsiHomeCreate
            // 
            this.MsiHomeCreate.Image = global::HomeWork.Properties.Resources.Building_Add;
            this.MsiHomeCreate.Name = "MsiHomeCreate";
            this.MsiHomeCreate.Size = new System.Drawing.Size(189, 38);
            this.MsiHomeCreate.Text = "&Создать...";
            this.MsiHomeCreate.Click += new System.EventHandler(this.CreateHome_Command);
            // 
            // MsiHomeEdit
            // 
            this.MsiHomeEdit.Image = global::HomeWork.Properties.Resources.Building_Edit;
            this.MsiHomeEdit.Name = "MsiHomeEdit";
            this.MsiHomeEdit.Size = new System.Drawing.Size(189, 38);
            this.MsiHomeEdit.Text = "Редактировать...";
            this.MsiHomeEdit.Click += new System.EventHandler(this.EditHome_Command);
            // 
            // MsiControl
            // 
            this.MsiControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsiAddRange,
            this.MsiClear,
            this.toolStripMenuItem3,
            this.MsiAddElem,
            this.MsiEditElem,
            this.MsiDeleteElem,
            this.toolStripMenuItem4,
            this.MsiStateOnAll,
            this.MsiStateOffAll,
            this.toolStripMenuItem5,
            this.MsiStateOnElem,
            this.MsiStateOffElem});
            this.MsiControl.Image = global::HomeWork.Properties.Resources.Home_Page;
            this.MsiControl.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MsiControl.Name = "MsiControl";
            this.MsiControl.Size = new System.Drawing.Size(123, 36);
            this.MsiControl.Text = "&Управление";
            // 
            // MsiAddRange
            // 
            this.MsiAddRange.Image = global::HomeWork.Properties.Resources.add_on;
            this.MsiAddRange.Name = "MsiAddRange";
            this.MsiAddRange.Size = new System.Drawing.Size(312, 38);
            this.MsiAddRange.Text = "Добавить &несколько приборов";
            this.MsiAddRange.Click += new System.EventHandler(this.AddRange_Command);
            // 
            // MsiClear
            // 
            this.MsiClear.Image = global::HomeWork.Properties.Resources.after_delete;
            this.MsiClear.Name = "MsiClear";
            this.MsiClear.Size = new System.Drawing.Size(312, 38);
            this.MsiClear.Text = "Удалить &все";
            this.MsiClear.Click += new System.EventHandler(this.Clear_Command);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(309, 6);
            // 
            // MsiAddElem
            // 
            this.MsiAddElem.Image = global::HomeWork.Properties.Resources.computer_add;
            this.MsiAddElem.Name = "MsiAddElem";
            this.MsiAddElem.Size = new System.Drawing.Size(312, 38);
            this.MsiAddElem.Text = "Добавить &прибор...";
            this.MsiAddElem.Click += new System.EventHandler(this.AddElem_Command);
            // 
            // MsiEditElem
            // 
            this.MsiEditElem.Image = global::HomeWork.Properties.Resources.computer_edit;
            this.MsiEditElem.Name = "MsiEditElem";
            this.MsiEditElem.Size = new System.Drawing.Size(312, 38);
            this.MsiEditElem.Text = "&Редактировать выбранный прибор...";
            this.MsiEditElem.Click += new System.EventHandler(this.EditElem_Command);
            // 
            // MsiDeleteElem
            // 
            this.MsiDeleteElem.Image = global::HomeWork.Properties.Resources.computer_delete;
            this.MsiDeleteElem.Name = "MsiDeleteElem";
            this.MsiDeleteElem.Size = new System.Drawing.Size(312, 38);
            this.MsiDeleteElem.Text = "&Удалить выбранный прибор";
            this.MsiDeleteElem.Click += new System.EventHandler(this.DeleteElem_Command);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(309, 6);
            // 
            // MsiStateOnAll
            // 
            this.MsiStateOnAll.Image = global::HomeWork.Properties.Resources.Ball_Green;
            this.MsiStateOnAll.Name = "MsiStateOnAll";
            this.MsiStateOnAll.Size = new System.Drawing.Size(312, 38);
            this.MsiStateOnAll.Text = "&Включить все";
            this.MsiStateOnAll.Click += new System.EventHandler(this.StateOnAll_Command);
            // 
            // MsiStateOffAll
            // 
            this.MsiStateOffAll.Image = global::HomeWork.Properties.Resources.Ball_Red;
            this.MsiStateOffAll.Name = "MsiStateOffAll";
            this.MsiStateOffAll.Size = new System.Drawing.Size(312, 38);
            this.MsiStateOffAll.Text = "В&ыключить все";
            this.MsiStateOffAll.Click += new System.EventHandler(this.StateOffAll_Command);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(309, 6);
            // 
            // MsiStateOnElem
            // 
            this.MsiStateOnElem.Image = global::HomeWork.Properties.Resources.Checkmark;
            this.MsiStateOnElem.Name = "MsiStateOnElem";
            this.MsiStateOnElem.Size = new System.Drawing.Size(312, 38);
            this.MsiStateOnElem.Text = "В&ключить выбранный";
            this.MsiStateOnElem.Click += new System.EventHandler(this.StateOnElem_Command);
            // 
            // MsiStateOffElem
            // 
            this.MsiStateOffElem.Image = global::HomeWork.Properties.Resources.X;
            this.MsiStateOffElem.Name = "MsiStateOffElem";
            this.MsiStateOffElem.Size = new System.Drawing.Size(312, 38);
            this.MsiStateOffElem.Text = "Вык&лючить выбранный";
            this.MsiStateOffElem.Click += new System.EventHandler(this.StateOffElem_Command);
            // 
            // MsiOrderBy
            // 
            this.MsiOrderBy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsiOrderByTitle,
            this.MsiOrderByState,
            this.MsiOrderByPower,
            this.MsiOrderByPrice});
            this.MsiOrderBy.Image = global::HomeWork.Properties.Resources.table_sort_filter;
            this.MsiOrderBy.Name = "MsiOrderBy";
            this.MsiOrderBy.Size = new System.Drawing.Size(124, 36);
            this.MsiOrderBy.Text = "&Сортировка";
            // 
            // MsiOrderByTitle
            // 
            this.MsiOrderByTitle.Image = global::HomeWork.Properties.Resources.word_count;
            this.MsiOrderByTitle.Name = "MsiOrderByTitle";
            this.MsiOrderByTitle.Size = new System.Drawing.Size(209, 38);
            this.MsiOrderByTitle.Text = "По &названию";
            this.MsiOrderByTitle.Click += new System.EventHandler(this.SelectOrderBy_Command);
            // 
            // MsiOrderByState
            // 
            this.MsiOrderByState.Image = global::HomeWork.Properties.Resources.control_power_blue;
            this.MsiOrderByState.Name = "MsiOrderByState";
            this.MsiOrderByState.Size = new System.Drawing.Size(209, 38);
            this.MsiOrderByState.Text = "По &состоянию";
            this.MsiOrderByState.Click += new System.EventHandler(this.SelectOrderBy_Command);
            // 
            // MsiOrderByPower
            // 
            this.MsiOrderByPower.Image = global::HomeWork.Properties.Resources.power_surge;
            this.MsiOrderByPower.Name = "MsiOrderByPower";
            this.MsiOrderByPower.Size = new System.Drawing.Size(209, 38);
            this.MsiOrderByPower.Text = "По &мощности";
            this.MsiOrderByPower.Click += new System.EventHandler(this.SelectOrderBy_Command);
            // 
            // MsiOrderByPrice
            // 
            this.MsiOrderByPrice.Image = global::HomeWork.Properties.Resources.price_alert;
            this.MsiOrderByPrice.Name = "MsiOrderByPrice";
            this.MsiOrderByPrice.Size = new System.Drawing.Size(209, 38);
            this.MsiOrderByPrice.Text = "По убыванию &цены";
            this.MsiOrderByPrice.Click += new System.EventHandler(this.SelectOrderBy_Command);
            // 
            // MsiSelectionWhere
            // 
            this.MsiSelectionWhere.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsiSelectionWhereState,
            this.MsiSelectionWhereTitle});
            this.MsiSelectionWhere.Image = global::HomeWork.Properties.Resources.category_group_select;
            this.MsiSelectionWhere.Name = "MsiSelectionWhere";
            this.MsiSelectionWhere.Size = new System.Drawing.Size(105, 36);
            this.MsiSelectionWhere.Text = "&Выборка";
            // 
            // MsiSelectionWhereState
            // 
            this.MsiSelectionWhereState.Image = global::HomeWork.Properties.Resources.control_power_blue;
            this.MsiSelectionWhereState.Name = "MsiSelectionWhereState";
            this.MsiSelectionWhereState.Size = new System.Drawing.Size(178, 38);
            this.MsiSelectionWhereState.Text = "По &состоянию";
            this.MsiSelectionWhereState.Click += new System.EventHandler(this.SelectSelectionWhere_Command);
            // 
            // MsiSelectionWhereTitle
            // 
            this.MsiSelectionWhereTitle.Image = global::HomeWork.Properties.Resources.word_count;
            this.MsiSelectionWhereTitle.Name = "MsiSelectionWhereTitle";
            this.MsiSelectionWhereTitle.Size = new System.Drawing.Size(178, 38);
            this.MsiSelectionWhereTitle.Text = "По &названию";
            this.MsiSelectionWhereTitle.Click += new System.EventHandler(this.SelectSelectionWhere_Command);
            // 
            // MsiHelp
            // 
            this.MsiHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MsiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsiInfoProgram});
            this.MsiHelp.Image = global::HomeWork.Properties.Resources.help;
            this.MsiHelp.Name = "MsiHelp";
            this.MsiHelp.Size = new System.Drawing.Size(104, 36);
            this.MsiHelp.Text = "&Помощь";
            // 
            // MsiInfoProgram
            // 
            this.MsiInfoProgram.Image = global::HomeWork.Properties.Resources.information;
            this.MsiInfoProgram.Name = "MsiInfoProgram";
            this.MsiInfoProgram.Size = new System.Drawing.Size(174, 38);
            this.MsiInfoProgram.Text = "&О программе";
            this.MsiInfoProgram.Click += new System.EventHandler(this.InfoProgram_Command);
            // 
            // MsiSettings
            // 
            this.MsiSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MniToTray});
            this.MsiSettings.Image = global::HomeWork.Properties.Resources.Gear_In;
            this.MsiSettings.Name = "MsiSettings";
            this.MsiSettings.Size = new System.Drawing.Size(115, 36);
            this.MsiSettings.Text = "&Настройки";
            // 
            // MniToTray
            // 
            this.MniToTray.Image = global::HomeWork.Properties.Resources.Arrow_In;
            this.MniToTray.Name = "MniToTray";
            this.MniToTray.Size = new System.Drawing.Size(130, 38);
            this.MniToTray.Text = "В &трей";
            this.MniToTray.Click += new System.EventHandler(this.ToTray_Command);
            // 
            // TspMain
            // 
            this.TspMain.BackColor = System.Drawing.Color.Gray;
            this.TspMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TspMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.TspMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsiAddElem,
            this.TsiDeleteElem,
            this.TsiEditElem,
            this.toolStripSeparator5,
            this.TsiTurnOnElem,
            this.TsiTurnOffElem,
            this.toolStripSeparator6,
            this.TsiOrderBy,
            this.TsiSelectionWhere});
            this.TspMain.Location = new System.Drawing.Point(0, 40);
            this.TspMain.Name = "TspMain";
            this.TspMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TspMain.Size = new System.Drawing.Size(1272, 39);
            this.TspMain.TabIndex = 3;
            // 
            // TsiAddElem
            // 
            this.TsiAddElem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsiAddElem.Image = global::HomeWork.Properties.Resources.computer_add;
            this.TsiAddElem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsiAddElem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsiAddElem.Name = "TsiAddElem";
            this.TsiAddElem.Size = new System.Drawing.Size(36, 36);
            this.TsiAddElem.Text = "Добавить прибор...";
            this.TsiAddElem.Click += new System.EventHandler(this.AddElem_Command);
            // 
            // TsiDeleteElem
            // 
            this.TsiDeleteElem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsiDeleteElem.Image = global::HomeWork.Properties.Resources.computer_delete;
            this.TsiDeleteElem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsiDeleteElem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsiDeleteElem.Name = "TsiDeleteElem";
            this.TsiDeleteElem.Size = new System.Drawing.Size(36, 36);
            this.TsiDeleteElem.Text = "Удалить выбранный прибор";
            this.TsiDeleteElem.Click += new System.EventHandler(this.DeleteElem_Command);
            // 
            // TsiEditElem
            // 
            this.TsiEditElem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsiEditElem.Image = global::HomeWork.Properties.Resources.computer_edit;
            this.TsiEditElem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsiEditElem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsiEditElem.Name = "TsiEditElem";
            this.TsiEditElem.Size = new System.Drawing.Size(36, 36);
            this.TsiEditElem.Text = "Редактировать выбранный прибор...";
            this.TsiEditElem.Click += new System.EventHandler(this.EditElem_Command);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // TsiTurnOnElem
            // 
            this.TsiTurnOnElem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsiTurnOnElem.Image = global::HomeWork.Properties.Resources.Checkmark;
            this.TsiTurnOnElem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsiTurnOnElem.Name = "TsiTurnOnElem";
            this.TsiTurnOnElem.Size = new System.Drawing.Size(36, 36);
            this.TsiTurnOnElem.Text = "Включить выбранный прибор";
            this.TsiTurnOnElem.Click += new System.EventHandler(this.StateOnElem_Command);
            // 
            // TsiTurnOffElem
            // 
            this.TsiTurnOffElem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsiTurnOffElem.Image = global::HomeWork.Properties.Resources.X;
            this.TsiTurnOffElem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsiTurnOffElem.Name = "TsiTurnOffElem";
            this.TsiTurnOffElem.Size = new System.Drawing.Size(36, 36);
            this.TsiTurnOffElem.Text = "Выключить выбранный прибор";
            this.TsiTurnOffElem.Click += new System.EventHandler(this.StateOffElem_Command);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // TsiOrderBy
            // 
            this.TsiOrderBy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsiOrderBy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsiOrderByTitle,
            this.TsiOrderByState,
            this.TsiOrderByPower,
            this.TsiOrderByPrice});
            this.TsiOrderBy.Image = global::HomeWork.Properties.Resources.table_sort_filter;
            this.TsiOrderBy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsiOrderBy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsiOrderBy.Name = "TsiOrderBy";
            this.TsiOrderBy.Size = new System.Drawing.Size(45, 36);
            this.TsiOrderBy.Text = "Сортировка";
            // 
            // TsiOrderByTitle
            // 
            this.TsiOrderByTitle.Image = global::HomeWork.Properties.Resources.word_count;
            this.TsiOrderByTitle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsiOrderByTitle.Name = "TsiOrderByTitle";
            this.TsiOrderByTitle.Size = new System.Drawing.Size(199, 38);
            this.TsiOrderByTitle.Text = "По &названию";
            this.TsiOrderByTitle.Click += new System.EventHandler(this.SelectOrderBy_Command);
            // 
            // TsiOrderByState
            // 
            this.TsiOrderByState.Image = global::HomeWork.Properties.Resources.control_power_blue;
            this.TsiOrderByState.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsiOrderByState.Name = "TsiOrderByState";
            this.TsiOrderByState.Size = new System.Drawing.Size(199, 38);
            this.TsiOrderByState.Text = "По &состоянию";
            this.TsiOrderByState.Click += new System.EventHandler(this.SelectOrderBy_Command);
            // 
            // TsiOrderByPower
            // 
            this.TsiOrderByPower.Image = global::HomeWork.Properties.Resources.power_surge;
            this.TsiOrderByPower.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsiOrderByPower.Name = "TsiOrderByPower";
            this.TsiOrderByPower.Size = new System.Drawing.Size(199, 38);
            this.TsiOrderByPower.Text = "По &мощности";
            this.TsiOrderByPower.Click += new System.EventHandler(this.SelectOrderBy_Command);
            // 
            // TsiOrderByPrice
            // 
            this.TsiOrderByPrice.Image = global::HomeWork.Properties.Resources.price_alert;
            this.TsiOrderByPrice.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsiOrderByPrice.Name = "TsiOrderByPrice";
            this.TsiOrderByPrice.Size = new System.Drawing.Size(199, 38);
            this.TsiOrderByPrice.Text = "По убыванию &цены";
            this.TsiOrderByPrice.Click += new System.EventHandler(this.SelectOrderBy_Command);
            // 
            // TsiSelectionWhere
            // 
            this.TsiSelectionWhere.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsiSelectionWhere.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsiSelectionWhereState,
            this.TsiSelectionWhereTitle});
            this.TsiSelectionWhere.Image = global::HomeWork.Properties.Resources.category_group_select;
            this.TsiSelectionWhere.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsiSelectionWhere.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsiSelectionWhere.Name = "TsiSelectionWhere";
            this.TsiSelectionWhere.Size = new System.Drawing.Size(45, 36);
            this.TsiSelectionWhere.Text = "Выборка";
            // 
            // TsiSelectionWhereState
            // 
            this.TsiSelectionWhereState.Image = global::HomeWork.Properties.Resources.control_power_blue;
            this.TsiSelectionWhereState.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsiSelectionWhereState.Name = "TsiSelectionWhereState";
            this.TsiSelectionWhereState.Size = new System.Drawing.Size(170, 38);
            this.TsiSelectionWhereState.Text = "По &состоянию";
            this.TsiSelectionWhereState.Click += new System.EventHandler(this.SelectSelectionWhere_Command);
            // 
            // TsiSelectionWhereTitle
            // 
            this.TsiSelectionWhereTitle.Image = global::HomeWork.Properties.Resources.word_count;
            this.TsiSelectionWhereTitle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsiSelectionWhereTitle.Name = "TsiSelectionWhereTitle";
            this.TsiSelectionWhereTitle.Size = new System.Drawing.Size(170, 38);
            this.TsiSelectionWhereTitle.Text = "По &названию";
            this.TsiSelectionWhereTitle.Click += new System.EventHandler(this.SelectSelectionWhere_Command);
            // 
            // CmsMain
            // 
            this.CmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsiMainToTray,
            this.toolStripMenuItem7,
            this.CmiMainExit});
            this.CmsMain.Name = "CmsMain";
            this.CmsMain.Size = new System.Drawing.Size(168, 86);
            // 
            // TsiMainToTray
            // 
            this.TsiMainToTray.Image = global::HomeWork.Properties.Resources.Arrow_In;
            this.TsiMainToTray.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsiMainToTray.Name = "TsiMainToTray";
            this.TsiMainToTray.Size = new System.Drawing.Size(167, 38);
            this.TsiMainToTray.Text = "В &трей";
            this.TsiMainToTray.Click += new System.EventHandler(this.ToTray_Command);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(164, 6);
            // 
            // CmiMainExit
            // 
            this.CmiMainExit.Image = global::HomeWork.Properties.Resources.door_in;
            this.CmiMainExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CmiMainExit.Name = "CmiMainExit";
            this.CmiMainExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.CmiMainExit.Size = new System.Drawing.Size(167, 38);
            this.CmiMainExit.Text = "&Выход";
            this.CmiMainExit.Click += new System.EventHandler(this.Exit_Command);
            // 
            // ImlState
            // 
            this.ImlState.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImlState.ImageStream")));
            this.ImlState.TransparentColor = System.Drawing.Color.Transparent;
            this.ImlState.Images.SetKeyName(0, "X.png");
            this.ImlState.Images.SetKeyName(1, "Checkmark.png");
            // 
            // TbpMain
            // 
            this.TbpMain.BackColor = System.Drawing.Color.DimGray;
            this.TbpMain.Controls.Add(this.GbxInfoAppliance);
            this.TbpMain.Controls.Add(this.GbxAppliances);
            this.TbpMain.Controls.Add(this.GrbHome);
            this.TbpMain.Location = new System.Drawing.Point(4, 25);
            this.TbpMain.Name = "TbpMain";
            this.TbpMain.Padding = new System.Windows.Forms.Padding(3);
            this.TbpMain.Size = new System.Drawing.Size(1264, 563);
            this.TbpMain.TabIndex = 0;
            this.TbpMain.Text = "Главная";
            // 
            // GbxInfoAppliance
            // 
            this.GbxInfoAppliance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxInfoAppliance.Controls.Add(this.TbxDateTime);
            this.GbxInfoAppliance.Controls.Add(this.LblDateTime);
            this.GbxInfoAppliance.Controls.Add(this.TbxPrice);
            this.GbxInfoAppliance.Controls.Add(this.label1);
            this.GbxInfoAppliance.Controls.Add(this.TbxPower);
            this.GbxInfoAppliance.Controls.Add(this.LblPower);
            this.GbxInfoAppliance.Controls.Add(this.TbxTitle);
            this.GbxInfoAppliance.Controls.Add(this.LblTitle);
            this.GbxInfoAppliance.Controls.Add(this.TbxState);
            this.GbxInfoAppliance.Controls.Add(this.LblState);
            this.GbxInfoAppliance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbxInfoAppliance.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxInfoAppliance.ForeColor = System.Drawing.Color.White;
            this.GbxInfoAppliance.Location = new System.Drawing.Point(896, 124);
            this.GbxInfoAppliance.Name = "GbxInfoAppliance";
            this.GbxInfoAppliance.Size = new System.Drawing.Size(352, 432);
            this.GbxInfoAppliance.TabIndex = 6;
            this.GbxInfoAppliance.TabStop = false;
            this.GbxInfoAppliance.Text = " Данные выбранного прибора ";
            // 
            // TbxDateTime
            // 
            this.TbxDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxDateTime.BackColor = System.Drawing.Color.Silver;
            this.TbxDateTime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxDateTime.Location = new System.Drawing.Point(24, 392);
            this.TbxDateTime.Name = "TbxDateTime";
            this.TbxDateTime.ReadOnly = true;
            this.TbxDateTime.Size = new System.Drawing.Size(312, 27);
            this.TbxDateTime.TabIndex = 9;
            this.TbxDateTime.TabStop = false;
            this.TbxDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblDateTime
            // 
            this.LblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDateTime.BackColor = System.Drawing.Color.DarkGray;
            this.LblDateTime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblDateTime.Location = new System.Drawing.Point(24, 352);
            this.LblDateTime.Name = "LblDateTime";
            this.LblDateTime.Size = new System.Drawing.Size(312, 40);
            this.LblDateTime.TabIndex = 8;
            this.LblDateTime.Text = "Последнее изменение состояния";
            this.LblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbxPrice
            // 
            this.TbxPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxPrice.BackColor = System.Drawing.Color.Silver;
            this.TbxPrice.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxPrice.Location = new System.Drawing.Point(24, 312);
            this.TbxPrice.Name = "TbxPrice";
            this.TbxPrice.ReadOnly = true;
            this.TbxPrice.Size = new System.Drawing.Size(312, 27);
            this.TbxPrice.TabIndex = 7;
            this.TbxPrice.TabStop = false;
            this.TbxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Цена";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbxPower
            // 
            this.TbxPower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxPower.BackColor = System.Drawing.Color.Silver;
            this.TbxPower.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxPower.Location = new System.Drawing.Point(24, 232);
            this.TbxPower.Name = "TbxPower";
            this.TbxPower.ReadOnly = true;
            this.TbxPower.Size = new System.Drawing.Size(312, 27);
            this.TbxPower.TabIndex = 5;
            this.TbxPower.TabStop = false;
            this.TbxPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblPower
            // 
            this.LblPower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPower.BackColor = System.Drawing.Color.DarkGray;
            this.LblPower.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPower.Location = new System.Drawing.Point(24, 192);
            this.LblPower.Name = "LblPower";
            this.LblPower.Size = new System.Drawing.Size(312, 40);
            this.LblPower.TabIndex = 4;
            this.LblPower.Text = "Мощность";
            this.LblPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbxTitle
            // 
            this.TbxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxTitle.BackColor = System.Drawing.Color.Silver;
            this.TbxTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxTitle.Location = new System.Drawing.Point(24, 152);
            this.TbxTitle.Name = "TbxTitle";
            this.TbxTitle.ReadOnly = true;
            this.TbxTitle.Size = new System.Drawing.Size(312, 27);
            this.TbxTitle.TabIndex = 3;
            this.TbxTitle.TabStop = false;
            this.TbxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitle.BackColor = System.Drawing.Color.DarkGray;
            this.LblTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTitle.Location = new System.Drawing.Point(24, 112);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(312, 40);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = " Название";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbxState
            // 
            this.TbxState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxState.BackColor = System.Drawing.Color.Silver;
            this.TbxState.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxState.Location = new System.Drawing.Point(24, 72);
            this.TbxState.Name = "TbxState";
            this.TbxState.ReadOnly = true;
            this.TbxState.Size = new System.Drawing.Size(312, 27);
            this.TbxState.TabIndex = 1;
            this.TbxState.TabStop = false;
            this.TbxState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblState
            // 
            this.LblState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblState.BackColor = System.Drawing.Color.DarkGray;
            this.LblState.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblState.Location = new System.Drawing.Point(24, 32);
            this.LblState.Name = "LblState";
            this.LblState.Size = new System.Drawing.Size(312, 40);
            this.LblState.TabIndex = 0;
            this.LblState.Text = " Состояние ";
            this.LblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GbxAppliances
            // 
            this.GbxAppliances.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GbxAppliances.Controls.Add(this.LviAppliances);
            this.GbxAppliances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbxAppliances.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxAppliances.ForeColor = System.Drawing.Color.White;
            this.GbxAppliances.Location = new System.Drawing.Point(16, 8);
            this.GbxAppliances.Name = "GbxAppliances";
            this.GbxAppliances.Size = new System.Drawing.Size(864, 548);
            this.GbxAppliances.TabIndex = 6;
            this.GbxAppliances.TabStop = false;
            this.GbxAppliances.Text = " Устройства ";
            // 
            // LviAppliances
            // 
            this.LviAppliances.AllowDrop = true;
            this.LviAppliances.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LviAppliances.BackColor = System.Drawing.Color.DarkGray;
            this.LviAppliances.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LviAppliances.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LvcStatus,
            this.LvcTitle,
            this.LvcPower,
            this.LvcPrice});
            this.LviAppliances.ContextMenuStrip = this.CmsAppliances;
            this.LviAppliances.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LviAppliances.FullRowSelect = true;
            this.LviAppliances.GridLines = true;
            this.LviAppliances.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LviAppliances.HideSelection = false;
            this.LviAppliances.LargeImageList = this.ImlState;
            this.LviAppliances.Location = new System.Drawing.Point(8, 24);
            this.LviAppliances.MultiSelect = false;
            this.LviAppliances.Name = "LviAppliances";
            this.LviAppliances.Size = new System.Drawing.Size(848, 516);
            this.LviAppliances.SmallImageList = this.ImlState;
            this.LviAppliances.TabIndex = 4;
            this.LviAppliances.UseCompatibleStateImageBehavior = false;
            this.LviAppliances.View = System.Windows.Forms.View.Details;
            this.LviAppliances.SelectedIndexChanged += new System.EventHandler(this.LviAppliances_SelectedIndexChanged);
            this.LviAppliances.DragDrop += new System.Windows.Forms.DragEventHandler(this.LviAppliances_DragDrop);
            this.LviAppliances.DragEnter += new System.Windows.Forms.DragEventHandler(this.LviAppliances_DragEnter);
            this.LviAppliances.DragLeave += new System.EventHandler(this.LviAppliances_DragLeave);
            this.LviAppliances.DoubleClick += new System.EventHandler(this.EditElem_Command);
            // 
            // LvcStatus
            // 
            this.LvcStatus.Text = "Статус";
            this.LvcStatus.Width = 70;
            // 
            // LvcTitle
            // 
            this.LvcTitle.Text = "Название прибора";
            this.LvcTitle.Width = 302;
            // 
            // LvcPower
            // 
            this.LvcPower.Text = "Мощность";
            this.LvcPower.Width = 170;
            // 
            // LvcPrice
            // 
            this.LvcPrice.Text = "Цена";
            this.LvcPrice.Width = 288;
            // 
            // CmsAppliances
            // 
            this.CmsAppliances.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.CmsAppliances.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmiAppliancesAddRange,
            this.CmiAppliancesClear,
            this.toolStripSeparator2,
            this.CmiAppliancesAddElem,
            this.CmiEditElem,
            this.CmiAppliancesDeleteElem,
            this.toolStripSeparator3,
            this.CmiAppliancesStateAllOn,
            this.CmiAppliancesStateAllOff,
            this.toolStripMenuItem8,
            this.CmiAppliancesStateOnElem,
            this.CmiAppliancesStateOffElem,
            this.toolStripMenuItem13,
            this.CmiAppliancesOrderBy,
            this.CmiAppliancesSelectionWhere,
            this.toolStripMenuItem17,
            this.CmiAppliancesToTray,
            this.toolStripMenuItem18,
            this.CmiAppliancesExit});
            this.CmsAppliances.Name = "CmsAppliances";
            this.CmsAppliances.Size = new System.Drawing.Size(293, 534);
            // 
            // CmiAppliancesAddRange
            // 
            this.CmiAppliancesAddRange.Image = global::HomeWork.Properties.Resources.add_on;
            this.CmiAppliancesAddRange.Name = "CmiAppliancesAddRange";
            this.CmiAppliancesAddRange.Size = new System.Drawing.Size(292, 38);
            this.CmiAppliancesAddRange.Text = "Добавить &несколько приборов";
            this.CmiAppliancesAddRange.Click += new System.EventHandler(this.AddRange_Command);
            // 
            // CmiAppliancesClear
            // 
            this.CmiAppliancesClear.Image = global::HomeWork.Properties.Resources.after_delete;
            this.CmiAppliancesClear.Name = "CmiAppliancesClear";
            this.CmiAppliancesClear.Size = new System.Drawing.Size(292, 38);
            this.CmiAppliancesClear.Text = "Удалить &все";
            this.CmiAppliancesClear.Click += new System.EventHandler(this.Clear_Command);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(289, 6);
            // 
            // CmiAppliancesAddElem
            // 
            this.CmiAppliancesAddElem.Image = global::HomeWork.Properties.Resources.computer_add;
            this.CmiAppliancesAddElem.Name = "CmiAppliancesAddElem";
            this.CmiAppliancesAddElem.Size = new System.Drawing.Size(292, 38);
            this.CmiAppliancesAddElem.Text = "Добавить &прибор...";
            this.CmiAppliancesAddElem.Click += new System.EventHandler(this.AddElem_Command);
            // 
            // CmiEditElem
            // 
            this.CmiEditElem.Image = global::HomeWork.Properties.Resources.computer_edit;
            this.CmiEditElem.Name = "CmiEditElem";
            this.CmiEditElem.Size = new System.Drawing.Size(292, 38);
            this.CmiEditElem.Text = "&Редактировать выбранный прибор...";
            this.CmiEditElem.Click += new System.EventHandler(this.EditElem_Command);
            // 
            // CmiAppliancesDeleteElem
            // 
            this.CmiAppliancesDeleteElem.Image = global::HomeWork.Properties.Resources.computer_delete;
            this.CmiAppliancesDeleteElem.Name = "CmiAppliancesDeleteElem";
            this.CmiAppliancesDeleteElem.Size = new System.Drawing.Size(292, 38);
            this.CmiAppliancesDeleteElem.Text = "&Удалить выбранный прибор";
            this.CmiAppliancesDeleteElem.Click += new System.EventHandler(this.DeleteElem_Command);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(289, 6);
            // 
            // CmiAppliancesStateAllOn
            // 
            this.CmiAppliancesStateAllOn.Image = global::HomeWork.Properties.Resources.Ball_Green;
            this.CmiAppliancesStateAllOn.Name = "CmiAppliancesStateAllOn";
            this.CmiAppliancesStateAllOn.Size = new System.Drawing.Size(292, 38);
            this.CmiAppliancesStateAllOn.Text = "&Включить все";
            this.CmiAppliancesStateAllOn.Click += new System.EventHandler(this.StateOnAll_Command);
            // 
            // CmiAppliancesStateAllOff
            // 
            this.CmiAppliancesStateAllOff.Image = global::HomeWork.Properties.Resources.Ball_Red;
            this.CmiAppliancesStateAllOff.Name = "CmiAppliancesStateAllOff";
            this.CmiAppliancesStateAllOff.Size = new System.Drawing.Size(292, 38);
            this.CmiAppliancesStateAllOff.Text = "В&ыключить все";
            this.CmiAppliancesStateAllOff.Click += new System.EventHandler(this.StateOffAll_Command);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(289, 6);
            // 
            // CmiAppliancesStateOnElem
            // 
            this.CmiAppliancesStateOnElem.Image = global::HomeWork.Properties.Resources.Checkmark;
            this.CmiAppliancesStateOnElem.Name = "CmiAppliancesStateOnElem";
            this.CmiAppliancesStateOnElem.Size = new System.Drawing.Size(292, 38);
            this.CmiAppliancesStateOnElem.Text = "В&ключить выбранный";
            this.CmiAppliancesStateOnElem.Click += new System.EventHandler(this.StateOnElem_Command);
            // 
            // CmiAppliancesStateOffElem
            // 
            this.CmiAppliancesStateOffElem.Image = global::HomeWork.Properties.Resources.X;
            this.CmiAppliancesStateOffElem.Name = "CmiAppliancesStateOffElem";
            this.CmiAppliancesStateOffElem.Size = new System.Drawing.Size(292, 38);
            this.CmiAppliancesStateOffElem.Text = "Вык&лючить выбранный";
            this.CmiAppliancesStateOffElem.Click += new System.EventHandler(this.StateOffElem_Command);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(289, 6);
            // 
            // CmiAppliancesOrderBy
            // 
            this.CmiAppliancesOrderBy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmiAppliancesOrderByTitle,
            this.CmiAppliancesOrderByState,
            this.CmiAppliancesOrderByPower,
            this.CmiAppliancesOrderByPrice});
            this.CmiAppliancesOrderBy.Image = global::HomeWork.Properties.Resources.table_sort_filter;
            this.CmiAppliancesOrderBy.Name = "CmiAppliancesOrderBy";
            this.CmiAppliancesOrderBy.Size = new System.Drawing.Size(292, 38);
            this.CmiAppliancesOrderBy.Text = "&Сортировка";
            // 
            // CmiAppliancesOrderByTitle
            // 
            this.CmiAppliancesOrderByTitle.Image = global::HomeWork.Properties.Resources.word_count;
            this.CmiAppliancesOrderByTitle.Name = "CmiAppliancesOrderByTitle";
            this.CmiAppliancesOrderByTitle.Size = new System.Drawing.Size(183, 22);
            this.CmiAppliancesOrderByTitle.Text = "По &названию";
            this.CmiAppliancesOrderByTitle.Click += new System.EventHandler(this.SelectOrderBy_Command);
            // 
            // CmiAppliancesOrderByState
            // 
            this.CmiAppliancesOrderByState.Image = global::HomeWork.Properties.Resources.control_power_blue;
            this.CmiAppliancesOrderByState.Name = "CmiAppliancesOrderByState";
            this.CmiAppliancesOrderByState.Size = new System.Drawing.Size(183, 22);
            this.CmiAppliancesOrderByState.Text = "По &состоянию";
            this.CmiAppliancesOrderByState.Click += new System.EventHandler(this.SelectOrderBy_Command);
            // 
            // CmiAppliancesOrderByPower
            // 
            this.CmiAppliancesOrderByPower.Image = global::HomeWork.Properties.Resources.power_surge;
            this.CmiAppliancesOrderByPower.Name = "CmiAppliancesOrderByPower";
            this.CmiAppliancesOrderByPower.Size = new System.Drawing.Size(183, 22);
            this.CmiAppliancesOrderByPower.Text = "По &мощности";
            this.CmiAppliancesOrderByPower.Click += new System.EventHandler(this.SelectOrderBy_Command);
            // 
            // CmiAppliancesOrderByPrice
            // 
            this.CmiAppliancesOrderByPrice.Image = global::HomeWork.Properties.Resources.price_alert;
            this.CmiAppliancesOrderByPrice.Name = "CmiAppliancesOrderByPrice";
            this.CmiAppliancesOrderByPrice.Size = new System.Drawing.Size(183, 22);
            this.CmiAppliancesOrderByPrice.Text = "По убыванию &цены";
            this.CmiAppliancesOrderByPrice.Click += new System.EventHandler(this.SelectOrderBy_Command);
            // 
            // CmiAppliancesSelectionWhere
            // 
            this.CmiAppliancesSelectionWhere.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmiAppliancesSelectionWhereState,
            this.CmiAppliancesSelectionWhereTitle});
            this.CmiAppliancesSelectionWhere.Image = global::HomeWork.Properties.Resources.category_group_select;
            this.CmiAppliancesSelectionWhere.Name = "CmiAppliancesSelectionWhere";
            this.CmiAppliancesSelectionWhere.Size = new System.Drawing.Size(292, 38);
            this.CmiAppliancesSelectionWhere.Text = "&Выборка";
            // 
            // CmiAppliancesSelectionWhereState
            // 
            this.CmiAppliancesSelectionWhereState.Image = global::HomeWork.Properties.Resources.control_power_blue;
            this.CmiAppliancesSelectionWhereState.Name = "CmiAppliancesSelectionWhereState";
            this.CmiAppliancesSelectionWhereState.Size = new System.Drawing.Size(154, 22);
            this.CmiAppliancesSelectionWhereState.Text = "По &состоянию";
            this.CmiAppliancesSelectionWhereState.Click += new System.EventHandler(this.SelectSelectionWhere_Command);
            // 
            // CmiAppliancesSelectionWhereTitle
            // 
            this.CmiAppliancesSelectionWhereTitle.Image = global::HomeWork.Properties.Resources.word_count;
            this.CmiAppliancesSelectionWhereTitle.Name = "CmiAppliancesSelectionWhereTitle";
            this.CmiAppliancesSelectionWhereTitle.Size = new System.Drawing.Size(154, 22);
            this.CmiAppliancesSelectionWhereTitle.Text = "По &названию";
            this.CmiAppliancesSelectionWhereTitle.Click += new System.EventHandler(this.SelectSelectionWhere_Command);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(289, 6);
            // 
            // CmiAppliancesToTray
            // 
            this.CmiAppliancesToTray.Image = global::HomeWork.Properties.Resources.Arrow_In;
            this.CmiAppliancesToTray.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CmiAppliancesToTray.Name = "CmiAppliancesToTray";
            this.CmiAppliancesToTray.Size = new System.Drawing.Size(292, 38);
            this.CmiAppliancesToTray.Text = "В &трей";
            this.CmiAppliancesToTray.Click += new System.EventHandler(this.ToTray_Command);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(289, 6);
            // 
            // CmiAppliancesExit
            // 
            this.CmiAppliancesExit.Image = global::HomeWork.Properties.Resources.door_in;
            this.CmiAppliancesExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CmiAppliancesExit.Name = "CmiAppliancesExit";
            this.CmiAppliancesExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.CmiAppliancesExit.Size = new System.Drawing.Size(292, 38);
            this.CmiAppliancesExit.Text = "&Выход";
            this.CmiAppliancesExit.Click += new System.EventHandler(this.Exit_Command);
            // 
            // GrbHome
            // 
            this.GrbHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrbHome.ContextMenuStrip = this.CmsHome;
            this.GrbHome.Controls.Add(this.TbxAddress);
            this.GrbHome.Controls.Add(this.lblAddress);
            this.GrbHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrbHome.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GrbHome.ForeColor = System.Drawing.Color.White;
            this.GrbHome.Location = new System.Drawing.Point(896, 8);
            this.GrbHome.Name = "GrbHome";
            this.GrbHome.Size = new System.Drawing.Size(352, 112);
            this.GrbHome.TabIndex = 5;
            this.GrbHome.TabStop = false;
            this.GrbHome.Text = " Данные дома ";
            // 
            // CmsHome
            // 
            this.CmsHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmiHomeCreate,
            this.CmiHomeEdit,
            this.toolStripSeparator1,
            this.toolStripMenuItem6,
            this.toolStripSeparator4,
            this.toolStripMenuItem9});
            this.CmsHome.Name = "CmsMain";
            this.CmsHome.Size = new System.Drawing.Size(180, 168);
            // 
            // CmiHomeCreate
            // 
            this.CmiHomeCreate.Image = global::HomeWork.Properties.Resources.Building_Add;
            this.CmiHomeCreate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CmiHomeCreate.Name = "CmiHomeCreate";
            this.CmiHomeCreate.Size = new System.Drawing.Size(179, 38);
            this.CmiHomeCreate.Text = "&Создать...";
            this.CmiHomeCreate.Click += new System.EventHandler(this.CreateHome_Command);
            // 
            // CmiHomeEdit
            // 
            this.CmiHomeEdit.Image = global::HomeWork.Properties.Resources.Building_Edit;
            this.CmiHomeEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CmiHomeEdit.Name = "CmiHomeEdit";
            this.CmiHomeEdit.Size = new System.Drawing.Size(179, 38);
            this.CmiHomeEdit.Text = "Редактировать...";
            this.CmiHomeEdit.Click += new System.EventHandler(this.EditHome_Command);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(176, 6);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Image = global::HomeWork.Properties.Resources.Arrow_In;
            this.toolStripMenuItem6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(179, 38);
            this.toolStripMenuItem6.Text = "В &трей";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(176, 6);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Image = global::HomeWork.Properties.Resources.door_in;
            this.toolStripMenuItem9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.toolStripMenuItem9.Size = new System.Drawing.Size(179, 38);
            this.toolStripMenuItem9.Text = "&Выход";
            // 
            // TbxAddress
            // 
            this.TbxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxAddress.BackColor = System.Drawing.Color.Silver;
            this.TbxAddress.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxAddress.Location = new System.Drawing.Point(24, 72);
            this.TbxAddress.Name = "TbxAddress";
            this.TbxAddress.ReadOnly = true;
            this.TbxAddress.Size = new System.Drawing.Size(312, 27);
            this.TbxAddress.TabIndex = 1;
            this.TbxAddress.TabStop = false;
            this.TbxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.BackColor = System.Drawing.Color.DarkGray;
            this.lblAddress.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddress.Location = new System.Drawing.Point(24, 32);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(312, 40);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = " Адрес дома ";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbpOrderBy
            // 
            this.TbpOrderBy.BackColor = System.Drawing.Color.DimGray;
            this.TbpOrderBy.Controls.Add(this.GbxOrderByParams);
            this.TbpOrderBy.Controls.Add(this.GbxApplincesOrderBy);
            this.TbpOrderBy.Location = new System.Drawing.Point(4, 25);
            this.TbpOrderBy.Name = "TbpOrderBy";
            this.TbpOrderBy.Padding = new System.Windows.Forms.Padding(3);
            this.TbpOrderBy.Size = new System.Drawing.Size(1264, 563);
            this.TbpOrderBy.TabIndex = 1;
            this.TbpOrderBy.Text = "Сортировка";
            // 
            // GbxOrderByParams
            // 
            this.GbxOrderByParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxOrderByParams.Controls.Add(this.CbxOrderBy);
            this.GbxOrderByParams.Controls.Add(this.lblOrderBy);
            this.GbxOrderByParams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbxOrderByParams.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxOrderByParams.ForeColor = System.Drawing.Color.White;
            this.GbxOrderByParams.Location = new System.Drawing.Point(896, 8);
            this.GbxOrderByParams.Name = "GbxOrderByParams";
            this.GbxOrderByParams.Size = new System.Drawing.Size(352, 120);
            this.GbxOrderByParams.TabIndex = 8;
            this.GbxOrderByParams.TabStop = false;
            this.GbxOrderByParams.Text = " Параметры сортировки ";
            // 
            // CbxOrderBy
            // 
            this.CbxOrderBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxOrderBy.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbxOrderBy.FormattingEnabled = true;
            this.CbxOrderBy.Items.AddRange(new object[] {
            "По названию",
            "По состоянию",
            "По мощности",
            "По убыванию цены"});
            this.CbxOrderBy.Location = new System.Drawing.Point(24, 72);
            this.CbxOrderBy.Name = "CbxOrderBy";
            this.CbxOrderBy.Size = new System.Drawing.Size(312, 26);
            this.CbxOrderBy.TabIndex = 9;
            this.CbxOrderBy.SelectedIndexChanged += new System.EventHandler(this.OrderBy_Command);
            // 
            // lblOrderBy
            // 
            this.lblOrderBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderBy.BackColor = System.Drawing.Color.DarkGray;
            this.lblOrderBy.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderBy.Location = new System.Drawing.Point(24, 32);
            this.lblOrderBy.Name = "lblOrderBy";
            this.lblOrderBy.Size = new System.Drawing.Size(312, 40);
            this.lblOrderBy.TabIndex = 0;
            this.lblOrderBy.Text = " Вид сортировки";
            this.lblOrderBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GbxApplincesOrderBy
            // 
            this.GbxApplincesOrderBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GbxApplincesOrderBy.Controls.Add(this.LviAppliancesOrderBy);
            this.GbxApplincesOrderBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbxApplincesOrderBy.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxApplincesOrderBy.ForeColor = System.Drawing.Color.White;
            this.GbxApplincesOrderBy.Location = new System.Drawing.Point(16, 8);
            this.GbxApplincesOrderBy.Name = "GbxApplincesOrderBy";
            this.GbxApplincesOrderBy.Size = new System.Drawing.Size(864, 566);
            this.GbxApplincesOrderBy.TabIndex = 7;
            this.GbxApplincesOrderBy.TabStop = false;
            this.GbxApplincesOrderBy.Text = " Устройства ";
            // 
            // LviAppliancesOrderBy
            // 
            this.LviAppliancesOrderBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LviAppliancesOrderBy.BackColor = System.Drawing.Color.DarkGray;
            this.LviAppliancesOrderBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LviAppliancesOrderBy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClmState,
            this.ClmTitle,
            this.ClmPower,
            this.ClmPrice});
            this.LviAppliancesOrderBy.ContextMenuStrip = this.CmsAppliances;
            this.LviAppliancesOrderBy.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LviAppliancesOrderBy.FullRowSelect = true;
            this.LviAppliancesOrderBy.GridLines = true;
            this.LviAppliancesOrderBy.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LviAppliancesOrderBy.HideSelection = false;
            this.LviAppliancesOrderBy.LargeImageList = this.ImlState;
            this.LviAppliancesOrderBy.Location = new System.Drawing.Point(8, 24);
            this.LviAppliancesOrderBy.MultiSelect = false;
            this.LviAppliancesOrderBy.Name = "LviAppliancesOrderBy";
            this.LviAppliancesOrderBy.Size = new System.Drawing.Size(848, 534);
            this.LviAppliancesOrderBy.SmallImageList = this.ImlState;
            this.LviAppliancesOrderBy.TabIndex = 4;
            this.LviAppliancesOrderBy.UseCompatibleStateImageBehavior = false;
            this.LviAppliancesOrderBy.View = System.Windows.Forms.View.Details;
            // 
            // ClmState
            // 
            this.ClmState.Text = "Статус";
            this.ClmState.Width = 70;
            // 
            // ClmTitle
            // 
            this.ClmTitle.Text = "Название прибора";
            this.ClmTitle.Width = 302;
            // 
            // ClmPower
            // 
            this.ClmPower.Text = "Мощность";
            this.ClmPower.Width = 170;
            // 
            // ClmPrice
            // 
            this.ClmPrice.Text = "Цена";
            this.ClmPrice.Width = 288;
            // 
            // TbcMain
            // 
            this.TbcMain.Controls.Add(this.TbpMain);
            this.TbcMain.Controls.Add(this.TbpOrderBy);
            this.TbcMain.Controls.Add(this.TbpSelectionBy);
            this.TbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbcMain.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbcMain.Location = new System.Drawing.Point(0, 79);
            this.TbcMain.Name = "TbcMain";
            this.TbcMain.SelectedIndex = 0;
            this.TbcMain.Size = new System.Drawing.Size(1272, 592);
            this.TbcMain.TabIndex = 1;
            this.TbcMain.SelectedIndexChanged += new System.EventHandler(this.TbcMain_SelectedIndexChanged);
            // 
            // TbpSelectionBy
            // 
            this.TbpSelectionBy.BackColor = System.Drawing.Color.DimGray;
            this.TbpSelectionBy.Controls.Add(this.GbxSelectionParams);
            this.TbpSelectionBy.Controls.Add(this.GbxAppliancesSelectionWhere);
            this.TbpSelectionBy.Location = new System.Drawing.Point(4, 25);
            this.TbpSelectionBy.Name = "TbpSelectionBy";
            this.TbpSelectionBy.Padding = new System.Windows.Forms.Padding(3);
            this.TbpSelectionBy.Size = new System.Drawing.Size(1264, 563);
            this.TbpSelectionBy.TabIndex = 2;
            this.TbpSelectionBy.Text = "Выборка";
            // 
            // GbxSelectionParams
            // 
            this.GbxSelectionParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxSelectionParams.Controls.Add(this.CbxSelectionParams);
            this.GbxSelectionParams.Controls.Add(this.LblParams);
            this.GbxSelectionParams.Controls.Add(this.CbxSelectionWhere);
            this.GbxSelectionParams.Controls.Add(this.LblSelectionBy);
            this.GbxSelectionParams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbxSelectionParams.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxSelectionParams.ForeColor = System.Drawing.Color.White;
            this.GbxSelectionParams.Location = new System.Drawing.Point(896, 7);
            this.GbxSelectionParams.Name = "GbxSelectionParams";
            this.GbxSelectionParams.Size = new System.Drawing.Size(352, 201);
            this.GbxSelectionParams.TabIndex = 10;
            this.GbxSelectionParams.TabStop = false;
            this.GbxSelectionParams.Text = " Параметры выборки ";
            // 
            // CbxSelectionParams
            // 
            this.CbxSelectionParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxSelectionParams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxSelectionParams.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbxSelectionParams.FormattingEnabled = true;
            this.CbxSelectionParams.Items.AddRange(new object[] {
            "По названию",
            "По состоянию",
            "По мощности",
            "По убыванию цены"});
            this.CbxSelectionParams.Location = new System.Drawing.Point(24, 152);
            this.CbxSelectionParams.Name = "CbxSelectionParams";
            this.CbxSelectionParams.Size = new System.Drawing.Size(312, 26);
            this.CbxSelectionParams.TabIndex = 11;
            this.CbxSelectionParams.SelectedIndexChanged += new System.EventHandler(this.SelectionWhere_Command);
            // 
            // LblParams
            // 
            this.LblParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblParams.BackColor = System.Drawing.Color.DarkGray;
            this.LblParams.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblParams.Location = new System.Drawing.Point(24, 112);
            this.LblParams.Name = "LblParams";
            this.LblParams.Size = new System.Drawing.Size(312, 40);
            this.LblParams.TabIndex = 10;
            this.LblParams.Text = "Выбор параметра";
            this.LblParams.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CbxSelectionWhere
            // 
            this.CbxSelectionWhere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxSelectionWhere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxSelectionWhere.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbxSelectionWhere.FormattingEnabled = true;
            this.CbxSelectionWhere.Items.AddRange(new object[] {
            "По названию",
            "По состоянию"});
            this.CbxSelectionWhere.Location = new System.Drawing.Point(24, 72);
            this.CbxSelectionWhere.Name = "CbxSelectionWhere";
            this.CbxSelectionWhere.Size = new System.Drawing.Size(312, 26);
            this.CbxSelectionWhere.TabIndex = 9;
            this.CbxSelectionWhere.SelectedIndexChanged += new System.EventHandler(this.SelectionWhereTypeSelect_Command);
            // 
            // LblSelectionBy
            // 
            this.LblSelectionBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSelectionBy.BackColor = System.Drawing.Color.DarkGray;
            this.LblSelectionBy.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSelectionBy.Location = new System.Drawing.Point(24, 32);
            this.LblSelectionBy.Name = "LblSelectionBy";
            this.LblSelectionBy.Size = new System.Drawing.Size(312, 40);
            this.LblSelectionBy.TabIndex = 0;
            this.LblSelectionBy.Text = "Выборка по";
            this.LblSelectionBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GbxAppliancesSelectionWhere
            // 
            this.GbxAppliancesSelectionWhere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GbxAppliancesSelectionWhere.Controls.Add(this.LviAppliancesSelection);
            this.GbxAppliancesSelectionWhere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbxAppliancesSelectionWhere.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxAppliancesSelectionWhere.ForeColor = System.Drawing.Color.White;
            this.GbxAppliancesSelectionWhere.Location = new System.Drawing.Point(16, 7);
            this.GbxAppliancesSelectionWhere.Name = "GbxAppliancesSelectionWhere";
            this.GbxAppliancesSelectionWhere.Size = new System.Drawing.Size(864, 566);
            this.GbxAppliancesSelectionWhere.TabIndex = 9;
            this.GbxAppliancesSelectionWhere.TabStop = false;
            this.GbxAppliancesSelectionWhere.Text = " Устройства ";
            // 
            // LviAppliancesSelection
            // 
            this.LviAppliancesSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LviAppliancesSelection.BackColor = System.Drawing.Color.DarkGray;
            this.LviAppliancesSelection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LviAppliancesSelection.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LviAppliancesSelection.ContextMenuStrip = this.CmsAppliances;
            this.LviAppliancesSelection.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LviAppliancesSelection.FullRowSelect = true;
            this.LviAppliancesSelection.GridLines = true;
            this.LviAppliancesSelection.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LviAppliancesSelection.HideSelection = false;
            this.LviAppliancesSelection.LargeImageList = this.ImlState;
            this.LviAppliancesSelection.Location = new System.Drawing.Point(8, 24);
            this.LviAppliancesSelection.MultiSelect = false;
            this.LviAppliancesSelection.Name = "LviAppliancesSelection";
            this.LviAppliancesSelection.Size = new System.Drawing.Size(848, 534);
            this.LviAppliancesSelection.SmallImageList = this.ImlState;
            this.LviAppliancesSelection.TabIndex = 4;
            this.LviAppliancesSelection.UseCompatibleStateImageBehavior = false;
            this.LviAppliancesSelection.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Статус";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название прибора";
            this.columnHeader2.Width = 302;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Мощность";
            this.columnHeader3.Width = 170;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Цена";
            this.columnHeader4.Width = 288;
            // 
            // SfdAppliances
            // 
            this.SfdAppliances.CheckFileExists = true;
            this.SfdAppliances.DefaultExt = "json";
            this.SfdAppliances.FileName = "appliances.json";
            this.SfdAppliances.Filter = "Файл данных JSON (*.JSON) |*.json| Все файлы (*.*) | *.*";
            this.SfdAppliances.InitialDirectory = "*\\App_Data";
            this.SfdAppliances.OverwritePrompt = false;
            this.SfdAppliances.RestoreDirectory = true;
            this.SfdAppliances.SupportMultiDottedExtensions = true;
            this.SfdAppliances.ValidateNames = false;
            // 
            // OfdAppliances
            // 
            this.OfdAppliances.DefaultExt = "json";
            this.OfdAppliances.FileName = "appliances.json";
            this.OfdAppliances.Filter = "Файл данных JSON (*.JSON) |*.json| Все файлы (*.*) | *.*";
            this.OfdAppliances.InitialDirectory = "*\\App_Data";
            this.OfdAppliances.ReadOnlyChecked = true;
            this.OfdAppliances.RestoreDirectory = true;
            // 
            // NtiTray
            // 
            this.NtiTray.ContextMenuStrip = this.CmsTray;
            this.NtiTray.Icon = ((System.Drawing.Icon)(resources.GetObject("NtiTray.Icon")));
            this.NtiTray.Text = "Умный дом";
            // 
            // CmsTray
            // 
            this.CmsTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmsTrayFromTray,
            this.CmsTrayInfoProgram,
            this.CmsTrayExit});
            this.CmsTray.Name = "CmsTray";
            this.CmsTray.Size = new System.Drawing.Size(166, 118);
            // 
            // CmsTrayFromTray
            // 
            this.CmsTrayFromTray.Image = global::HomeWork.Properties.Resources.arrow_out;
            this.CmsTrayFromTray.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CmsTrayFromTray.Name = "CmsTrayFromTray";
            this.CmsTrayFromTray.Size = new System.Drawing.Size(165, 38);
            this.CmsTrayFromTray.Text = "Восстановить";
            this.CmsTrayFromTray.Click += new System.EventHandler(this.FromTray_Command);
            // 
            // CmsTrayInfoProgram
            // 
            this.CmsTrayInfoProgram.Image = global::HomeWork.Properties.Resources.information;
            this.CmsTrayInfoProgram.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CmsTrayInfoProgram.Name = "CmsTrayInfoProgram";
            this.CmsTrayInfoProgram.Size = new System.Drawing.Size(165, 38);
            this.CmsTrayInfoProgram.Text = "О программе";
            this.CmsTrayInfoProgram.Click += new System.EventHandler(this.InfoProgram_Command);
            // 
            // CmsTrayExit
            // 
            this.CmsTrayExit.Image = global::HomeWork.Properties.Resources.door_in;
            this.CmsTrayExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CmsTrayExit.Name = "CmsTrayExit";
            this.CmsTrayExit.Size = new System.Drawing.Size(165, 38);
            this.CmsTrayExit.Text = "Завершить";
            this.CmsTrayExit.Click += new System.EventHandler(this.Exit_Command);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Image = global::HomeWork.Properties.Resources.add_on;
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(261, 38);
            this.toolStripMenuItem15.Text = "Добавить &несколько приборов";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1272, 696);
            this.ContextMenuStrip = this.CmsMain;
            this.Controls.Add(this.TbcMain);
            this.Controls.Add(this.TspMain);
            this.Controls.Add(this.StsMain);
            this.Controls.Add(this.MspMain);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MspMain;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1288, 726);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Домашнее задание на 06.12.2021";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.DragLeave += new System.EventHandler(this.MainForm_DragLeave);
            this.StsMain.ResumeLayout(false);
            this.StsMain.PerformLayout();
            this.MspMain.ResumeLayout(false);
            this.MspMain.PerformLayout();
            this.TspMain.ResumeLayout(false);
            this.TspMain.PerformLayout();
            this.CmsMain.ResumeLayout(false);
            this.TbpMain.ResumeLayout(false);
            this.GbxInfoAppliance.ResumeLayout(false);
            this.GbxInfoAppliance.PerformLayout();
            this.GbxAppliances.ResumeLayout(false);
            this.CmsAppliances.ResumeLayout(false);
            this.GrbHome.ResumeLayout(false);
            this.GrbHome.PerformLayout();
            this.CmsHome.ResumeLayout(false);
            this.TbpOrderBy.ResumeLayout(false);
            this.GbxOrderByParams.ResumeLayout(false);
            this.GbxApplincesOrderBy.ResumeLayout(false);
            this.TbcMain.ResumeLayout(false);
            this.TbpSelectionBy.ResumeLayout(false);
            this.GbxSelectionParams.ResumeLayout(false);
            this.GbxAppliancesSelectionWhere.ResumeLayout(false);
            this.CmsTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip StsMain;
        private System.Windows.Forms.MenuStrip MspMain;
        private System.Windows.Forms.ToolStripMenuItem MsiFile;
        private System.Windows.Forms.ToolStripMenuItem MsiMainExit;
        private System.Windows.Forms.ToolStrip TspMain;
        private System.Windows.Forms.ContextMenuStrip CmsMain;
        private System.Windows.Forms.ToolStripMenuItem CmiMainExit;
        private System.Windows.Forms.ImageList ImlState;
        private System.Windows.Forms.ToolStripStatusLabel StiAmount;
        private System.Windows.Forms.TabPage TbpMain;
        private System.Windows.Forms.GroupBox GbxInfoAppliance;
        private System.Windows.Forms.TextBox TbxDateTime;
        private System.Windows.Forms.Label LblDateTime;
        private System.Windows.Forms.TextBox TbxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxPower;
        private System.Windows.Forms.Label LblPower;
        private System.Windows.Forms.TextBox TbxTitle;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox TbxState;
        private System.Windows.Forms.Label LblState;
        private System.Windows.Forms.GroupBox GbxAppliances;
        private System.Windows.Forms.ListView LviAppliances;
        private System.Windows.Forms.ColumnHeader LvcStatus;
        private System.Windows.Forms.ColumnHeader LvcTitle;
        private System.Windows.Forms.ColumnHeader LvcPower;
        private System.Windows.Forms.ColumnHeader LvcPrice;
        private System.Windows.Forms.GroupBox GrbHome;
        private System.Windows.Forms.TextBox TbxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TabPage TbpOrderBy;
        private System.Windows.Forms.TabControl TbcMain;
        private System.Windows.Forms.GroupBox GbxApplincesOrderBy;
        private System.Windows.Forms.ListView LviAppliancesOrderBy;
        private System.Windows.Forms.ColumnHeader ClmState;
        private System.Windows.Forms.ColumnHeader ClmTitle;
        private System.Windows.Forms.ColumnHeader ClmPower;
        private System.Windows.Forms.ColumnHeader ClmPrice;
        private System.Windows.Forms.GroupBox GbxOrderByParams;
        private System.Windows.Forms.Label lblOrderBy;
        private System.Windows.Forms.ComboBox CbxOrderBy;
        private System.Windows.Forms.TabPage TbpSelectionBy;
        private System.Windows.Forms.GroupBox GbxSelectionParams;
        private System.Windows.Forms.ComboBox CbxSelectionWhere;
        private System.Windows.Forms.Label LblSelectionBy;
        private System.Windows.Forms.GroupBox GbxAppliancesSelectionWhere;
        private System.Windows.Forms.ListView LviAppliancesSelection;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox CbxSelectionParams;
        private System.Windows.Forms.Label LblParams;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip CmsAppliances;
        private System.Windows.Forms.ToolStripMenuItem CmiAppliancesExit;
        private System.Windows.Forms.ToolStripMenuItem MsiLoad;
        private System.Windows.Forms.ToolStripMenuItem MsiSaveAs;
        private System.Windows.Forms.SaveFileDialog SfdAppliances;
        private System.Windows.Forms.OpenFileDialog OfdAppliances;
        private System.Windows.Forms.ToolStripMenuItem MsiOrderBy;
        private System.Windows.Forms.ToolStripMenuItem MsiSelectionWhere;
        private System.Windows.Forms.ToolStripMenuItem MsiControl;
        private System.Windows.Forms.ToolStripMenuItem MsiAddRange;
        private System.Windows.Forms.ToolStripMenuItem MsiAddElem;
        private System.Windows.Forms.ToolStripMenuItem MsiDeleteElem;
        private System.Windows.Forms.ToolStripMenuItem MsiClear;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem MsiOrderByTitle;
        private System.Windows.Forms.ToolStripMenuItem MsiOrderByState;
        private System.Windows.Forms.ToolStripMenuItem MsiOrderByPower;
        private System.Windows.Forms.ToolStripMenuItem MsiOrderByPrice;
        private System.Windows.Forms.ToolStripMenuItem MsiSelectionWhereState;
        private System.Windows.Forms.ToolStripMenuItem MsiSelectionWhereTitle;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem MsiStateOnAll;
        private System.Windows.Forms.ToolStripMenuItem MsiStateOffAll;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem MsiStateOnElem;
        private System.Windows.Forms.ToolStripMenuItem MsiStateOffElem;
        private System.Windows.Forms.ToolStripMenuItem MsiHelp;
        private System.Windows.Forms.ToolStripMenuItem MsiInfoProgram;
        private System.Windows.Forms.ToolStripMenuItem MsiSettings;
        private System.Windows.Forms.ToolStripMenuItem MniToTray;
        private System.Windows.Forms.NotifyIcon NtiTray;
        private System.Windows.Forms.ContextMenuStrip CmsTray;
        private System.Windows.Forms.ToolStripMenuItem CmsTrayFromTray;
        private System.Windows.Forms.ToolStripMenuItem CmsTrayExit;
        private System.Windows.Forms.ToolStripMenuItem CmsTrayInfoProgram;
        private System.Windows.Forms.ToolStripMenuItem TsiMainToTray;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem CmiAppliancesToTray;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem CmiAppliancesAddRange;
        private System.Windows.Forms.ToolStripMenuItem CmiAppliancesClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem CmiAppliancesDeleteElem;
        private System.Windows.Forms.ToolStripMenuItem CmiAppliancesAddElem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem CmiAppliancesStateAllOn;
        private System.Windows.Forms.ToolStripMenuItem CmiAppliancesStateAllOff;
        private System.Windows.Forms.ToolStripMenuItem CmiAppliancesStateOnElem;
        private System.Windows.Forms.ToolStripMenuItem CmiAppliancesStateOffElem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem17;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem CmiAppliancesOrderBy;
        private System.Windows.Forms.ToolStripMenuItem CmiAppliancesOrderByTitle;
        private System.Windows.Forms.ToolStripMenuItem CmiAppliancesOrderByState;
        private System.Windows.Forms.ToolStripMenuItem CmiAppliancesOrderByPower;
        private System.Windows.Forms.ToolStripMenuItem CmiAppliancesOrderByPrice;
        private System.Windows.Forms.ToolStripMenuItem CmiAppliancesSelectionWhere;
        private System.Windows.Forms.ToolStripMenuItem CmiAppliancesSelectionWhereState;
        private System.Windows.Forms.ToolStripMenuItem CmiAppliancesSelectionWhereTitle;
        private System.Windows.Forms.ToolStripMenuItem MsiEditElem;
        private System.Windows.Forms.ToolStripMenuItem CmiEditElem;
        private System.Windows.Forms.ToolStripMenuItem MsiHome;
        private System.Windows.Forms.ToolStripMenuItem MsiHomeCreate;
        private System.Windows.Forms.ToolStripMenuItem MsiHomeEdit;
        private System.Windows.Forms.ContextMenuStrip CmsHome;
        private System.Windows.Forms.ToolStripMenuItem CmiHomeCreate;
        private System.Windows.Forms.ToolStripMenuItem CmiHomeEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripButton TsiAddElem;
        private System.Windows.Forms.ToolStripButton TsiDeleteElem;
        private System.Windows.Forms.ToolStripButton TsiEditElem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripDropDownButton TsiOrderBy;
        private System.Windows.Forms.ToolStripDropDownButton TsiSelectionWhere;
        private System.Windows.Forms.ToolStripMenuItem TsiOrderByTitle;
        private System.Windows.Forms.ToolStripMenuItem TsiOrderByState;
        private System.Windows.Forms.ToolStripMenuItem TsiOrderByPower;
        private System.Windows.Forms.ToolStripMenuItem TsiOrderByPrice;
        private System.Windows.Forms.ToolStripMenuItem TsiSelectionWhereTitle;
        private System.Windows.Forms.ToolStripMenuItem TsiSelectionWhereState;
        private System.Windows.Forms.ToolStripButton TsiTurnOnElem;
        private System.Windows.Forms.ToolStripButton TsiTurnOffElem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripStatusLabel StiSaveFile;
    }
}

