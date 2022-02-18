namespace HomeWork.Views
{
    partial class ListsForm
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
            this.LbxFirst = new System.Windows.Forms.ListBox();
            this.LbxSecond = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnMoveOneElemSecond = new System.Windows.Forms.Button();
            this.BtnMoveAllElemSecond = new System.Windows.Forms.Button();
            this.BtnMoveOneElemFirst = new System.Windows.Forms.Button();
            this.BtnMoveAllElemFirst = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnAddListBoxFirst = new System.Windows.Forms.Button();
            this.TxbInput = new System.Windows.Forms.TextBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.CbxCities = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LbxFirst
            // 
            this.LbxFirst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LbxFirst.BackColor = System.Drawing.Color.DarkGray;
            this.LbxFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbxFirst.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbxFirst.FormattingEnabled = true;
            this.LbxFirst.ItemHeight = 19;
            this.LbxFirst.Items.AddRange(new object[] {
            "Сингапур",
            "Лондон",
            "Париж",
            "Дубай",
            "Дели",
            "Стамбул",
            "Гонконг",
            "Бангкок",
            "Макао",
            "Шэньчжэнь",
            "Рим",
            "Прага"});
            this.LbxFirst.Location = new System.Drawing.Point(24, 64);
            this.LbxFirst.Name = "LbxFirst";
            this.LbxFirst.Size = new System.Drawing.Size(256, 325);
            this.LbxFirst.TabIndex = 0;
            // 
            // LbxSecond
            // 
            this.LbxSecond.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LbxSecond.BackColor = System.Drawing.Color.DarkGray;
            this.LbxSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbxSecond.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbxSecond.FormattingEnabled = true;
            this.LbxSecond.ItemHeight = 19;
            this.LbxSecond.Location = new System.Drawing.Point(312, 64);
            this.LbxSecond.Name = "LbxSecond";
            this.LbxSecond.Size = new System.Drawing.Size(256, 325);
            this.LbxSecond.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Лист-бокс 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(312, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Лист-бокс 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnMoveOneElemSecond
            // 
            this.BtnMoveOneElemSecond.BackColor = System.Drawing.Color.Silver;
            this.BtnMoveOneElemSecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMoveOneElemSecond.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMoveOneElemSecond.Location = new System.Drawing.Point(608, 92);
            this.BtnMoveOneElemSecond.Name = "BtnMoveOneElemSecond";
            this.BtnMoveOneElemSecond.Size = new System.Drawing.Size(320, 64);
            this.BtnMoveOneElemSecond.TabIndex = 3;
            this.BtnMoveOneElemSecond.Text = "Перемещение выбранного элемента во второй лист-бокс";
            this.BtnMoveOneElemSecond.UseVisualStyleBackColor = false;
            this.BtnMoveOneElemSecond.Click += new System.EventHandler(this.BtnMoveOneElemSecond_Click);
            // 
            // BtnMoveAllElemSecond
            // 
            this.BtnMoveAllElemSecond.BackColor = System.Drawing.Color.Silver;
            this.BtnMoveAllElemSecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMoveAllElemSecond.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMoveAllElemSecond.Location = new System.Drawing.Point(608, 245);
            this.BtnMoveAllElemSecond.Name = "BtnMoveAllElemSecond";
            this.BtnMoveAllElemSecond.Size = new System.Drawing.Size(320, 64);
            this.BtnMoveAllElemSecond.TabIndex = 5;
            this.BtnMoveAllElemSecond.Text = "Перемещение всех элементов во второй лист-бокс";
            this.BtnMoveAllElemSecond.UseVisualStyleBackColor = false;
            this.BtnMoveAllElemSecond.Click += new System.EventHandler(this.BtnMoveAllElemSecond_Click);
            // 
            // BtnMoveOneElemFirst
            // 
            this.BtnMoveOneElemFirst.BackColor = System.Drawing.Color.Silver;
            this.BtnMoveOneElemFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMoveOneElemFirst.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMoveOneElemFirst.Location = new System.Drawing.Point(608, 16);
            this.BtnMoveOneElemFirst.Name = "BtnMoveOneElemFirst";
            this.BtnMoveOneElemFirst.Size = new System.Drawing.Size(320, 64);
            this.BtnMoveOneElemFirst.TabIndex = 2;
            this.BtnMoveOneElemFirst.Text = "Перемещение выбранного элемента в первый лист-бокс";
            this.BtnMoveOneElemFirst.UseVisualStyleBackColor = false;
            this.BtnMoveOneElemFirst.Click += new System.EventHandler(this.BtnMoveOneElemFirst_Click);
            // 
            // BtnMoveAllElemFirst
            // 
            this.BtnMoveAllElemFirst.BackColor = System.Drawing.Color.Silver;
            this.BtnMoveAllElemFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMoveAllElemFirst.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMoveAllElemFirst.Location = new System.Drawing.Point(608, 168);
            this.BtnMoveAllElemFirst.Name = "BtnMoveAllElemFirst";
            this.BtnMoveAllElemFirst.Size = new System.Drawing.Size(320, 64);
            this.BtnMoveAllElemFirst.TabIndex = 4;
            this.BtnMoveAllElemFirst.Text = "Перемещение всех элементов в первый лист-бокс";
            this.BtnMoveAllElemFirst.UseVisualStyleBackColor = false;
            this.BtnMoveAllElemFirst.Click += new System.EventHandler(this.BtnMoveAllElemFirst_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.Silver;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClear.Location = new System.Drawing.Point(608, 322);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(320, 64);
            this.BtnClear.TabIndex = 6;
            this.BtnClear.Text = "Очистка лист-боксов";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnAddListBoxFirst
            // 
            this.BtnAddListBoxFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAddListBoxFirst.BackColor = System.Drawing.Color.Silver;
            this.BtnAddListBoxFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddListBoxFirst.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAddListBoxFirst.Location = new System.Drawing.Point(24, 432);
            this.BtnAddListBoxFirst.Name = "BtnAddListBoxFirst";
            this.BtnAddListBoxFirst.Size = new System.Drawing.Size(256, 32);
            this.BtnAddListBoxFirst.TabIndex = 8;
            this.BtnAddListBoxFirst.Text = "Добавить";
            this.BtnAddListBoxFirst.UseVisualStyleBackColor = false;
            this.BtnAddListBoxFirst.Click += new System.EventHandler(this.BtnAddListBoxFirst_Click);
            // 
            // TxbInput
            // 
            this.TxbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxbInput.AutoCompleteCustomSource.AddRange(new string[] {
            "Нью-Йорк",
            "Майами",
            "Лос-Анджелес",
            "Лас-Вегас",
            "Канкун",
            "Каир",
            "Эр-Рияд",
            "Дубай",
            "Мекка"});
            this.TxbInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TxbInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TxbInput.BackColor = System.Drawing.Color.LightGray;
            this.TxbInput.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxbInput.Location = new System.Drawing.Point(24, 400);
            this.TxbInput.Name = "TxbInput";
            this.TxbInput.Size = new System.Drawing.Size(256, 30);
            this.TxbInput.TabIndex = 7;
            this.TxbInput.Text = "Дубай";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.IndianRed;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClose.Location = new System.Drawing.Point(608, 400);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(320, 64);
            this.BtnClose.TabIndex = 10;
            this.BtnClose.Text = "Выход";
            this.BtnClose.UseVisualStyleBackColor = false;
            // 
            // CbxCities
            // 
            this.CbxCities.BackColor = System.Drawing.Color.LightGray;
            this.CbxCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxCities.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbxCities.FormattingEnabled = true;
            this.CbxCities.Items.AddRange(new object[] {
            "Нью-Йорк",
            "Майами",
            "Лос-Анджелес",
            "Лас-Вегас",
            "Канкун",
            "Каир",
            "Эр-Рияд",
            "Дубай",
            "Мекка"});
            this.CbxCities.Location = new System.Drawing.Point(312, 400);
            this.CbxCities.Name = "CbxCities";
            this.CbxCities.Size = new System.Drawing.Size(256, 31);
            this.CbxCities.TabIndex = 9;
            this.CbxCities.SelectedIndexChanged += new System.EventHandler(this.CbxCities_SelectedIndexChanged);
            // 
            // ListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(942, 471);
            this.Controls.Add(this.CbxCities);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.TxbInput);
            this.Controls.Add(this.BtnAddListBoxFirst);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnMoveAllElemFirst);
            this.Controls.Add(this.BtnMoveOneElemFirst);
            this.Controls.Add(this.BtnMoveAllElemSecond);
            this.Controls.Add(this.BtnMoveOneElemSecond);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbxSecond);
            this.Controls.Add(this.LbxFirst);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(958, 510);
            this.Name = "ListsForm";
            this.Text = "Списки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbxFirst;
        private System.Windows.Forms.ListBox LbxSecond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnMoveOneElemSecond;
        private System.Windows.Forms.Button BtnMoveAllElemSecond;
        private System.Windows.Forms.Button BtnMoveOneElemFirst;
        private System.Windows.Forms.Button BtnMoveAllElemFirst;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnAddListBoxFirst;
        private System.Windows.Forms.TextBox TxbInput;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.ComboBox CbxCities;
    }
}