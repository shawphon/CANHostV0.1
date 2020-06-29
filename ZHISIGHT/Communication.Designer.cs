﻿namespace ZHISIGHT
{
    partial class CommunicationForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommunicationForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCAN1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.textCAN1AccMask = new System.Windows.Forms.TextBox();
            this.textCAN1AccCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cobCAN1Mode = new System.Windows.Forms.ComboBox();
            this.labCAN1Mode = new System.Windows.Forms.Label();
            this.cobCAN1Baudrate = new System.Windows.Forms.ComboBox();
            this.labCAN1Baudrate = new System.Windows.Forms.Label();
            this.labCAN1Ind = new System.Windows.Forms.Label();
            this.tabCAN2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.textCAN2AccMask = new System.Windows.Forms.TextBox();
            this.textCAN2AccCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cobCAN2Mode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cobCAN2Baudrate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cobDevInd = new System.Windows.Forms.ComboBox();
            this.labDevInd = new System.Windows.Forms.Label();
            this.cobDevType = new System.Windows.Forms.ComboBox();
            this.labDevType = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabCAN1.SuspendLayout();
            this.tabCAN2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnSaveConfig);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 369);
            this.panel1.TabIndex = 0;
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveConfig.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnSaveConfig.Location = new System.Drawing.Point(455, 327);
            this.btnSaveConfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(104, 37);
            this.btnSaveConfig.TabIndex = 6;
            this.btnSaveConfig.Text = "保存配置";
            this.btnSaveConfig.UseVisualStyleBackColor = false;
            this.btnSaveConfig.Click += new System.EventHandler(this.BtnSaveConfig_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(9, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "*仅保存当前选中的CAN通道";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.tabControl);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(3, 157);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(574, 166);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "初始化CAN通道";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCAN1);
            this.tabControl.Controls.Add(this.tabCAN2);
            this.tabControl.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 22);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(577, 156);
            this.tabControl.TabIndex = 0;
            // 
            // tabCAN1
            // 
            this.tabCAN1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabCAN1.Controls.Add(this.label9);
            this.tabCAN1.Controls.Add(this.textCAN1AccMask);
            this.tabCAN1.Controls.Add(this.textCAN1AccCode);
            this.tabCAN1.Controls.Add(this.label6);
            this.tabCAN1.Controls.Add(this.label7);
            this.tabCAN1.Controls.Add(this.cobCAN1Mode);
            this.tabCAN1.Controls.Add(this.labCAN1Mode);
            this.tabCAN1.Controls.Add(this.cobCAN1Baudrate);
            this.tabCAN1.Controls.Add(this.labCAN1Baudrate);
            this.tabCAN1.Controls.Add(this.labCAN1Ind);
            this.tabCAN1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabCAN1.Location = new System.Drawing.Point(4, 27);
            this.tabCAN1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCAN1.Name = "tabCAN1";
            this.tabCAN1.Size = new System.Drawing.Size(569, 125);
            this.tabCAN1.TabIndex = 0;
            this.tabCAN1.Text = "CAN1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(107, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "CAN1";
            // 
            // textCAN1AccMask
            // 
            this.textCAN1AccMask.Location = new System.Drawing.Point(369, 67);
            this.textCAN1AccMask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCAN1AccMask.Name = "textCAN1AccMask";
            this.textCAN1AccMask.Size = new System.Drawing.Size(108, 26);
            this.textCAN1AccMask.TabIndex = 19;
            // 
            // textCAN1AccCode
            // 
            this.textCAN1AccCode.Location = new System.Drawing.Point(369, 38);
            this.textCAN1AccCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCAN1AccCode.Name = "textCAN1AccCode";
            this.textCAN1AccCode.Size = new System.Drawing.Size(108, 26);
            this.textCAN1AccCode.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label6.Location = new System.Drawing.Point(278, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "屏蔽码：0x";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label7.Location = new System.Drawing.Point(278, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "验收码：0x";
            // 
            // cobCAN1Mode
            // 
            this.cobCAN1Mode.FormattingEnabled = true;
            this.cobCAN1Mode.Items.AddRange(new object[] {
            "正常模式",
            "只听模式"});
            this.cobCAN1Mode.Location = new System.Drawing.Point(109, 70);
            this.cobCAN1Mode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobCAN1Mode.Name = "cobCAN1Mode";
            this.cobCAN1Mode.Size = new System.Drawing.Size(108, 26);
            this.cobCAN1Mode.TabIndex = 5;
            // 
            // labCAN1Mode
            // 
            this.labCAN1Mode.AutoSize = true;
            this.labCAN1Mode.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labCAN1Mode.Location = new System.Drawing.Point(22, 73);
            this.labCAN1Mode.Name = "labCAN1Mode";
            this.labCAN1Mode.Size = new System.Drawing.Size(84, 20);
            this.labCAN1Mode.TabIndex = 4;
            this.labCAN1Mode.Text = "工作模式：";
            // 
            // cobCAN1Baudrate
            // 
            this.cobCAN1Baudrate.FormattingEnabled = true;
            this.cobCAN1Baudrate.Items.AddRange(new object[] {
            "1000kps",
            "800kps",
            "500kps",
            "250kps",
            "125kps",
            "100kps",
            "50kps",
            "20kps",
            "10kps"});
            this.cobCAN1Baudrate.Location = new System.Drawing.Point(109, 41);
            this.cobCAN1Baudrate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobCAN1Baudrate.Name = "cobCAN1Baudrate";
            this.cobCAN1Baudrate.Size = new System.Drawing.Size(108, 26);
            this.cobCAN1Baudrate.TabIndex = 3;
            // 
            // labCAN1Baudrate
            // 
            this.labCAN1Baudrate.AutoSize = true;
            this.labCAN1Baudrate.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labCAN1Baudrate.Location = new System.Drawing.Point(36, 41);
            this.labCAN1Baudrate.Name = "labCAN1Baudrate";
            this.labCAN1Baudrate.Size = new System.Drawing.Size(69, 20);
            this.labCAN1Baudrate.TabIndex = 2;
            this.labCAN1Baudrate.Text = "波特率：";
            // 
            // labCAN1Ind
            // 
            this.labCAN1Ind.AutoSize = true;
            this.labCAN1Ind.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCAN1Ind.Location = new System.Drawing.Point(51, 14);
            this.labCAN1Ind.Name = "labCAN1Ind";
            this.labCAN1Ind.Size = new System.Drawing.Size(54, 20);
            this.labCAN1Ind.TabIndex = 0;
            this.labCAN1Ind.Text = "通道：";
            // 
            // tabCAN2
            // 
            this.tabCAN2.Controls.Add(this.label8);
            this.tabCAN2.Controls.Add(this.textCAN2AccMask);
            this.tabCAN2.Controls.Add(this.textCAN2AccCode);
            this.tabCAN2.Controls.Add(this.label5);
            this.tabCAN2.Controls.Add(this.label4);
            this.tabCAN2.Controls.Add(this.cobCAN2Mode);
            this.tabCAN2.Controls.Add(this.label1);
            this.tabCAN2.Controls.Add(this.cobCAN2Baudrate);
            this.tabCAN2.Controls.Add(this.label2);
            this.tabCAN2.Controls.Add(this.label3);
            this.tabCAN2.Location = new System.Drawing.Point(4, 27);
            this.tabCAN2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCAN2.Name = "tabCAN2";
            this.tabCAN2.Size = new System.Drawing.Size(569, 125);
            this.tabCAN2.TabIndex = 1;
            this.tabCAN2.Text = "CAN2";
            this.tabCAN2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "CAN2";
            // 
            // textCAN2AccMask
            // 
            this.textCAN2AccMask.Location = new System.Drawing.Point(369, 67);
            this.textCAN2AccMask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCAN2AccMask.Name = "textCAN2AccMask";
            this.textCAN2AccMask.Size = new System.Drawing.Size(108, 26);
            this.textCAN2AccMask.TabIndex = 15;
            // 
            // textCAN2AccCode
            // 
            this.textCAN2AccCode.Location = new System.Drawing.Point(369, 38);
            this.textCAN2AccCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCAN2AccCode.Name = "textCAN2AccCode";
            this.textCAN2AccCode.Size = new System.Drawing.Size(108, 26);
            this.textCAN2AccCode.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label5.Location = new System.Drawing.Point(281, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "屏蔽码：0x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label4.Location = new System.Drawing.Point(281, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "验收码：0x";
            // 
            // cobCAN2Mode
            // 
            this.cobCAN2Mode.FormattingEnabled = true;
            this.cobCAN2Mode.Items.AddRange(new object[] {
            "正常模式",
            "只听模式"});
            this.cobCAN2Mode.Location = new System.Drawing.Point(109, 70);
            this.cobCAN2Mode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobCAN2Mode.Name = "cobCAN2Mode";
            this.cobCAN2Mode.Size = new System.Drawing.Size(108, 26);
            this.cobCAN2Mode.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label1.Location = new System.Drawing.Point(23, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "工作模式：";
            // 
            // cobCAN2Baudrate
            // 
            this.cobCAN2Baudrate.FormattingEnabled = true;
            this.cobCAN2Baudrate.Items.AddRange(new object[] {
            "1000kps",
            "800kps",
            "666kps",
            "500kps",
            "400kps",
            "250kps",
            "200kps",
            "125kps",
            "100kps",
            "80kps",
            "50kps",
            "40kps",
            "20kps",
            "10kps"});
            this.cobCAN2Baudrate.Location = new System.Drawing.Point(109, 41);
            this.cobCAN2Baudrate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobCAN2Baudrate.Name = "cobCAN2Baudrate";
            this.cobCAN2Baudrate.Size = new System.Drawing.Size(108, 26);
            this.cobCAN2Baudrate.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label2.Location = new System.Drawing.Point(38, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "波特率：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label3.Location = new System.Drawing.Point(51, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "通道：";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.cobDevInd);
            this.panel3.Controls.Add(this.labDevInd);
            this.panel3.Controls.Add(this.cobDevType);
            this.panel3.Controls.Add(this.labDevType);
            this.panel3.Location = new System.Drawing.Point(0, 93);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(580, 59);
            this.panel3.TabIndex = 1;
            // 
            // cobDevInd
            // 
            this.cobDevInd.FormattingEnabled = true;
            this.cobDevInd.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cobDevInd.Location = new System.Drawing.Point(430, 21);
            this.cobDevInd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobDevInd.Name = "cobDevInd";
            this.cobDevInd.Size = new System.Drawing.Size(113, 23);
            this.cobDevInd.TabIndex = 3;
            // 
            // labDevInd
            // 
            this.labDevInd.AutoSize = true;
            this.labDevInd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDevInd.Location = new System.Drawing.Point(340, 21);
            this.labDevInd.Name = "labDevInd";
            this.labDevInd.Size = new System.Drawing.Size(84, 20);
            this.labDevInd.TabIndex = 2;
            this.labDevInd.Text = "设备索引号";
            // 
            // cobDevType
            // 
            this.cobDevType.FormattingEnabled = true;
            this.cobDevType.Items.AddRange(new object[] {
            "ZLGVCI_USBCANII",
            "ZLGUSBCAN-2E-U"});
            this.cobDevType.Location = new System.Drawing.Point(123, 20);
            this.cobDevType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobDevType.Name = "cobDevType";
            this.cobDevType.Size = new System.Drawing.Size(167, 23);
            this.cobDevType.TabIndex = 1;
            // 
            // labDevType
            // 
            this.labDevType.AutoSize = true;
            this.labDevType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDevType.Location = new System.Drawing.Point(15, 21);
            this.labDevType.Name = "labDevType";
            this.labDevType.Size = new System.Drawing.Size(99, 20);
            this.labDevType.TabIndex = 0;
            this.labDevType.Text = "选择设备类型";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // CommunicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(580, 369);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CommunicationForm";
            this.Text = "Communication Configuration";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabCAN1.ResumeLayout(false);
            this.tabCAN1.PerformLayout();
            this.tabCAN2.ResumeLayout(false);
            this.tabCAN2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labDevType;
        private System.Windows.Forms.ComboBox cobDevInd;
        private System.Windows.Forms.Label labDevInd;
        private System.Windows.Forms.ComboBox cobDevType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCAN1;
        private System.Windows.Forms.ComboBox cobCAN1Mode;
        private System.Windows.Forms.Label labCAN1Mode;
        private System.Windows.Forms.ComboBox cobCAN1Baudrate;
        private System.Windows.Forms.Label labCAN1Baudrate;
        private System.Windows.Forms.Label labCAN1Ind;
        private System.Windows.Forms.TabPage tabCAN2;
        private System.Windows.Forms.ComboBox cobCAN2Mode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobCAN2Baudrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCAN1AccMask;
        private System.Windows.Forms.TextBox textCAN1AccCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textCAN2AccMask;
        private System.Windows.Forms.TextBox textCAN2AccCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

