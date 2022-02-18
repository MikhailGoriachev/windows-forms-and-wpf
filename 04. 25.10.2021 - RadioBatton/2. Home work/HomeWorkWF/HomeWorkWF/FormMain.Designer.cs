namespace HomeWorkWF
{
    partial class FormMain
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
            this.LblMenu = new System.Windows.Forms.Label();
            this.BtnMenuConoid = new System.Windows.Forms.Button();
            this.BtnMenuSphere = new System.Windows.Forms.Button();
            this.BtnMenuRectParall = new System.Windows.Forms.Button();
            this.BtnMenuCylinder = new System.Windows.Forms.Button();
            this.BtnMenuInfo = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblMenu
            // 
            this.LblMenu.BackColor = System.Drawing.Color.DarkGray;
            this.LblMenu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblMenu.ForeColor = System.Drawing.Color.Transparent;
            this.LblMenu.Location = new System.Drawing.Point(64, 24);
            this.LblMenu.Name = "LblMenu";
            this.LblMenu.Size = new System.Drawing.Size(368, 56);
            this.LblMenu.TabIndex = 0;
            this.LblMenu.Text = "Главное меню";
            this.LblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnMenuConoid
            // 
            this.BtnMenuConoid.BackColor = System.Drawing.Color.Gray;
            this.BtnMenuConoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenuConoid.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMenuConoid.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMenuConoid.Location = new System.Drawing.Point(64, 120);
            this.BtnMenuConoid.Name = "BtnMenuConoid";
            this.BtnMenuConoid.Size = new System.Drawing.Size(368, 64);
            this.BtnMenuConoid.TabIndex = 0;
            this.BtnMenuConoid.Text = "Усечённый конус";
            this.BtnMenuConoid.UseVisualStyleBackColor = false;
            this.BtnMenuConoid.Click += new System.EventHandler(this.BtnMenuConoid_Click);
            // 
            // BtnMenuSphere
            // 
            this.BtnMenuSphere.BackColor = System.Drawing.Color.Gray;
            this.BtnMenuSphere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenuSphere.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMenuSphere.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMenuSphere.Location = new System.Drawing.Point(64, 200);
            this.BtnMenuSphere.Name = "BtnMenuSphere";
            this.BtnMenuSphere.Size = new System.Drawing.Size(368, 64);
            this.BtnMenuSphere.TabIndex = 1;
            this.BtnMenuSphere.Text = "Сфера";
            this.BtnMenuSphere.UseVisualStyleBackColor = false;
            this.BtnMenuSphere.Click += new System.EventHandler(this.BtnMenuSphere_Click);
            // 
            // BtnMenuRectParall
            // 
            this.BtnMenuRectParall.BackColor = System.Drawing.Color.Gray;
            this.BtnMenuRectParall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenuRectParall.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMenuRectParall.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMenuRectParall.Location = new System.Drawing.Point(64, 360);
            this.BtnMenuRectParall.Name = "BtnMenuRectParall";
            this.BtnMenuRectParall.Size = new System.Drawing.Size(368, 64);
            this.BtnMenuRectParall.TabIndex = 3;
            this.BtnMenuRectParall.Text = "Прямоугольный параллелепипед";
            this.BtnMenuRectParall.UseVisualStyleBackColor = false;
            this.BtnMenuRectParall.Click += new System.EventHandler(this.BtnMenuRectParall_Click);
            // 
            // BtnMenuCylinder
            // 
            this.BtnMenuCylinder.BackColor = System.Drawing.Color.Gray;
            this.BtnMenuCylinder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenuCylinder.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMenuCylinder.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMenuCylinder.Location = new System.Drawing.Point(64, 280);
            this.BtnMenuCylinder.Name = "BtnMenuCylinder";
            this.BtnMenuCylinder.Size = new System.Drawing.Size(368, 64);
            this.BtnMenuCylinder.TabIndex = 2;
            this.BtnMenuCylinder.Text = "Цилиндр";
            this.BtnMenuCylinder.UseVisualStyleBackColor = false;
            this.BtnMenuCylinder.Click += new System.EventHandler(this.BtnMenuCylinder_Click);
            // 
            // BtnMenuInfo
            // 
            this.BtnMenuInfo.BackColor = System.Drawing.Color.Gray;
            this.BtnMenuInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenuInfo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMenuInfo.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMenuInfo.Location = new System.Drawing.Point(64, 440);
            this.BtnMenuInfo.Name = "BtnMenuInfo";
            this.BtnMenuInfo.Size = new System.Drawing.Size(368, 64);
            this.BtnMenuInfo.TabIndex = 4;
            this.BtnMenuInfo.Text = "О программе";
            this.BtnMenuInfo.UseVisualStyleBackColor = false;
            this.BtnMenuInfo.Click += new System.EventHandler(this.BtnMenuInfo_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.IndianRed;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExit.ForeColor = System.Drawing.Color.Transparent;
            this.BtnExit.Location = new System.Drawing.Point(64, 520);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(368, 64);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Выход";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(498, 609);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnMenuInfo);
            this.Controls.Add(this.BtnMenuRectParall);
            this.Controls.Add(this.BtnMenuCylinder);
            this.Controls.Add(this.BtnMenuSphere);
            this.Controls.Add(this.BtnMenuConoid);
            this.Controls.Add(this.LblMenu);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Домашнее задание на 28.10.2021";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblMenu;
        private System.Windows.Forms.Button BtnMenuConoid;
        private System.Windows.Forms.Button BtnMenuSphere;
        private System.Windows.Forms.Button BtnMenuRectParall;
        private System.Windows.Forms.Button BtnMenuCylinder;
        private System.Windows.Forms.Button BtnMenuInfo;
        private System.Windows.Forms.Button BtnExit;
    }
}

