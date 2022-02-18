namespace HomeWorkWF
{
    partial class MainForm
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
            this.GbxInputData = new System.Windows.Forms.GroupBox();
            this.TxbThirdNumber = new System.Windows.Forms.TextBox();
            this.LblThirdNumber = new System.Windows.Forms.Label();
            this.TxbSecondNumber = new System.Windows.Forms.TextBox();
            this.LblSecondNumber = new System.Windows.Forms.Label();
            this.TxbFirstNumber = new System.Windows.Forms.TextBox();
            this.LblFirstNumber = new System.Windows.Forms.Label();
            this.GbxResult = new System.Windows.Forms.GroupBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.BtnTaskIf17 = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GbxTaskInfo = new System.Windows.Forms.GroupBox();
            this.LblTaskInfo = new System.Windows.Forms.Label();
            this.BtnTaskIf15 = new System.Windows.Forms.Button();
            this.ErpNumberA = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErpNumberB = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErpNumberC = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbxInputData.SuspendLayout();
            this.GbxResult.SuspendLayout();
            this.GbxTaskInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErpNumberA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErpNumberB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErpNumberC)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxInputData
            // 
            this.GbxInputData.BackColor = System.Drawing.Color.DimGray;
            this.GbxInputData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GbxInputData.Controls.Add(this.TxbThirdNumber);
            this.GbxInputData.Controls.Add(this.LblThirdNumber);
            this.GbxInputData.Controls.Add(this.TxbSecondNumber);
            this.GbxInputData.Controls.Add(this.LblSecondNumber);
            this.GbxInputData.Controls.Add(this.TxbFirstNumber);
            this.GbxInputData.Controls.Add(this.LblFirstNumber);
            this.GbxInputData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbxInputData.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxInputData.ForeColor = System.Drawing.Color.GhostWhite;
            this.GbxInputData.Location = new System.Drawing.Point(31, 191);
            this.GbxInputData.Name = "GbxInputData";
            this.GbxInputData.Size = new System.Drawing.Size(409, 305);
            this.GbxInputData.TabIndex = 6;
            this.GbxInputData.TabStop = false;
            this.GbxInputData.Text = " Ввод данных ";
            // 
            // TxbThirdNumber
            // 
            this.TxbThirdNumber.BackColor = System.Drawing.Color.Silver;
            this.TxbThirdNumber.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxbThirdNumber.Location = new System.Drawing.Point(15, 255);
            this.TxbThirdNumber.Name = "TxbThirdNumber";
            this.TxbThirdNumber.Size = new System.Drawing.Size(380, 30);
            this.TxbThirdNumber.TabIndex = 5;
            this.TxbThirdNumber.Text = "0";
            this.TxbThirdNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxbThirdNumber.TextChanged += new System.EventHandler(this.TxbThirdNumber_TextChanged);
            // 
            // LblThirdNumber
            // 
            this.LblThirdNumber.BackColor = System.Drawing.Color.Gray;
            this.LblThirdNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblThirdNumber.Location = new System.Drawing.Point(16, 216);
            this.LblThirdNumber.Name = "LblThirdNumber";
            this.LblThirdNumber.Size = new System.Drawing.Size(379, 35);
            this.LblThirdNumber.TabIndex = 4;
            this.LblThirdNumber.Text = "Ввод числа C";
            this.LblThirdNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxbSecondNumber
            // 
            this.TxbSecondNumber.BackColor = System.Drawing.Color.Silver;
            this.TxbSecondNumber.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxbSecondNumber.Location = new System.Drawing.Point(15, 159);
            this.TxbSecondNumber.Name = "TxbSecondNumber";
            this.TxbSecondNumber.Size = new System.Drawing.Size(380, 30);
            this.TxbSecondNumber.TabIndex = 3;
            this.TxbSecondNumber.Text = "0";
            this.TxbSecondNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxbSecondNumber.TextChanged += new System.EventHandler(this.TxbSecondNumber_TextChanged);
            // 
            // LblSecondNumber
            // 
            this.LblSecondNumber.BackColor = System.Drawing.Color.Gray;
            this.LblSecondNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSecondNumber.Location = new System.Drawing.Point(16, 120);
            this.LblSecondNumber.Name = "LblSecondNumber";
            this.LblSecondNumber.Size = new System.Drawing.Size(379, 35);
            this.LblSecondNumber.TabIndex = 2;
            this.LblSecondNumber.Text = "Ввод числа B";
            this.LblSecondNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxbFirstNumber
            // 
            this.TxbFirstNumber.BackColor = System.Drawing.Color.Silver;
            this.TxbFirstNumber.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxbFirstNumber.Location = new System.Drawing.Point(15, 70);
            this.TxbFirstNumber.Name = "TxbFirstNumber";
            this.TxbFirstNumber.Size = new System.Drawing.Size(380, 30);
            this.TxbFirstNumber.TabIndex = 1;
            this.TxbFirstNumber.Text = "0";
            this.TxbFirstNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxbFirstNumber.TextChanged += new System.EventHandler(this.TxbFirstNumber_TextChanged);
            // 
            // LblFirstNumber
            // 
            this.LblFirstNumber.BackColor = System.Drawing.Color.Gray;
            this.LblFirstNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblFirstNumber.Location = new System.Drawing.Point(16, 31);
            this.LblFirstNumber.Name = "LblFirstNumber";
            this.LblFirstNumber.Size = new System.Drawing.Size(379, 35);
            this.LblFirstNumber.TabIndex = 0;
            this.LblFirstNumber.Text = "Ввод числа A";
            this.LblFirstNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GbxResult
            // 
            this.GbxResult.BackColor = System.Drawing.Color.DimGray;
            this.GbxResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GbxResult.Controls.Add(this.LblResult);
            this.GbxResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbxResult.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GbxResult.ForeColor = System.Drawing.Color.GhostWhite;
            this.GbxResult.Location = new System.Drawing.Point(459, 191);
            this.GbxResult.Name = "GbxResult";
            this.GbxResult.Size = new System.Drawing.Size(341, 305);
            this.GbxResult.TabIndex = 7;
            this.GbxResult.TabStop = false;
            this.GbxResult.Text = " Результат ";
            // 
            // LblResult
            // 
            this.LblResult.AllowDrop = true;
            this.LblResult.BackColor = System.Drawing.Color.Gray;
            this.LblResult.Location = new System.Drawing.Point(24, 32);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(296, 253);
            this.LblResult.TabIndex = 0;
            this.LblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnTaskIf17
            // 
            this.BtnTaskIf17.BackColor = System.Drawing.Color.Silver;
            this.BtnTaskIf17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTaskIf17.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnTaskIf17.Location = new System.Drawing.Point(248, 576);
            this.BtnTaskIf17.Name = "BtnTaskIf17";
            this.BtnTaskIf17.Size = new System.Drawing.Size(192, 56);
            this.BtnTaskIf17.TabIndex = 8;
            this.BtnTaskIf17.Text = "Задание 2 (If17)";
            this.BtnTaskIf17.UseVisualStyleBackColor = false;
            this.BtnTaskIf17.TextChanged += new System.EventHandler(this.BtnTaskIf17_Click);
            this.BtnTaskIf17.Click += new System.EventHandler(this.BtnTaskIf17_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.IndianRed;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Location = new System.Drawing.Point(640, 576);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(159, 56);
            this.BtnExit.TabIndex = 9;
            this.BtnExit.Text = "Выход";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // GbxTaskInfo
            // 
            this.GbxTaskInfo.Controls.Add(this.LblTaskInfo);
            this.GbxTaskInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbxTaskInfo.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.GbxTaskInfo.ForeColor = System.Drawing.Color.GhostWhite;
            this.GbxTaskInfo.Location = new System.Drawing.Point(31, 12);
            this.GbxTaskInfo.Name = "GbxTaskInfo";
            this.GbxTaskInfo.Size = new System.Drawing.Size(769, 173);
            this.GbxTaskInfo.TabIndex = 10;
            this.GbxTaskInfo.TabStop = false;
            this.GbxTaskInfo.Text = " Информация о задании ";
            // 
            // LblTaskInfo
            // 
            this.LblTaskInfo.BackColor = System.Drawing.Color.Gray;
            this.LblTaskInfo.Location = new System.Drawing.Point(16, 24);
            this.LblTaskInfo.Name = "LblTaskInfo";
            this.LblTaskInfo.Size = new System.Drawing.Size(738, 132);
            this.LblTaskInfo.TabIndex = 0;
            this.LblTaskInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnTaskIf15
            // 
            this.BtnTaskIf15.BackColor = System.Drawing.Color.Silver;
            this.BtnTaskIf15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTaskIf15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnTaskIf15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTaskIf15.Location = new System.Drawing.Point(31, 576);
            this.BtnTaskIf15.Name = "BtnTaskIf15";
            this.BtnTaskIf15.Size = new System.Drawing.Size(193, 56);
            this.BtnTaskIf15.TabIndex = 5;
            this.BtnTaskIf15.Text = "Задание 1 (If15)";
            this.BtnTaskIf15.UseVisualStyleBackColor = false;
            this.BtnTaskIf15.Click += new System.EventHandler(this.BtnTaskIf15_Click);
            // 
            // ErpNumberA
            // 
            this.ErpNumberA.ContainerControl = this;
            // 
            // ErpNumberB
            // 
            this.ErpNumberB.ContainerControl = this;
            // 
            // ErpNumberC
            // 
            this.ErpNumberC.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(826, 657);
            this.Controls.Add(this.GbxTaskInfo);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnTaskIf17);
            this.Controls.Add(this.GbxResult);
            this.Controls.Add(this.GbxInputData);
            this.Controls.Add(this.BtnTaskIf15);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Домашнее задание на 20.10.2021";
            this.GbxInputData.ResumeLayout(false);
            this.GbxInputData.PerformLayout();
            this.GbxResult.ResumeLayout(false);
            this.GbxTaskInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErpNumberA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErpNumberB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErpNumberC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTaskIf15;
        private System.Windows.Forms.GroupBox GbxInputData;
        private System.Windows.Forms.GroupBox GbxResult;
        private System.Windows.Forms.Button BtnTaskIf17;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblFirstNumber;
        private System.Windows.Forms.TextBox TxbFirstNumber;
        private System.Windows.Forms.TextBox TxbSecondNumber;
        private System.Windows.Forms.Label LblSecondNumber;
        private System.Windows.Forms.TextBox TxbThirdNumber;
        private System.Windows.Forms.Label LblThirdNumber;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.GroupBox GbxTaskInfo;
        private System.Windows.Forms.Label LblTaskInfo;
        private System.Windows.Forms.ErrorProvider ErpNumberA;
        private System.Windows.Forms.ErrorProvider ErpNumberB;
        private System.Windows.Forms.ErrorProvider ErpNumberC;
    }
}

