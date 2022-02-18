namespace HomeWork.Views
{
    partial class ApplianceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplianceForm));
            this.label1 = new System.Windows.Forms.Label();
            this.LblPower = new System.Windows.Forms.Label();
            this.TbxTitle = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblState = new System.Windows.Forms.Label();
            this.TbxCurrentPrice = new System.Windows.Forms.TextBox();
            this.LblCurrentPrice = new System.Windows.Forms.Label();
            this.TbxCurrentPower = new System.Windows.Forms.TextBox();
            this.LblCurrentPower = new System.Windows.Forms.Label();
            this.TbxCurrentTitle = new System.Windows.Forms.TextBox();
            this.LblCurrentTitle = new System.Windows.Forms.Label();
            this.TbxCurrentState = new System.Windows.Forms.TextBox();
            this.LblCurrentState = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.CbxState = new System.Windows.Forms.ComboBox();
            this.NudPrice = new System.Windows.Forms.NumericUpDown();
            this.NudPower = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPower)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(352, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 40);
            this.label1.TabIndex = 14;
            this.label1.Text = "Цена";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPower
            // 
            this.LblPower.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblPower.BackColor = System.Drawing.Color.DarkGray;
            this.LblPower.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPower.Location = new System.Drawing.Point(16, 296);
            this.LblPower.Name = "LblPower";
            this.LblPower.Size = new System.Drawing.Size(320, 40);
            this.LblPower.TabIndex = 12;
            this.LblPower.Text = "Мощность";
            this.LblPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbxTitle
            // 
            this.TbxTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TbxTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.TbxTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxTitle.Location = new System.Drawing.Point(352, 248);
            this.TbxTitle.Name = "TbxTitle";
            this.TbxTitle.Size = new System.Drawing.Size(320, 27);
            this.TbxTitle.TabIndex = 1;
            this.TbxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbxTitle.Validating += new System.ComponentModel.CancelEventHandler(this.TbxTitle_Validating);
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblTitle.BackColor = System.Drawing.Color.DarkGray;
            this.LblTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTitle.Location = new System.Drawing.Point(352, 208);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(320, 40);
            this.LblTitle.TabIndex = 10;
            this.LblTitle.Text = " Название";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblState
            // 
            this.LblState.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblState.BackColor = System.Drawing.Color.DarkGray;
            this.LblState.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblState.Location = new System.Drawing.Point(16, 208);
            this.LblState.Name = "LblState";
            this.LblState.Size = new System.Drawing.Size(320, 40);
            this.LblState.TabIndex = 8;
            this.LblState.Text = " Состояние ";
            this.LblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbxCurrentPrice
            // 
            this.TbxCurrentPrice.BackColor = System.Drawing.Color.Silver;
            this.TbxCurrentPrice.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxCurrentPrice.Location = new System.Drawing.Point(352, 152);
            this.TbxCurrentPrice.Name = "TbxCurrentPrice";
            this.TbxCurrentPrice.ReadOnly = true;
            this.TbxCurrentPrice.Size = new System.Drawing.Size(320, 27);
            this.TbxCurrentPrice.TabIndex = 23;
            this.TbxCurrentPrice.TabStop = false;
            this.TbxCurrentPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblCurrentPrice
            // 
            this.LblCurrentPrice.BackColor = System.Drawing.Color.DarkGray;
            this.LblCurrentPrice.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCurrentPrice.Location = new System.Drawing.Point(352, 112);
            this.LblCurrentPrice.Name = "LblCurrentPrice";
            this.LblCurrentPrice.Size = new System.Drawing.Size(320, 40);
            this.LblCurrentPrice.TabIndex = 22;
            this.LblCurrentPrice.Text = "Текущая цена";
            this.LblCurrentPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbxCurrentPower
            // 
            this.TbxCurrentPower.BackColor = System.Drawing.Color.Silver;
            this.TbxCurrentPower.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxCurrentPower.Location = new System.Drawing.Point(16, 152);
            this.TbxCurrentPower.Name = "TbxCurrentPower";
            this.TbxCurrentPower.ReadOnly = true;
            this.TbxCurrentPower.Size = new System.Drawing.Size(320, 27);
            this.TbxCurrentPower.TabIndex = 21;
            this.TbxCurrentPower.TabStop = false;
            this.TbxCurrentPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblCurrentPower
            // 
            this.LblCurrentPower.BackColor = System.Drawing.Color.DarkGray;
            this.LblCurrentPower.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCurrentPower.Location = new System.Drawing.Point(16, 112);
            this.LblCurrentPower.Name = "LblCurrentPower";
            this.LblCurrentPower.Size = new System.Drawing.Size(320, 40);
            this.LblCurrentPower.TabIndex = 20;
            this.LblCurrentPower.Text = "Текущая мощность";
            this.LblCurrentPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbxCurrentTitle
            // 
            this.TbxCurrentTitle.BackColor = System.Drawing.Color.Silver;
            this.TbxCurrentTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxCurrentTitle.Location = new System.Drawing.Point(352, 64);
            this.TbxCurrentTitle.Name = "TbxCurrentTitle";
            this.TbxCurrentTitle.ReadOnly = true;
            this.TbxCurrentTitle.Size = new System.Drawing.Size(320, 27);
            this.TbxCurrentTitle.TabIndex = 19;
            this.TbxCurrentTitle.TabStop = false;
            this.TbxCurrentTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblCurrentTitle
            // 
            this.LblCurrentTitle.BackColor = System.Drawing.Color.DarkGray;
            this.LblCurrentTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCurrentTitle.Location = new System.Drawing.Point(352, 24);
            this.LblCurrentTitle.Name = "LblCurrentTitle";
            this.LblCurrentTitle.Size = new System.Drawing.Size(320, 40);
            this.LblCurrentTitle.TabIndex = 18;
            this.LblCurrentTitle.Text = "Текущее название";
            this.LblCurrentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbxCurrentState
            // 
            this.TbxCurrentState.BackColor = System.Drawing.Color.Silver;
            this.TbxCurrentState.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxCurrentState.Location = new System.Drawing.Point(16, 64);
            this.TbxCurrentState.Name = "TbxCurrentState";
            this.TbxCurrentState.ReadOnly = true;
            this.TbxCurrentState.Size = new System.Drawing.Size(320, 27);
            this.TbxCurrentState.TabIndex = 17;
            this.TbxCurrentState.TabStop = false;
            this.TbxCurrentState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblCurrentState
            // 
            this.LblCurrentState.BackColor = System.Drawing.Color.DarkGray;
            this.LblCurrentState.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCurrentState.Location = new System.Drawing.Point(16, 24);
            this.LblCurrentState.Name = "LblCurrentState";
            this.LblCurrentState.Size = new System.Drawing.Size(320, 40);
            this.LblCurrentState.TabIndex = 16;
            this.LblCurrentState.Text = "Текущее состояние";
            this.LblCurrentState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnOk
            // 
            this.BtnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BtnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnOk.BackColor = System.Drawing.Color.Silver;
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnOk.Location = new System.Drawing.Point(352, 384);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(152, 48);
            this.BtnOk.TabIndex = 4;
            this.BtnOk.Text = "Изменить";
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCancel.Location = new System.Drawing.Point(520, 384);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(152, 48);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // CbxState
            // 
            this.CbxState.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CbxState.BackColor = System.Drawing.Color.Gainsboro;
            this.CbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxState.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbxState.FormattingEnabled = true;
            this.CbxState.Items.AddRange(new object[] {
            "Включен",
            "Выключен"});
            this.CbxState.Location = new System.Drawing.Point(16, 248);
            this.CbxState.Name = "CbxState";
            this.CbxState.Size = new System.Drawing.Size(320, 26);
            this.CbxState.TabIndex = 0;
            // 
            // NudPrice
            // 
            this.NudPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NudPrice.BackColor = System.Drawing.Color.Gainsboro;
            this.NudPrice.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NudPrice.Location = new System.Drawing.Point(352, 336);
            this.NudPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NudPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudPrice.Name = "NudPrice";
            this.NudPrice.Size = new System.Drawing.Size(320, 27);
            this.NudPrice.TabIndex = 3;
            this.NudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NudPower
            // 
            this.NudPower.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NudPower.BackColor = System.Drawing.Color.Gainsboro;
            this.NudPower.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NudPower.Location = new System.Drawing.Point(16, 336);
            this.NudPower.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NudPower.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudPower.Name = "NudPower";
            this.NudPower.Size = new System.Drawing.Size(320, 27);
            this.NudPower.TabIndex = 24;
            this.NudPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudPower.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ApplianceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.NudPower);
            this.Controls.Add(this.NudPrice);
            this.Controls.Add(this.CbxState);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.TbxCurrentPrice);
            this.Controls.Add(this.LblCurrentPrice);
            this.Controls.Add(this.TbxCurrentPower);
            this.Controls.Add(this.LblCurrentPower);
            this.Controls.Add(this.TbxCurrentTitle);
            this.Controls.Add(this.LblCurrentTitle);
            this.Controls.Add(this.TbxCurrentState);
            this.Controls.Add(this.LblCurrentState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblPower);
            this.Controls.Add(this.TbxTitle);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.LblState);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "ApplianceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение прибора";
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblPower;
        private System.Windows.Forms.TextBox TbxTitle;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblState;
        private System.Windows.Forms.TextBox TbxCurrentPrice;
        private System.Windows.Forms.Label LblCurrentPrice;
        private System.Windows.Forms.TextBox TbxCurrentPower;
        private System.Windows.Forms.Label LblCurrentPower;
        private System.Windows.Forms.TextBox TbxCurrentTitle;
        private System.Windows.Forms.Label LblCurrentTitle;
        private System.Windows.Forms.TextBox TbxCurrentState;
        private System.Windows.Forms.Label LblCurrentState;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ComboBox CbxState;
        private System.Windows.Forms.NumericUpDown NudPrice;
        private System.Windows.Forms.NumericUpDown NudPower;
    }
}