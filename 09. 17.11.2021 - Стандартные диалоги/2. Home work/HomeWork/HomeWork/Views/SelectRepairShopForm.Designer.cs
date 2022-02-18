namespace HomeWork.Views
{
    partial class SelectRepairShopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectRepairShopForm));
            this.LblSelectRepairShop = new System.Windows.Forms.Label();
            this.BtnNewRepairShop = new System.Windows.Forms.Button();
            this.BtnLoadRepairShop = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.OfdLoad = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // LblSelectRepairShop
            // 
            this.LblSelectRepairShop.BackColor = System.Drawing.Color.DarkGray;
            this.LblSelectRepairShop.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSelectRepairShop.ForeColor = System.Drawing.Color.White;
            this.LblSelectRepairShop.Location = new System.Drawing.Point(16, 24);
            this.LblSelectRepairShop.Name = "LblSelectRepairShop";
            this.LblSelectRepairShop.Size = new System.Drawing.Size(664, 64);
            this.LblSelectRepairShop.TabIndex = 16;
            this.LblSelectRepairShop.Text = "Выбор мастерской";
            this.LblSelectRepairShop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnNewRepairShop
            // 
            this.BtnNewRepairShop.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnNewRepairShop.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnNewRepairShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewRepairShop.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnNewRepairShop.ForeColor = System.Drawing.Color.White;
            this.BtnNewRepairShop.Image = global::HomeWork.Properties.Resources.calendar_add;
            this.BtnNewRepairShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNewRepairShop.Location = new System.Drawing.Point(16, 128);
            this.BtnNewRepairShop.Name = "BtnNewRepairShop";
            this.BtnNewRepairShop.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.BtnNewRepairShop.Size = new System.Drawing.Size(224, 72);
            this.BtnNewRepairShop.TabIndex = 0;
            this.BtnNewRepairShop.Text = "Создать новую мастерскую...";
            this.BtnNewRepairShop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNewRepairShop.UseVisualStyleBackColor = false;
            this.BtnNewRepairShop.Click += new System.EventHandler(this.CreateRepair_Command);
            // 
            // BtnLoadRepairShop
            // 
            this.BtnLoadRepairShop.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnLoadRepairShop.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnLoadRepairShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoadRepairShop.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnLoadRepairShop.ForeColor = System.Drawing.Color.White;
            this.BtnLoadRepairShop.Image = global::HomeWork.Properties.Resources.saved_exports;
            this.BtnLoadRepairShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLoadRepairShop.Location = new System.Drawing.Point(256, 128);
            this.BtnLoadRepairShop.Name = "BtnLoadRepairShop";
            this.BtnLoadRepairShop.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.BtnLoadRepairShop.Size = new System.Drawing.Size(240, 72);
            this.BtnLoadRepairShop.TabIndex = 1;
            this.BtnLoadRepairShop.Text = "Загрузить мастерскую...";
            this.BtnLoadRepairShop.UseVisualStyleBackColor = false;
            this.BtnLoadRepairShop.Click += new System.EventHandler(this.LoadRepair_Command);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.IndianRed;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(512, 128);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(168, 72);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Выход";
            this.BtnClose.UseVisualStyleBackColor = false;
            // 
            // OfdLoad
            // 
            this.OfdLoad.FileName = "RepairShop_Data.json";
            this.OfdLoad.Filter = "Файлы JSON (*.JSON) | *.JSON";
            this.OfdLoad.InitialDirectory = ".\\";
            this.OfdLoad.SupportMultiDottedExtensions = true;
            this.OfdLoad.Title = "Загрузить файл данных мастерской";
            this.OfdLoad.ValidateNames = false;
            // 
            // SelectRepairShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(697, 231);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnLoadRepairShop);
            this.Controls.Add(this.BtnNewRepairShop);
            this.Controls.Add(this.LblSelectRepairShop);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SelectRepairShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор мастерской";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblSelectRepairShop;
        private System.Windows.Forms.Button BtnNewRepairShop;
        private System.Windows.Forms.Button BtnLoadRepairShop;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.OpenFileDialog OfdLoad;
    }
}