
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MspMain = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MsiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiControl = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiInitialization = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MsiAddSleeper = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiAddCorridor = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiAddReserved = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.MsiClear = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiInfoProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiOrderBy = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiOrderBySellDesc = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiOrderByNumberWagonAsc = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiOrderByNumberWagonDesc = new System.Windows.Forms.ToolStripMenuItem();
            this.CmsTviTrain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CmiTviTrainAddSleeper = new System.Windows.Forms.ToolStripMenuItem();
            this.CmiTviTrainAddCorridor = new System.Windows.Forms.ToolStripMenuItem();
            this.CmiTviTrainAddReserved = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.CmiTviTrainClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CmiTviTrainBySellDesc = new System.Windows.Forms.ToolStripMenuItem();
            this.CmiTviTrainByNumberWagonAsc = new System.Windows.Forms.ToolStripMenuItem();
            this.CmiTviTrainByNumberWagonDesc = new System.Windows.Forms.ToolStripMenuItem();
            this.StsMain = new System.Windows.Forms.StatusStrip();
            this.StiAmountWagons = new System.Windows.Forms.ToolStripStatusLabel();
            this.StiAmountSeats = new System.Windows.Forms.ToolStripStatusLabel();
            this.StiSleeper = new System.Windows.Forms.ToolStripStatusLabel();
            this.StiCorridor = new System.Windows.Forms.ToolStripStatusLabel();
            this.StiReserved = new System.Windows.Forms.ToolStripStatusLabel();
            this.TspMain = new System.Windows.Forms.ToolStrip();
            this.TsiAddWagon = new System.Windows.Forms.ToolStripDropDownButton();
            this.TsiAddSleeper = new System.Windows.Forms.ToolStripMenuItem();
            this.TsiAddCorridor = new System.Windows.Forms.ToolStripMenuItem();
            this.TsiAddReserved = new System.Windows.Forms.ToolStripMenuItem();
            this.TsiBtnDeleteWagon = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TsiCmbOrderBy = new System.Windows.Forms.ToolStripComboBox();
            this.TsiBtnOrderBy = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TsiExit = new System.Windows.Forms.ToolStripButton();
            this.OfdMain = new System.Windows.Forms.OpenFileDialog();
            this.SfdMain = new System.Windows.Forms.SaveFileDialog();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GbxTrain = new System.Windows.Forms.GroupBox();
            this.TviTrain = new System.Windows.Forms.TreeView();
            this.ImlTreeView = new System.Windows.Forms.ImageList(this.components);
            this.GbxWagon = new System.Windows.Forms.GroupBox();
            this.DgvWagon = new System.Windows.Forms.DataGridView();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberSeatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoCoupeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoWagonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmsDgvSeat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CmiDgvSeatSell = new System.Windows.Forms.ToolStripMenuItem();
            this.CmiDgvSeatBack = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.CmiDgvSeatRemoveWagon = new System.Windows.Forms.ToolStripMenuItem();
            this.BndTrain = new System.Windows.Forms.BindingSource(this.components);
            this.CmsTviWagon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CmiTviWagonDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.CmiTviWagonBySellDesc = new System.Windows.Forms.ToolStripMenuItem();
            this.CmiTviWagonByNumberWagonAsc = new System.Windows.Forms.ToolStripMenuItem();
            this.CmiTviWagonByNumberWagonDesc = new System.Windows.Forms.ToolStripMenuItem();
            this.CmsTviSeat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CmiTviSeatSell = new System.Windows.Forms.ToolStripMenuItem();
            this.CmiTviSeatBack = new System.Windows.Forms.ToolStripMenuItem();
            this.CmsTviCoupe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CmiTviCoupeSellAll = new System.Windows.Forms.ToolStripMenuItem();
            this.CmiTviCoupeBackAll = new System.Windows.Forms.ToolStripMenuItem();
            this.CmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CmiMainInfoProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.CmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MspMain.SuspendLayout();
            this.CmsTviTrain.SuspendLayout();
            this.StsMain.SuspendLayout();
            this.TspMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.GbxTrain.SuspendLayout();
            this.GbxWagon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvWagon)).BeginInit();
            this.CmsDgvSeat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BndTrain)).BeginInit();
            this.CmsTviWagon.SuspendLayout();
            this.CmsTviSeat.SuspendLayout();
            this.CmsTviCoupe.SuspendLayout();
            this.CmsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // MspMain
            // 
            this.MspMain.BackColor = System.Drawing.Color.Gray;
            this.MspMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MspMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MspMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.MsiControl,
            this.MsiHelp,
            this.MsiOrderBy});
            this.MspMain.Location = new System.Drawing.Point(0, 0);
            this.MspMain.Name = "MspMain";
            this.MspMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MspMain.Size = new System.Drawing.Size(1091, 40);
            this.MspMain.TabIndex = 0;
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsiOpen,
            this.MsiSaveAs,
            this.toolStripMenuItem1,
            this.MsiExit});
            this.файлToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.файлToolStripMenuItem.Image = global::Train.Properties.Resources.page;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(91, 36);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // MsiOpen
            // 
            this.MsiOpen.Image = global::Train.Properties.Resources.folder_explorer;
            this.MsiOpen.Name = "MsiOpen";
            this.MsiOpen.Size = new System.Drawing.Size(209, 38);
            this.MsiOpen.Text = "&Открыть...";
            this.MsiOpen.Click += new System.EventHandler(this.Open_Command);
            // 
            // MsiSaveAs
            // 
            this.MsiSaveAs.Image = global::Train.Properties.Resources.folder_edit;
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
            // MsiExit
            // 
            this.MsiExit.Image = global::Train.Properties.Resources.door_out;
            this.MsiExit.Name = "MsiExit";
            this.MsiExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MsiExit.Size = new System.Drawing.Size(209, 38);
            this.MsiExit.Text = "&Выход";
            this.MsiExit.Click += new System.EventHandler(this.Exit_Command);
            // 
            // MsiControl
            // 
            this.MsiControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsiInitialization,
            this.toolStripMenuItem2,
            this.MsiAddSleeper,
            this.MsiAddCorridor,
            this.MsiAddReserved,
            this.toolStripMenuItem5,
            this.MsiClear});
            this.MsiControl.Image = global::Train.Properties.Resources.control_panel;
            this.MsiControl.Name = "MsiControl";
            this.MsiControl.Size = new System.Drawing.Size(139, 36);
            this.MsiControl.Text = "&Управление";
            this.MsiControl.Click += new System.EventHandler(this.MsiControl_Click);
            // 
            // MsiInitialization
            // 
            this.MsiInitialization.Image = global::Train.Properties.Resources.add_on;
            this.MsiInitialization.Name = "MsiInitialization";
            this.MsiInitialization.Size = new System.Drawing.Size(309, 38);
            this.MsiInitialization.Text = "&Переформировать данные";
            this.MsiInitialization.Click += new System.EventHandler(this.Initialization_Command);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(306, 6);
            // 
            // MsiAddSleeper
            // 
            this.MsiAddSleeper.Image = global::Train.Properties.Resources.add;
            this.MsiAddSleeper.Name = "MsiAddSleeper";
            this.MsiAddSleeper.Size = new System.Drawing.Size(309, 38);
            this.MsiAddSleeper.Text = "Добавить &спальный вагон";
            this.MsiAddSleeper.Click += new System.EventHandler(this.AddWagon_Command);
            // 
            // MsiAddCorridor
            // 
            this.MsiAddCorridor.Image = global::Train.Properties.Resources.add;
            this.MsiAddCorridor.Name = "MsiAddCorridor";
            this.MsiAddCorridor.Size = new System.Drawing.Size(309, 38);
            this.MsiAddCorridor.Text = "Добавить &купейный вагон";
            this.MsiAddCorridor.Click += new System.EventHandler(this.AddWagon_Command);
            // 
            // MsiAddReserved
            // 
            this.MsiAddReserved.Image = global::Train.Properties.Resources.add;
            this.MsiAddReserved.Name = "MsiAddReserved";
            this.MsiAddReserved.Size = new System.Drawing.Size(309, 38);
            this.MsiAddReserved.Text = "Добавить &плацкартный вагон";
            this.MsiAddReserved.Click += new System.EventHandler(this.AddWagon_Command);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(306, 6);
            // 
            // MsiClear
            // 
            this.MsiClear.Image = global::Train.Properties.Resources.after_delete;
            this.MsiClear.Name = "MsiClear";
            this.MsiClear.Size = new System.Drawing.Size(309, 38);
            this.MsiClear.Text = "&Удалить все вагоны";
            this.MsiClear.Click += new System.EventHandler(this.Clear_Command);
            // 
            // MsiHelp
            // 
            this.MsiHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MsiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsiInfoProgram});
            this.MsiHelp.Image = global::Train.Properties.Resources.help;
            this.MsiHelp.Name = "MsiHelp";
            this.MsiHelp.Size = new System.Drawing.Size(115, 36);
            this.MsiHelp.Text = "&Помощь";
            // 
            // MsiInfoProgram
            // 
            this.MsiInfoProgram.Image = global::Train.Properties.Resources.information;
            this.MsiInfoProgram.Name = "MsiInfoProgram";
            this.MsiInfoProgram.Size = new System.Drawing.Size(201, 38);
            this.MsiInfoProgram.Text = "О программе...";
            this.MsiInfoProgram.Click += new System.EventHandler(this.InfoProgram_Command);
            // 
            // MsiOrderBy
            // 
            this.MsiOrderBy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsiOrderBySellDesc,
            this.MsiOrderByNumberWagonAsc,
            this.MsiOrderByNumberWagonDesc});
            this.MsiOrderBy.Image = global::Train.Properties.Resources.sort_asc_az;
            this.MsiOrderBy.Name = "MsiOrderBy";
            this.MsiOrderBy.Size = new System.Drawing.Size(201, 36);
            this.MsiOrderBy.Text = "Сортировка вагонов";
            // 
            // MsiOrderBySellDesc
            // 
            this.MsiOrderBySellDesc.Image = ((System.Drawing.Image)(resources.GetObject("MsiOrderBySellDesc.Image")));
            this.MsiOrderBySellDesc.Name = "MsiOrderBySellDesc";
            this.MsiOrderBySellDesc.Size = new System.Drawing.Size(401, 38);
            this.MsiOrderBySellDesc.Text = "По убыванию количества &проданных мест";
            this.MsiOrderBySellDesc.Click += new System.EventHandler(this.OrderBy_Command);
            // 
            // MsiOrderByNumberWagonAsc
            // 
            this.MsiOrderByNumberWagonAsc.Image = global::Train.Properties.Resources.chart_up_color;
            this.MsiOrderByNumberWagonAsc.Name = "MsiOrderByNumberWagonAsc";
            this.MsiOrderByNumberWagonAsc.Size = new System.Drawing.Size(401, 38);
            this.MsiOrderByNumberWagonAsc.Text = "По &возрастанию номеров вагонов";
            this.MsiOrderByNumberWagonAsc.Click += new System.EventHandler(this.OrderBy_Command);
            // 
            // MsiOrderByNumberWagonDesc
            // 
            this.MsiOrderByNumberWagonDesc.Image = global::Train.Properties.Resources.chart_down_color;
            this.MsiOrderByNumberWagonDesc.Name = "MsiOrderByNumberWagonDesc";
            this.MsiOrderByNumberWagonDesc.Size = new System.Drawing.Size(401, 38);
            this.MsiOrderByNumberWagonDesc.Text = "По &убыванию номеров вагонов";
            this.MsiOrderByNumberWagonDesc.Click += new System.EventHandler(this.OrderBy_Command);
            // 
            // CmsTviTrain
            // 
            this.CmsTviTrain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.CmsTviTrain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmiTviTrainAddSleeper,
            this.CmiTviTrainAddCorridor,
            this.CmiTviTrainAddReserved,
            this.toolStripMenuItem4,
            this.CmiTviTrainClear,
            this.toolStripSeparator3,
            this.CmiTviTrainBySellDesc,
            this.CmiTviTrainByNumberWagonAsc,
            this.CmiTviTrainByNumberWagonDesc});
            this.CmsTviTrain.Name = "contextMenuStrip1";
            this.CmsTviTrain.Size = new System.Drawing.Size(400, 282);
            this.CmsTviTrain.Opening += new System.ComponentModel.CancelEventHandler(this.CmsTviTrain_Opening);
            // 
            // CmiTviTrainAddSleeper
            // 
            this.CmiTviTrainAddSleeper.Image = global::Train.Properties.Resources.add;
            this.CmiTviTrainAddSleeper.Name = "CmiTviTrainAddSleeper";
            this.CmiTviTrainAddSleeper.Size = new System.Drawing.Size(399, 38);
            this.CmiTviTrainAddSleeper.Text = "Добавить &спальный вагон";
            this.CmiTviTrainAddSleeper.Click += new System.EventHandler(this.AddWagon_Command);
            // 
            // CmiTviTrainAddCorridor
            // 
            this.CmiTviTrainAddCorridor.Image = global::Train.Properties.Resources.add;
            this.CmiTviTrainAddCorridor.Name = "CmiTviTrainAddCorridor";
            this.CmiTviTrainAddCorridor.Size = new System.Drawing.Size(399, 38);
            this.CmiTviTrainAddCorridor.Text = "Добавить &купейный вагон";
            this.CmiTviTrainAddCorridor.Click += new System.EventHandler(this.AddWagon_Command);
            // 
            // CmiTviTrainAddReserved
            // 
            this.CmiTviTrainAddReserved.Image = global::Train.Properties.Resources.add;
            this.CmiTviTrainAddReserved.Name = "CmiTviTrainAddReserved";
            this.CmiTviTrainAddReserved.Size = new System.Drawing.Size(399, 38);
            this.CmiTviTrainAddReserved.Text = "Добавить &плацкартный вагон";
            this.CmiTviTrainAddReserved.Click += new System.EventHandler(this.AddWagon_Command);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(396, 6);
            // 
            // CmiTviTrainClear
            // 
            this.CmiTviTrainClear.Image = global::Train.Properties.Resources.after_delete;
            this.CmiTviTrainClear.Name = "CmiTviTrainClear";
            this.CmiTviTrainClear.Size = new System.Drawing.Size(399, 38);
            this.CmiTviTrainClear.Text = "&Удалить все вагоны";
            this.CmiTviTrainClear.Click += new System.EventHandler(this.Clear_Command);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(396, 6);
            // 
            // CmiTviTrainBySellDesc
            // 
            this.CmiTviTrainBySellDesc.Image = ((System.Drawing.Image)(resources.GetObject("CmiTviTrainBySellDesc.Image")));
            this.CmiTviTrainBySellDesc.Name = "CmiTviTrainBySellDesc";
            this.CmiTviTrainBySellDesc.Size = new System.Drawing.Size(399, 38);
            this.CmiTviTrainBySellDesc.Text = "Сортировать по убыванию количества &проданных мест";
            this.CmiTviTrainBySellDesc.Click += new System.EventHandler(this.OrderBy_Command);
            // 
            // CmiTviTrainByNumberWagonAsc
            // 
            this.CmiTviTrainByNumberWagonAsc.Image = global::Train.Properties.Resources.chart_up_color;
            this.CmiTviTrainByNumberWagonAsc.Name = "CmiTviTrainByNumberWagonAsc";
            this.CmiTviTrainByNumberWagonAsc.Size = new System.Drawing.Size(399, 38);
            this.CmiTviTrainByNumberWagonAsc.Text = "Сортировать по &возрастанию номеров вагонов";
            this.CmiTviTrainByNumberWagonAsc.Click += new System.EventHandler(this.OrderBy_Command);
            // 
            // CmiTviTrainByNumberWagonDesc
            // 
            this.CmiTviTrainByNumberWagonDesc.Image = global::Train.Properties.Resources.chart_down_color;
            this.CmiTviTrainByNumberWagonDesc.Name = "CmiTviTrainByNumberWagonDesc";
            this.CmiTviTrainByNumberWagonDesc.Size = new System.Drawing.Size(399, 38);
            this.CmiTviTrainByNumberWagonDesc.Text = "Сортировать по &убыванию номеров вагонов";
            this.CmiTviTrainByNumberWagonDesc.Click += new System.EventHandler(this.OrderBy_Command);
            // 
            // StsMain
            // 
            this.StsMain.BackColor = System.Drawing.Color.DarkGray;
            this.StsMain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StiAmountWagons,
            this.StiAmountSeats,
            this.StiSleeper,
            this.StiCorridor,
            this.StiReserved});
            this.StsMain.Location = new System.Drawing.Point(0, 506);
            this.StsMain.Name = "StsMain";
            this.StsMain.Size = new System.Drawing.Size(1091, 25);
            this.StsMain.TabIndex = 2;
            // 
            // StiAmountWagons
            // 
            this.StiAmountWagons.AutoSize = false;
            this.StiAmountWagons.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.StiAmountWagons.Name = "StiAmountWagons";
            this.StiAmountWagons.Size = new System.Drawing.Size(150, 20);
            this.StiAmountWagons.Text = "Всего вагонов: ";
            this.StiAmountWagons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StiAmountSeats
            // 
            this.StiAmountSeats.AutoSize = false;
            this.StiAmountSeats.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.StiAmountSeats.Name = "StiAmountSeats";
            this.StiAmountSeats.Size = new System.Drawing.Size(150, 20);
            this.StiAmountSeats.Text = "Места: ";
            this.StiAmountSeats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StiSleeper
            // 
            this.StiSleeper.AutoSize = false;
            this.StiSleeper.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.StiSleeper.Name = "StiSleeper";
            this.StiSleeper.Size = new System.Drawing.Size(258, 20);
            this.StiSleeper.Spring = true;
            this.StiSleeper.Text = "Спальные вагоны: ";
            this.StiSleeper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StiCorridor
            // 
            this.StiCorridor.AutoSize = false;
            this.StiCorridor.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.StiCorridor.Name = "StiCorridor";
            this.StiCorridor.Size = new System.Drawing.Size(258, 20);
            this.StiCorridor.Spring = true;
            this.StiCorridor.Text = "Купейные вагоны: ";
            this.StiCorridor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StiReserved
            // 
            this.StiReserved.AutoSize = false;
            this.StiReserved.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.StiReserved.Name = "StiReserved";
            this.StiReserved.Size = new System.Drawing.Size(258, 20);
            this.StiReserved.Spring = true;
            this.StiReserved.Text = "Плацкартные вагоны: ";
            this.StiReserved.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TspMain
            // 
            this.TspMain.BackColor = System.Drawing.Color.DarkGray;
            this.TspMain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TspMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TspMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.TspMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsiAddWagon,
            this.TsiBtnDeleteWagon,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.TsiCmbOrderBy,
            this.TsiBtnOrderBy,
            this.toolStripSeparator2,
            this.TsiExit});
            this.TspMain.Location = new System.Drawing.Point(0, 40);
            this.TspMain.Name = "TspMain";
            this.TspMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TspMain.Size = new System.Drawing.Size(1091, 39);
            this.TspMain.TabIndex = 3;
            // 
            // TsiAddWagon
            // 
            this.TsiAddWagon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsiAddWagon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsiAddSleeper,
            this.TsiAddCorridor,
            this.TsiAddReserved});
            this.TsiAddWagon.Image = global::Train.Properties.Resources.add;
            this.TsiAddWagon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsiAddWagon.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.TsiAddWagon.Name = "TsiAddWagon";
            this.TsiAddWagon.Size = new System.Drawing.Size(45, 36);
            this.TsiAddWagon.Text = "Добавить вагон";
            this.TsiAddWagon.Click += new System.EventHandler(this.TsiAddWagon_Click);
            // 
            // TsiAddSleeper
            // 
            this.TsiAddSleeper.Name = "TsiAddSleeper";
            this.TsiAddSleeper.Size = new System.Drawing.Size(286, 24);
            this.TsiAddSleeper.Text = "Добавить &спальный вагон";
            this.TsiAddSleeper.Click += new System.EventHandler(this.AddWagon_Command);
            // 
            // TsiAddCorridor
            // 
            this.TsiAddCorridor.Name = "TsiAddCorridor";
            this.TsiAddCorridor.Size = new System.Drawing.Size(286, 24);
            this.TsiAddCorridor.Text = "Добавить &купейный вагон";
            this.TsiAddCorridor.Click += new System.EventHandler(this.AddWagon_Command);
            // 
            // TsiAddReserved
            // 
            this.TsiAddReserved.Name = "TsiAddReserved";
            this.TsiAddReserved.Size = new System.Drawing.Size(286, 24);
            this.TsiAddReserved.Text = "Добавить &плацкартный вагон";
            this.TsiAddReserved.Click += new System.EventHandler(this.AddWagon_Command);
            // 
            // TsiBtnDeleteWagon
            // 
            this.TsiBtnDeleteWagon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsiBtnDeleteWagon.Image = global::Train.Properties.Resources.delete;
            this.TsiBtnDeleteWagon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsiBtnDeleteWagon.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.TsiBtnDeleteWagon.Name = "TsiBtnDeleteWagon";
            this.TsiBtnDeleteWagon.Size = new System.Drawing.Size(36, 36);
            this.TsiBtnDeleteWagon.Text = "Удалить выбранный вагон";
            this.TsiBtnDeleteWagon.Click += new System.EventHandler(this.RemoveWagon_Command);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(102, 36);
            this.toolStripLabel1.Text = "Сортировать:";
            // 
            // TsiCmbOrderBy
            // 
            this.TsiCmbOrderBy.AutoSize = false;
            this.TsiCmbOrderBy.BackColor = System.Drawing.Color.Gainsboro;
            this.TsiCmbOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TsiCmbOrderBy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TsiCmbOrderBy.Items.AddRange(new object[] {
            "по убыванию количества проданных мест",
            "по возрастанию номеров вагонов",
            "по убыванию номеров вагонов"});
            this.TsiCmbOrderBy.Name = "TsiCmbOrderBy";
            this.TsiCmbOrderBy.Size = new System.Drawing.Size(330, 28);
            // 
            // TsiBtnOrderBy
            // 
            this.TsiBtnOrderBy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsiBtnOrderBy.Image = global::Train.Properties.Resources.accept_button;
            this.TsiBtnOrderBy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsiBtnOrderBy.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.TsiBtnOrderBy.Name = "TsiBtnOrderBy";
            this.TsiBtnOrderBy.Size = new System.Drawing.Size(36, 36);
            this.TsiBtnOrderBy.Text = "Сортировать";
            this.TsiBtnOrderBy.ToolTipText = "Сортировать";
            this.TsiBtnOrderBy.Click += new System.EventHandler(this.CmbOrderBy_Command);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // TsiExit
            // 
            this.TsiExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TsiExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsiExit.Image = global::Train.Properties.Resources.door_out;
            this.TsiExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsiExit.Name = "TsiExit";
            this.TsiExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TsiExit.Size = new System.Drawing.Size(36, 36);
            this.TsiExit.Text = "Выход";
            this.TsiExit.Click += new System.EventHandler(this.Exit_Command);
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
            this.splitter1.Location = new System.Drawing.Point(0, 79);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 427);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 79);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GbxTrain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GbxWagon);
            this.splitContainer1.Size = new System.Drawing.Size(1088, 427);
            this.splitContainer1.SplitterDistance = 470;
            this.splitContainer1.TabIndex = 5;
            // 
            // GbxTrain
            // 
            this.GbxTrain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxTrain.Controls.Add(this.TviTrain);
            this.GbxTrain.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxTrain.ForeColor = System.Drawing.Color.White;
            this.GbxTrain.Location = new System.Drawing.Point(8, 8);
            this.GbxTrain.Name = "GbxTrain";
            this.GbxTrain.Size = new System.Drawing.Size(457, 411);
            this.GbxTrain.TabIndex = 0;
            this.GbxTrain.TabStop = false;
            this.GbxTrain.Text = " Обзор поезда ";
            // 
            // TviTrain
            // 
            this.TviTrain.AllowDrop = true;
            this.TviTrain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TviTrain.BackColor = System.Drawing.Color.DarkGray;
            this.TviTrain.ImageIndex = 0;
            this.TviTrain.ImageList = this.ImlTreeView;
            this.TviTrain.Location = new System.Drawing.Point(8, 24);
            this.TviTrain.Name = "TviTrain";
            this.TviTrain.SelectedImageIndex = 0;
            this.TviTrain.Size = new System.Drawing.Size(439, 379);
            this.TviTrain.TabIndex = 0;
            this.TviTrain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrvTrain_AfterSelect);
            this.TviTrain.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TviTrain_NodeMouseClick);
            this.TviTrain.DragDrop += new System.Windows.Forms.DragEventHandler(this.TviTrain_DragDrop);
            this.TviTrain.DragEnter += new System.Windows.Forms.DragEventHandler(this.TviTrain_DragEnter);
            this.TviTrain.DragLeave += new System.EventHandler(this.TviTrain_DragLeave);
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
            this.GbxWagon.Size = new System.Drawing.Size(607, 411);
            this.GbxWagon.TabIndex = 0;
            this.GbxWagon.TabStop = false;
            this.GbxWagon.Text = " Вагон: №";
            // 
            // DgvWagon
            // 
            this.DgvWagon.AllowDrop = true;
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
            this.stateDataGridViewTextBoxColumn,
            this.numberSeatDataGridViewTextBoxColumn,
            this.infoCoupeDataGridViewTextBoxColumn,
            this.infoWagonDataGridViewTextBoxColumn});
            this.DgvWagon.ContextMenuStrip = this.CmsDgvSeat;
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
            this.DgvWagon.Size = new System.Drawing.Size(593, 379);
            this.DgvWagon.TabIndex = 0;
            this.DgvWagon.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvWagon_CellMouseDown);
            this.DgvWagon.DragDrop += new System.Windows.Forms.DragEventHandler(this.DgvWagon_DragDrop);
            this.DgvWagon.DragEnter += new System.Windows.Forms.DragEventHandler(this.DgvWagon_DragEnter);
            this.DgvWagon.DragLeave += new System.EventHandler(this.DgvWagon_DragLeave);
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "Состояние билета";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberSeatDataGridViewTextBoxColumn
            // 
            this.numberSeatDataGridViewTextBoxColumn.DataPropertyName = "NumberSeat";
            this.numberSeatDataGridViewTextBoxColumn.HeaderText = "Номер места";
            this.numberSeatDataGridViewTextBoxColumn.Name = "numberSeatDataGridViewTextBoxColumn";
            this.numberSeatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // infoCoupeDataGridViewTextBoxColumn
            // 
            this.infoCoupeDataGridViewTextBoxColumn.DataPropertyName = "InfoCoupe";
            this.infoCoupeDataGridViewTextBoxColumn.HeaderText = "Купе";
            this.infoCoupeDataGridViewTextBoxColumn.Name = "infoCoupeDataGridViewTextBoxColumn";
            this.infoCoupeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // infoWagonDataGridViewTextBoxColumn
            // 
            this.infoWagonDataGridViewTextBoxColumn.DataPropertyName = "InfoWagon";
            this.infoWagonDataGridViewTextBoxColumn.HeaderText = "Вагон";
            this.infoWagonDataGridViewTextBoxColumn.Name = "infoWagonDataGridViewTextBoxColumn";
            this.infoWagonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CmsDgvSeat
            // 
            this.CmsDgvSeat.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.CmsDgvSeat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmiDgvSeatSell,
            this.CmiDgvSeatBack,
            this.toolStripMenuItem3,
            this.CmiDgvSeatRemoveWagon});
            this.CmsDgvSeat.Name = "contextMenuStrip1";
            this.CmsDgvSeat.Size = new System.Drawing.Size(220, 124);
            this.CmsDgvSeat.Opening += new System.ComponentModel.CancelEventHandler(this.CmsDgvSeat_Opening);
            // 
            // CmiDgvSeatSell
            // 
            this.CmiDgvSeatSell.Image = global::Train.Properties.Resources.terminal_seats_red;
            this.CmiDgvSeatSell.Name = "CmiDgvSeatSell";
            this.CmiDgvSeatSell.Size = new System.Drawing.Size(219, 38);
            this.CmiDgvSeatSell.Text = "Продать билет";
            this.CmiDgvSeatSell.Click += new System.EventHandler(this.CmiDgvSeatCell_Click);
            // 
            // CmiDgvSeatBack
            // 
            this.CmiDgvSeatBack.Image = global::Train.Properties.Resources.terminal_seats_blue;
            this.CmiDgvSeatBack.Name = "CmiDgvSeatBack";
            this.CmiDgvSeatBack.Size = new System.Drawing.Size(219, 38);
            this.CmiDgvSeatBack.Text = "Сдать билет";
            this.CmiDgvSeatBack.Click += new System.EventHandler(this.CmiDgvSeatBack_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(216, 6);
            // 
            // CmiDgvSeatRemoveWagon
            // 
            this.CmiDgvSeatRemoveWagon.Image = global::Train.Properties.Resources.delete;
            this.CmiDgvSeatRemoveWagon.Name = "CmiDgvSeatRemoveWagon";
            this.CmiDgvSeatRemoveWagon.Size = new System.Drawing.Size(219, 38);
            this.CmiDgvSeatRemoveWagon.Text = "Удалить текущий вагон";
            this.CmiDgvSeatRemoveWagon.Click += new System.EventHandler(this.RemoveWagon_Command);
            // 
            // BndTrain
            // 
            this.BndTrain.DataSource = typeof(Train.ViewModels.SeatView);
            // 
            // CmsTviWagon
            // 
            this.CmsTviWagon.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.CmsTviWagon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmiTviWagonDelete,
            this.toolStripMenuItem6,
            this.CmiTviWagonBySellDesc,
            this.CmiTviWagonByNumberWagonAsc,
            this.CmiTviWagonByNumberWagonDesc});
            this.CmsTviWagon.Name = "contextMenuStrip1";
            this.CmsTviWagon.Size = new System.Drawing.Size(400, 162);
            // 
            // CmiTviWagonDelete
            // 
            this.CmiTviWagonDelete.Image = global::Train.Properties.Resources.delete;
            this.CmiTviWagonDelete.Name = "CmiTviWagonDelete";
            this.CmiTviWagonDelete.Size = new System.Drawing.Size(399, 38);
            this.CmiTviWagonDelete.Text = "Удалить вагон";
            this.CmiTviWagonDelete.Click += new System.EventHandler(this.RemoveWagon_Command);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(396, 6);
            // 
            // CmiTviWagonBySellDesc
            // 
            this.CmiTviWagonBySellDesc.Image = ((System.Drawing.Image)(resources.GetObject("CmiTviWagonBySellDesc.Image")));
            this.CmiTviWagonBySellDesc.Name = "CmiTviWagonBySellDesc";
            this.CmiTviWagonBySellDesc.Size = new System.Drawing.Size(399, 38);
            this.CmiTviWagonBySellDesc.Text = "Сортировать по убыванию количества &проданных мест";
            this.CmiTviWagonBySellDesc.Click += new System.EventHandler(this.OrderBy_Command);
            // 
            // CmiTviWagonByNumberWagonAsc
            // 
            this.CmiTviWagonByNumberWagonAsc.Image = global::Train.Properties.Resources.chart_up_color;
            this.CmiTviWagonByNumberWagonAsc.Name = "CmiTviWagonByNumberWagonAsc";
            this.CmiTviWagonByNumberWagonAsc.Size = new System.Drawing.Size(399, 38);
            this.CmiTviWagonByNumberWagonAsc.Text = "Сортировать по &возрастанию номеров вагонов";
            this.CmiTviWagonByNumberWagonAsc.Click += new System.EventHandler(this.OrderBy_Command);
            // 
            // CmiTviWagonByNumberWagonDesc
            // 
            this.CmiTviWagonByNumberWagonDesc.Image = global::Train.Properties.Resources.chart_down_color;
            this.CmiTviWagonByNumberWagonDesc.Name = "CmiTviWagonByNumberWagonDesc";
            this.CmiTviWagonByNumberWagonDesc.Size = new System.Drawing.Size(399, 38);
            this.CmiTviWagonByNumberWagonDesc.Text = "Сортировать по &убыванию номеров вагонов";
            this.CmiTviWagonByNumberWagonDesc.Click += new System.EventHandler(this.OrderBy_Command);
            // 
            // CmsTviSeat
            // 
            this.CmsTviSeat.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.CmsTviSeat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmiTviSeatSell,
            this.CmiTviSeatBack});
            this.CmsTviSeat.Name = "contextMenuStrip1";
            this.CmsTviSeat.Size = new System.Drawing.Size(172, 80);
            this.CmsTviSeat.Opening += new System.ComponentModel.CancelEventHandler(this.CmsTviSeat_Opening);
            // 
            // CmiTviSeatSell
            // 
            this.CmiTviSeatSell.Image = global::Train.Properties.Resources.terminal_seats_red;
            this.CmiTviSeatSell.Name = "CmiTviSeatSell";
            this.CmiTviSeatSell.Size = new System.Drawing.Size(171, 38);
            this.CmiTviSeatSell.Text = "Продать билет";
            this.CmiTviSeatSell.Click += new System.EventHandler(this.SeatSell_Command);
            // 
            // CmiTviSeatBack
            // 
            this.CmiTviSeatBack.Image = global::Train.Properties.Resources.terminal_seats_blue;
            this.CmiTviSeatBack.Name = "CmiTviSeatBack";
            this.CmiTviSeatBack.Size = new System.Drawing.Size(171, 38);
            this.CmiTviSeatBack.Text = "Сдать билет";
            this.CmiTviSeatBack.Click += new System.EventHandler(this.SeatBack_Command);
            // 
            // CmsTviCoupe
            // 
            this.CmsTviCoupe.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.CmsTviCoupe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmiTviCoupeSellAll,
            this.CmiTviCoupeBackAll});
            this.CmsTviCoupe.Name = "contextMenuStrip1";
            this.CmsTviCoupe.Size = new System.Drawing.Size(245, 80);
            this.CmsTviCoupe.Opening += new System.ComponentModel.CancelEventHandler(this.CmsTviCoupe_Opening);
            // 
            // CmiTviCoupeSellAll
            // 
            this.CmiTviCoupeSellAll.Image = global::Train.Properties.Resources.terminal_seats_red;
            this.CmiTviCoupeSellAll.Name = "CmiTviCoupeSellAll";
            this.CmiTviCoupeSellAll.Size = new System.Drawing.Size(244, 38);
            this.CmiTviCoupeSellAll.Text = "Продать все билеты купе";
            this.CmiTviCoupeSellAll.Click += new System.EventHandler(this.CoupeSellAll_Command);
            // 
            // CmiTviCoupeBackAll
            // 
            this.CmiTviCoupeBackAll.Image = global::Train.Properties.Resources.terminal_seats_blue;
            this.CmiTviCoupeBackAll.Name = "CmiTviCoupeBackAll";
            this.CmiTviCoupeBackAll.Size = new System.Drawing.Size(244, 38);
            this.CmiTviCoupeBackAll.Text = "Возвратить все билеты купе";
            this.CmiTviCoupeBackAll.Click += new System.EventHandler(this.CoupeBackAll_Command);
            // 
            // CmsMain
            // 
            this.CmsMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.CmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmiMainInfoProgram,
            this.toolStripMenuItem7,
            this.CmiExit});
            this.CmsMain.Name = "contextMenuStrip1";
            this.CmsMain.Size = new System.Drawing.Size(197, 108);
            // 
            // CmiMainInfoProgram
            // 
            this.CmiMainInfoProgram.Image = global::Train.Properties.Resources.information;
            this.CmiMainInfoProgram.Name = "CmiMainInfoProgram";
            this.CmiMainInfoProgram.Size = new System.Drawing.Size(196, 38);
            this.CmiMainInfoProgram.Text = "О программе...";
            this.CmiMainInfoProgram.Click += new System.EventHandler(this.InfoProgram_Command);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(193, 6);
            // 
            // CmiExit
            // 
            this.CmiExit.Image = global::Train.Properties.Resources.door_out1;
            this.CmiExit.Name = "CmiExit";
            this.CmiExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.CmiExit.Size = new System.Drawing.Size(196, 38);
            this.CmiExit.Text = "Выход";
            this.CmiExit.Click += new System.EventHandler(this.Exit_Command);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1091, 531);
            this.ContextMenuStrip = this.CmsMain;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.TspMain);
            this.Controls.Add(this.StsMain);
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
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.DragLeave += new System.EventHandler(this.MainForm_DragLeave);
            this.MspMain.ResumeLayout(false);
            this.MspMain.PerformLayout();
            this.CmsTviTrain.ResumeLayout(false);
            this.StsMain.ResumeLayout(false);
            this.StsMain.PerformLayout();
            this.TspMain.ResumeLayout(false);
            this.TspMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.GbxTrain.ResumeLayout(false);
            this.GbxWagon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvWagon)).EndInit();
            this.CmsDgvSeat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BndTrain)).EndInit();
            this.CmsTviWagon.ResumeLayout(false);
            this.CmsTviSeat.ResumeLayout(false);
            this.CmsTviCoupe.ResumeLayout(false);
            this.CmsMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MspMain;
        private System.Windows.Forms.ContextMenuStrip CmsTviTrain;
        private System.Windows.Forms.StatusStrip StsMain;
        private System.Windows.Forms.ToolStrip TspMain;
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
        private System.Windows.Forms.TreeView TviTrain;
        private System.Windows.Forms.GroupBox GbxWagon;
        private System.Windows.Forms.DataGridView DgvWagon;
        private System.Windows.Forms.BindingSource BndTrain;
        private System.Windows.Forms.ImageList ImlTreeView;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberSeatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoCoupeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoWagonDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem MsiControl;
        private System.Windows.Forms.ToolStripMenuItem MsiAddReserved;
        private System.Windows.Forms.ToolStripMenuItem MsiInitialization;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MsiAddSleeper;
        private System.Windows.Forms.ToolStripMenuItem MsiAddCorridor;
        private System.Windows.Forms.ContextMenuStrip CmsTviWagon;
        private System.Windows.Forms.ToolStripMenuItem CmiTviWagonDelete;
        private System.Windows.Forms.ContextMenuStrip CmsTviSeat;
        private System.Windows.Forms.ToolStripMenuItem CmiTviSeatSell;
        private System.Windows.Forms.ToolStripMenuItem CmiTviTrainAddSleeper;
        private System.Windows.Forms.ToolStripMenuItem CmiTviTrainAddCorridor;
        private System.Windows.Forms.ToolStripMenuItem CmiTviTrainAddReserved;
        private System.Windows.Forms.ToolStripMenuItem CmiTviSeatBack;
        private System.Windows.Forms.ContextMenuStrip CmsDgvSeat;
        private System.Windows.Forms.ToolStripMenuItem CmiDgvSeatSell;
        private System.Windows.Forms.ToolStripMenuItem CmiDgvSeatBack;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem CmiDgvSeatRemoveWagon;
        private System.Windows.Forms.ToolStripDropDownButton TsiAddWagon;
        private System.Windows.Forms.ToolStripMenuItem TsiAddSleeper;
        private System.Windows.Forms.ToolStripMenuItem TsiAddCorridor;
        private System.Windows.Forms.ToolStripMenuItem TsiAddReserved;
        private System.Windows.Forms.ToolStripButton TsiBtnDeleteWagon;
        private System.Windows.Forms.ContextMenuStrip CmsTviCoupe;
        private System.Windows.Forms.ToolStripMenuItem CmiTviCoupeSellAll;
        private System.Windows.Forms.ToolStripMenuItem CmiTviCoupeBackAll;
        private System.Windows.Forms.ToolStripStatusLabel StiAmountSeats;
        private System.Windows.Forms.ToolStripStatusLabel StiAmountWagons;
        private System.Windows.Forms.ToolStripStatusLabel StiSleeper;
        private System.Windows.Forms.ToolStripStatusLabel StiCorridor;
        private System.Windows.Forms.ToolStripStatusLabel StiReserved;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem CmiTviTrainClear;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem MsiClear;
        private System.Windows.Forms.ToolStripMenuItem MsiHelp;
        private System.Windows.Forms.ToolStripMenuItem MsiInfoProgram;
        private System.Windows.Forms.ContextMenuStrip CmsMain;
        private System.Windows.Forms.ToolStripMenuItem CmiMainInfoProgram;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem CmiExit;
        private System.Windows.Forms.ToolStripMenuItem MsiOrderBy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox TsiCmbOrderBy;
        private System.Windows.Forms.ToolStripButton TsiBtnOrderBy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem MsiOrderBySellDesc;
        private System.Windows.Forms.ToolStripMenuItem MsiOrderByNumberWagonAsc;
        private System.Windows.Forms.ToolStripMenuItem MsiOrderByNumberWagonDesc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem CmiTviTrainBySellDesc;
        private System.Windows.Forms.ToolStripMenuItem CmiTviTrainByNumberWagonAsc;
        private System.Windows.Forms.ToolStripMenuItem CmiTviTrainByNumberWagonDesc;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem CmiTviWagonBySellDesc;
        private System.Windows.Forms.ToolStripMenuItem CmiTviWagonByNumberWagonAsc;
        private System.Windows.Forms.ToolStripMenuItem CmiTviWagonByNumberWagonDesc;
        private System.Windows.Forms.ToolStripButton TsiExit;
    }
}

