namespace TableFunctions
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DgvPersons = new System.Windows.Forms.DataGridView();
            this.ClnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnPatronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmnDataGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.показатьданныеВыбраннойСтрокиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.закрытьФормуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersons)).BeginInit();
            this.CmnDataGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvPersons
            // 
            this.DgvPersons.AllowUserToAddRows = false;
            this.DgvPersons.AllowUserToDeleteRows = false;
            this.DgvPersons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPersons.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPersons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvPersons.ColumnHeadersHeight = 74;
            this.DgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnId,
            this.ClnSurname,
            this.ClnName,
            this.ClnPatronymic,
            this.ClnAge});
            this.DgvPersons.ContextMenuStrip = this.CmnDataGridView;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPersons.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPersons.Location = new System.Drawing.Point(0, 0);
            this.DgvPersons.MultiSelect = false;
            this.DgvPersons.Name = "DgvPersons";
            this.DgvPersons.ReadOnly = true;
            this.DgvPersons.RowHeadersVisible = false;
            this.DgvPersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPersons.Size = new System.Drawing.Size(955, 450);
            this.DgvPersons.TabIndex = 0;
            // 
            // ClnId
            // 
            this.ClnId.FillWeight = 10F;
            this.ClnId.HeaderText = "Идентификатор";
            this.ClnId.Name = "ClnId";
            this.ClnId.ReadOnly = true;
            // 
            // ClnSurname
            // 
            this.ClnSurname.FillWeight = 30F;
            this.ClnSurname.HeaderText = "Фамилия персоны для учета";
            this.ClnSurname.Name = "ClnSurname";
            this.ClnSurname.ReadOnly = true;
            // 
            // ClnName
            // 
            this.ClnName.FillWeight = 20F;
            this.ClnName.HeaderText = "Имя";
            this.ClnName.Name = "ClnName";
            this.ClnName.ReadOnly = true;
            // 
            // ClnPatronymic
            // 
            this.ClnPatronymic.FillWeight = 30F;
            this.ClnPatronymic.HeaderText = "Отчество";
            this.ClnPatronymic.Name = "ClnPatronymic";
            this.ClnPatronymic.ReadOnly = true;
            // 
            // ClnAge
            // 
            this.ClnAge.FillWeight = 10F;
            this.ClnAge.HeaderText = "Возраст";
            this.ClnAge.Name = "ClnAge";
            this.ClnAge.ReadOnly = true;
            // 
            // CmnDataGridView
            // 
            this.CmnDataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьданныеВыбраннойСтрокиToolStripMenuItem,
            this.toolStripMenuItem1,
            this.закрытьФормуToolStripMenuItem});
            this.CmnDataGridView.Name = "CmnDataGridView";
            this.CmnDataGridView.Size = new System.Drawing.Size(276, 54);
            // 
            // показатьданныеВыбраннойСтрокиToolStripMenuItem
            // 
            this.показатьданныеВыбраннойСтрокиToolStripMenuItem.Name = "показатьданныеВыбраннойСтрокиToolStripMenuItem";
            this.показатьданныеВыбраннойСтрокиToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.показатьданныеВыбраннойСтрокиToolStripMenuItem.Text = "Показать данные выбранной строки";
            this.показатьданныеВыбраннойСтрокиToolStripMenuItem.Click += new System.EventHandler(this.CmiShowItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(272, 6);
            // 
            // закрытьФормуToolStripMenuItem
            // 
            this.закрытьФормуToolStripMenuItem.Name = "закрытьФормуToolStripMenuItem";
            this.закрытьФормуToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.закрытьФормуToolStripMenuItem.Text = "Закрыть форму";
            this.закрытьФормуToolStripMenuItem.Click += new System.EventHandler(this.CmiClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 450);
            this.Controls.Add(this.DgvPersons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пример DataGridView";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersons)).EndInit();
            this.CmnDataGridView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPersons;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnPatronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnAge;
        private System.Windows.Forms.ContextMenuStrip CmnDataGridView;
        private System.Windows.Forms.ToolStripMenuItem показатьданныеВыбраннойСтрокиToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem закрытьФормуToolStripMenuItem;
    }
}