namespace HomeWork.Views
{
    partial class SelectionByForm
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
            this.GbxTelevisions = new System.Windows.Forms.GroupBox();
            this.LbxTelevisions = new System.Windows.Forms.ListBox();
            this.LblHeadTelevisions = new System.Windows.Forms.Label();
            this.LblSelectionBy = new System.Windows.Forms.Label();
            this.CbxParameter = new System.Windows.Forms.ComboBox();
            this.LblParameter = new System.Windows.Forms.Label();
            this.TxbSelectionBy = new System.Windows.Forms.TextBox();
            this.StsMainStatus = new System.Windows.Forms.StatusStrip();
            this.SlbInfoCountElement = new System.Windows.Forms.ToolStripStatusLabel();
            this.GbxTelevisions.SuspendLayout();
            this.StsMainStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxTelevisions
            // 
            this.GbxTelevisions.Controls.Add(this.LbxTelevisions);
            this.GbxTelevisions.Controls.Add(this.LblHeadTelevisions);
            this.GbxTelevisions.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxTelevisions.ForeColor = System.Drawing.Color.White;
            this.GbxTelevisions.Location = new System.Drawing.Point(8, 112);
            this.GbxTelevisions.Name = "GbxTelevisions";
            this.GbxTelevisions.Size = new System.Drawing.Size(1096, 368);
            this.GbxTelevisions.TabIndex = 7;
            this.GbxTelevisions.TabStop = false;
            this.GbxTelevisions.Text = " Телевизоры ";
            // 
            // LbxTelevisions
            // 
            this.LbxTelevisions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LbxTelevisions.BackColor = System.Drawing.Color.DarkGray;
            this.LbxTelevisions.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbxTelevisions.FormattingEnabled = true;
            this.LbxTelevisions.ItemHeight = 18;
            this.LbxTelevisions.Location = new System.Drawing.Point(13, 64);
            this.LbxTelevisions.Name = "LbxTelevisions";
            this.LbxTelevisions.Size = new System.Drawing.Size(1072, 292);
            this.LbxTelevisions.TabIndex = 2;
            // 
            // LblHeadTelevisions
            // 
            this.LblHeadTelevisions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblHeadTelevisions.BackColor = System.Drawing.Color.Silver;
            this.LblHeadTelevisions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblHeadTelevisions.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblHeadTelevisions.ForeColor = System.Drawing.Color.Black;
            this.LblHeadTelevisions.Location = new System.Drawing.Point(13, 32);
            this.LblHeadTelevisions.Name = "LblHeadTelevisions";
            this.LblHeadTelevisions.Size = new System.Drawing.Size(1072, 32);
            this.LblHeadTelevisions.TabIndex = 5;
            this.LblHeadTelevisions.Text = "        Модель        Диагональ             Описание дефекта                     " +
    " Мастер                Владелец            Цена      ";
            this.LblHeadTelevisions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblSelectionBy
            // 
            this.LblSelectionBy.BackColor = System.Drawing.Color.DarkGray;
            this.LblSelectionBy.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSelectionBy.ForeColor = System.Drawing.Color.White;
            this.LblSelectionBy.Location = new System.Drawing.Point(364, 16);
            this.LblSelectionBy.Name = "LblSelectionBy";
            this.LblSelectionBy.Size = new System.Drawing.Size(384, 40);
            this.LblSelectionBy.TabIndex = 15;
            this.LblSelectionBy.Text = "Выборка по ";
            this.LblSelectionBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CbxParameter
            // 
            this.CbxParameter.BackColor = System.Drawing.Color.White;
            this.CbxParameter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxParameter.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbxParameter.FormattingEnabled = true;
            this.CbxParameter.Location = new System.Drawing.Point(784, 56);
            this.CbxParameter.Name = "CbxParameter";
            this.CbxParameter.Size = new System.Drawing.Size(304, 33);
            this.CbxParameter.TabIndex = 17;
            this.CbxParameter.SelectedIndexChanged += new System.EventHandler(this.CbxParameter_SelectedIndexChanged);
            // 
            // LblParameter
            // 
            this.LblParameter.BackColor = System.Drawing.Color.DarkGray;
            this.LblParameter.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblParameter.ForeColor = System.Drawing.Color.White;
            this.LblParameter.Location = new System.Drawing.Point(784, 16);
            this.LblParameter.Name = "LblParameter";
            this.LblParameter.Size = new System.Drawing.Size(304, 40);
            this.LblParameter.TabIndex = 16;
            this.LblParameter.Text = "Параметр";
            this.LblParameter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxbSelectionBy
            // 
            this.TxbSelectionBy.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxbSelectionBy.Location = new System.Drawing.Point(364, 56);
            this.TxbSelectionBy.Name = "TxbSelectionBy";
            this.TxbSelectionBy.ReadOnly = true;
            this.TxbSelectionBy.Size = new System.Drawing.Size(384, 33);
            this.TxbSelectionBy.TabIndex = 18;
            this.TxbSelectionBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StsMainStatus
            // 
            this.StsMainStatus.AutoSize = false;
            this.StsMainStatus.BackColor = System.Drawing.Color.Gray;
            this.StsMainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SlbInfoCountElement});
            this.StsMainStatus.Location = new System.Drawing.Point(0, 496);
            this.StsMainStatus.Name = "StsMainStatus";
            this.StsMainStatus.Size = new System.Drawing.Size(1110, 28);
            this.StsMainStatus.TabIndex = 19;
            this.StsMainStatus.Text = "StsSelecetionStatus";
            // 
            // SlbInfoCountElement
            // 
            this.SlbInfoCountElement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SlbInfoCountElement.ForeColor = System.Drawing.Color.White;
            this.SlbInfoCountElement.Name = "SlbInfoCountElement";
            this.SlbInfoCountElement.Size = new System.Drawing.Size(263, 23);
            this.SlbInfoCountElement.Text = "Количество отобранных элементов";
            // 
            // SelectionByForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1110, 524);
            this.Controls.Add(this.StsMainStatus);
            this.Controls.Add(this.TxbSelectionBy);
            this.Controls.Add(this.CbxParameter);
            this.Controls.Add(this.LblParameter);
            this.Controls.Add(this.LblSelectionBy);
            this.Controls.Add(this.GbxTelevisions);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.Name = "SelectionByForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выборка по ";
            this.GbxTelevisions.ResumeLayout(false);
            this.StsMainStatus.ResumeLayout(false);
            this.StsMainStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxTelevisions;
        private System.Windows.Forms.ListBox LbxTelevisions;
        private System.Windows.Forms.Label LblHeadTelevisions;
        private System.Windows.Forms.Label LblSelectionBy;
        private System.Windows.Forms.ComboBox CbxParameter;
        private System.Windows.Forms.Label LblParameter;
        private System.Windows.Forms.TextBox TxbSelectionBy;
        private System.Windows.Forms.StatusStrip StsMainStatus;
        private System.Windows.Forms.ToolStripStatusLabel SlbInfoCountElement;
    }
}