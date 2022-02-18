
namespace BindingListBoxContextMenu
{
    partial class WorkerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerForm));
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.TxbInfo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblId = new System.Windows.Forms.Label();
            this.LblFullName = new System.Windows.Forms.Label();
            this.LblAge = new System.Windows.Forms.Label();
            this.LblPosition = new System.Windows.Forms.Label();
            this.CbxPosition = new System.Windows.Forms.ComboBox();
            this.TxbFullName = new System.Windows.Forms.TextBox();
            this.NudAge = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAdd.Location = new System.Drawing.Point(296, 288);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(152, 40);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClose.Location = new System.Drawing.Point(464, 288);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(152, 40);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Закрыть";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // TxbInfo
            // 
            this.TxbInfo.BackColor = System.Drawing.SystemColors.Info;
            this.TxbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxbInfo.Location = new System.Drawing.Point(24, 16);
            this.TxbInfo.Multiline = true;
            this.TxbInfo.Name = "TxbInfo";
            this.TxbInfo.ReadOnly = true;
            this.TxbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxbInfo.Size = new System.Drawing.Size(592, 56);
            this.TxbInfo.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NudAge);
            this.groupBox1.Controls.Add(this.TxbFullName);
            this.groupBox1.Controls.Add(this.CbxPosition);
            this.groupBox1.Controls.Add(this.LblPosition);
            this.groupBox1.Controls.Add(this.LblAge);
            this.groupBox1.Controls.Add(this.LblFullName);
            this.groupBox1.Controls.Add(this.LblId);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(24, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 168);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Данные пользователя ";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(24, 40);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(46, 18);
            this.LblId.TabIndex = 0;
            this.LblId.Text = "label1";
            // 
            // LblFullName
            // 
            this.LblFullName.AutoSize = true;
            this.LblFullName.Location = new System.Drawing.Point(24, 88);
            this.LblFullName.Name = "LblFullName";
            this.LblFullName.Size = new System.Drawing.Size(104, 18);
            this.LblFullName.TabIndex = 1;
            this.LblFullName.Text = "Фамилия ИО:";
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Location = new System.Drawing.Point(24, 136);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(70, 18);
            this.LblAge.TabIndex = 2;
            this.LblAge.Text = "Возраст:";
            // 
            // LblPosition
            // 
            this.LblPosition.AutoSize = true;
            this.LblPosition.Location = new System.Drawing.Point(392, 64);
            this.LblPosition.Name = "LblPosition";
            this.LblPosition.Size = new System.Drawing.Size(93, 18);
            this.LblPosition.TabIndex = 3;
            this.LblPosition.Text = "Должность:";
            // 
            // CbxPosition
            // 
            this.CbxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxPosition.FormattingEnabled = true;
            this.CbxPosition.Items.AddRange(new object[] {
            "асситстент",
            "пекарь",
            "разработчик",
            "слесарь",
            "тестировщик",
            "тим-лид",
            "токарь"});
            this.CbxPosition.Location = new System.Drawing.Point(392, 84);
            this.CbxPosition.Name = "CbxPosition";
            this.CbxPosition.Size = new System.Drawing.Size(192, 26);
            this.CbxPosition.Sorted = true;
            this.CbxPosition.TabIndex = 4;
            // 
            // TxbFullName
            // 
            this.TxbFullName.Location = new System.Drawing.Point(136, 85);
            this.TxbFullName.Name = "TxbFullName";
            this.TxbFullName.Size = new System.Drawing.Size(232, 24);
            this.TxbFullName.TabIndex = 5;
            this.TxbFullName.Validated += new System.EventHandler(this.TxbFullName_Validated);
            // 
            // NudAge
            // 
            this.NudAge.Location = new System.Drawing.Point(136, 133);
            this.NudAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.NudAge.Minimum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.NudAge.Name = "NudAge";
            this.NudAge.Size = new System.Drawing.Size(232, 24);
            this.NudAge.TabIndex = 6;
            this.NudAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudAge.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 348);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxbInfo);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить пользователя";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TextBox TxbInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.NumericUpDown NudAge;
        private System.Windows.Forms.TextBox TxbFullName;
        private System.Windows.Forms.ComboBox CbxPosition;
        private System.Windows.Forms.Label LblPosition;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.Label LblFullName;
    }
}