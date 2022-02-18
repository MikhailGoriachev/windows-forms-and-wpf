
namespace TableFunctions.Models
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.DgvPersons = new System.Windows.Forms.DataGridView();
            this.ClnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ClnNumber,
            this.ClnFullName,
            this.ClnAge,
            this.ClnSalary,
            this.ClnCity});
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DgvPersons.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvPersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPersons.Size = new System.Drawing.Size(998, 450);
            this.DgvPersons.TabIndex = 1;
            // 
            // ClnNumber
            // 
            this.ClnNumber.FillWeight = 10F;
            this.ClnNumber.HeaderText = "№ п/п";
            this.ClnNumber.Name = "ClnNumber";
            this.ClnNumber.ReadOnly = true;
            // 
            // ClnFullName
            // 
            this.ClnFullName.FillWeight = 30F;
            this.ClnFullName.HeaderText = "Фамилия И.О.";
            this.ClnFullName.Name = "ClnFullName";
            this.ClnFullName.ReadOnly = true;
            // 
            // ClnAge
            // 
            this.ClnAge.FillWeight = 15F;
            this.ClnAge.HeaderText = "Возраст, лет";
            this.ClnAge.Name = "ClnAge";
            this.ClnAge.ReadOnly = true;
            // 
            // ClnSalary
            // 
            this.ClnSalary.FillWeight = 15F;
            this.ClnSalary.HeaderText = "Оклад, руб.";
            this.ClnSalary.Name = "ClnSalary";
            this.ClnSalary.ReadOnly = true;
            // 
            // ClnCity
            // 
            this.ClnCity.FillWeight = 30F;
            this.ClnCity.HeaderText = "Город проживания";
            this.ClnCity.Name = "ClnCity";
            this.ClnCity.ReadOnly = true;
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
            this.показатьданныеВыбраннойСтрокиToolStripMenuItem.Click += new System.EventHandler(this.ShowSelected_Command);
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
            this.закрытьФормуToolStripMenuItem.Click += new System.EventHandler(this.Close_Command);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 450);
            this.Controls.Add(this.DgvPersons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Занятие 09.12.2021 - пример загрузки DataGridView коллекципей объектов";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersons)).EndInit();
            this.CmnDataGridView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPersons;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnCity;
        private System.Windows.Forms.ContextMenuStrip CmnDataGridView;
        private System.Windows.Forms.ToolStripMenuItem показатьданныеВыбраннойСтрокиToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem закрытьФормуToolStripMenuItem;
    }
}