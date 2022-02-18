namespace HomeWork.Views
{
    partial class SelectionParamsForm
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
            this.CbxSelectionParams = new System.Windows.Forms.ComboBox();
            this.LblParams = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CbxSelectionParams
            // 
            this.CbxSelectionParams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxSelectionParams.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbxSelectionParams.FormattingEnabled = true;
            this.CbxSelectionParams.Location = new System.Drawing.Point(24, 64);
            this.CbxSelectionParams.Name = "CbxSelectionParams";
            this.CbxSelectionParams.Size = new System.Drawing.Size(328, 26);
            this.CbxSelectionParams.TabIndex = 11;
            // 
            // LblParams
            // 
            this.LblParams.BackColor = System.Drawing.Color.DarkGray;
            this.LblParams.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblParams.Location = new System.Drawing.Point(24, 24);
            this.LblParams.Name = "LblParams";
            this.LblParams.Size = new System.Drawing.Size(328, 40);
            this.LblParams.TabIndex = 10;
            this.LblParams.Text = "Выбор параметра";
            this.LblParams.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCancel.Location = new System.Drawing.Point(208, 112);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(145, 48);
            this.BtnCancel.TabIndex = 13;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnOk
            // 
            this.BtnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BtnOk.BackColor = System.Drawing.Color.Silver;
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnOk.Location = new System.Drawing.Point(24, 112);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(145, 48);
            this.BtnOk.TabIndex = 12;
            this.BtnOk.Text = "Выбрать";
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // SelectionParamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(372, 181);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.CbxSelectionParams);
            this.Controls.Add(this.LblParams);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.Name = "SelectionParamsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Параметры выборки";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox CbxSelectionParams;
        private System.Windows.Forms.Label LblParams;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOk;
    }
}