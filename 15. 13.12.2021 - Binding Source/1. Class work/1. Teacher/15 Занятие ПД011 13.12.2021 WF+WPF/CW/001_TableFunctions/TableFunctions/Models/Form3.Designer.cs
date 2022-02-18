
namespace TableFunctions.Models
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.DgvPersons = new System.Windows.Forms.DataGridView();
            this.CmnDataGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьТекущуюЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьТекущуюЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BnsPerson = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersons)).BeginInit();
            this.CmnDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BnsPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvPersons
            // 
            this.DgvPersons.AllowUserToAddRows = false;
            this.DgvPersons.AllowUserToDeleteRows = false;
            this.DgvPersons.AutoGenerateColumns = false;
            this.DgvPersons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColFullName,
            this.ColAge,
            this.ColSalary,
            this.ColCity});
            this.DgvPersons.ContextMenuStrip = this.CmnDataGridView;
            this.DgvPersons.DataSource = this.BnsPerson;
            this.DgvPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPersons.Location = new System.Drawing.Point(0, 0);
            this.DgvPersons.MultiSelect = false;
            this.DgvPersons.Name = "DgvPersons";
            this.DgvPersons.ReadOnly = true;
            this.DgvPersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPersons.Size = new System.Drawing.Size(800, 450);
            this.DgvPersons.TabIndex = 0;
            this.DgvPersons.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.SetCellStyle);
            this.DgvPersons.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvPersons_CellMouseDown);
            // 
            // CmnDataGridView
            // 
            this.CmnDataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьТекущуюЗаписьToolStripMenuItem,
            this.изменитьТекущуюЗаписьToolStripMenuItem,
            this.добавитьЗаписьToolStripMenuItem});
            this.CmnDataGridView.Name = "CmnDataGridView";
            this.CmnDataGridView.Size = new System.Drawing.Size(222, 92);
            // 
            // удалитьТекущуюЗаписьToolStripMenuItem
            // 
            this.удалитьТекущуюЗаписьToolStripMenuItem.Name = "удалитьТекущуюЗаписьToolStripMenuItem";
            this.удалитьТекущуюЗаписьToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.удалитьТекущуюЗаписьToolStripMenuItem.Text = "Удалить текущую запись";
            this.удалитьТекущуюЗаписьToolStripMenuItem.Click += new System.EventHandler(this.RemoveAt_Command);
            // 
            // изменитьТекущуюЗаписьToolStripMenuItem
            // 
            this.изменитьТекущуюЗаписьToolStripMenuItem.Name = "изменитьТекущуюЗаписьToolStripMenuItem";
            this.изменитьТекущуюЗаписьToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.изменитьТекущуюЗаписьToolStripMenuItem.Text = "Изменить текущую запись";
            this.изменитьТекущуюЗаписьToolStripMenuItem.Click += new System.EventHandler(this.UpdateAt_Command);
            // 
            // добавитьЗаписьToolStripMenuItem
            // 
            this.добавитьЗаписьToolStripMenuItem.Name = "добавитьЗаписьToolStripMenuItem";
            this.добавитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.добавитьЗаписьToolStripMenuItem.Text = "Добавить запись";
            this.добавитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.Add_Command);
            // 
            // ColFullName
            // 
            this.ColFullName.DataPropertyName = "FullName";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ColFullName.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColFullName.FillWeight = 40F;
            this.ColFullName.HeaderText = "Фамииля И.О.";
            this.ColFullName.Name = "ColFullName";
            this.ColFullName.ReadOnly = true;
            // 
            // ColAge
            // 
            this.ColAge.DataPropertyName = "Age";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColAge.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColAge.FillWeight = 15F;
            this.ColAge.HeaderText = "Возраст, лет";
            this.ColAge.Name = "ColAge";
            this.ColAge.ReadOnly = true;
            // 
            // ColSalary
            // 
            this.ColSalary.DataPropertyName = "Salary";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColSalary.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColSalary.FillWeight = 15F;
            this.ColSalary.HeaderText = "Оклад, руб.";
            this.ColSalary.Name = "ColSalary";
            this.ColSalary.ReadOnly = true;
            // 
            // ColCity
            // 
            this.ColCity.DataPropertyName = "City";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ColCity.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColCity.FillWeight = 30F;
            this.ColCity.HeaderText = "Город";
            this.ColCity.Name = "ColCity";
            this.ColCity.ReadOnly = true;
            // 
            // BnsPerson
            // 
            this.BnsPerson.DataSource = typeof(TableFunctions.Models.Person);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvPersons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Занятие 13.12.2021 - демонстрация привязки данных к DataViewGrid";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersons)).EndInit();
            this.CmnDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BnsPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPersons;
        private System.Windows.Forms.BindingSource BnsPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCity;
        private System.Windows.Forms.ContextMenuStrip CmnDataGridView;
        private System.Windows.Forms.ToolStripMenuItem удалитьТекущуюЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьТекущуюЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаписьToolStripMenuItem;
    }
}