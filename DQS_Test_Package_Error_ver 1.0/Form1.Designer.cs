
namespace DQS_Test_Package_Error_ver_1._0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbPortName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bStart = new System.Windows.Forms.Button();
            this.grInfor = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCounter = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLQI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbError = new System.Windows.Forms.TextBox();
            this.bRefresh = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.home = new System.Windows.Forms.ToolStripMenuItem();
            this.thongtin = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMinutes = new System.Windows.Forms.ComboBox();
            this.tbSetLQI = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bSetting = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grInfor.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPortName
            // 
            this.cbPortName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbPortName.Enabled = false;
            this.cbPortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPortName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cbPortName.FormattingEnabled = true;
            this.cbPortName.Location = new System.Drawing.Point(45, 33);
            this.cbPortName.Name = "cbPortName";
            this.cbPortName.Size = new System.Drawing.Size(271, 21);
            this.cbPortName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM";
            // 
            // bStart
            // 
            this.bStart.BackColor = System.Drawing.Color.Teal;
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bStart.Location = new System.Drawing.Point(346, 33);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(241, 46);
            this.bStart.TabIndex = 4;
            this.bStart.Text = "BẮT ĐẦU  (Q)";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // grInfor
            // 
            this.grInfor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grInfor.Controls.Add(this.label2);
            this.grInfor.Controls.Add(this.lbCounter);
            this.grInfor.Controls.Add(this.lbStatus);
            this.grInfor.Controls.Add(this.tbStatus);
            this.grInfor.Controls.Add(this.label7);
            this.grInfor.Controls.Add(this.label6);
            this.grInfor.Controls.Add(this.tbLQI);
            this.grInfor.Controls.Add(this.label5);
            this.grInfor.Controls.Add(this.tbError);
            this.grInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grInfor.Location = new System.Drawing.Point(11, 85);
            this.grInfor.Name = "grInfor";
            this.grInfor.Size = new System.Drawing.Size(576, 256);
            this.grInfor.TabIndex = 5;
            this.grInfor.TabStop = false;
            this.grInfor.Text = "Thông tin hiển thị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 39);
            this.label2.TabIndex = 12;
            this.label2.Text = "Thời gian :";
            // 
            // lbCounter
            // 
            this.lbCounter.AutoSize = true;
            this.lbCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCounter.ForeColor = System.Drawing.Color.Yellow;
            this.lbCounter.Location = new System.Drawing.Point(365, 182);
            this.lbCounter.Name = "lbCounter";
            this.lbCounter.Size = new System.Drawing.Size(157, 39);
            this.lbCounter.TabIndex = 11;
            this.lbCounter.Text = "00:00:00";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(7, 227);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(31, 17);
            this.lbStatus.TabIndex = 10;
            this.lbStatus.Text = "N/A";
            // 
            // tbStatus
            // 
            this.tbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatus.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStatus.HideSelection = false;
            this.tbStatus.Location = new System.Drawing.Point(167, 105);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.Size = new System.Drawing.Size(395, 61);
            this.tbStatus.TabIndex = 9;
            this.tbStatus.Text = "N/A";
            this.tbStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "KẾT QUẢ ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(291, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Chất lượng sóng (LQI)";
            // 
            // tbLQI
            // 
            this.tbLQI.BackColor = System.Drawing.SystemColors.Menu;
            this.tbLQI.Enabled = false;
            this.tbLQI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLQI.Location = new System.Drawing.Point(462, 47);
            this.tbLQI.Name = "tbLQI";
            this.tbLQI.ReadOnly = true;
            this.tbLQI.Size = new System.Drawing.Size(100, 26);
            this.tbLQI.TabIndex = 6;
            this.tbLQI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "% Đáp ứng gói tin";
            // 
            // tbError
            // 
            this.tbError.BackColor = System.Drawing.SystemColors.Menu;
            this.tbError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbError.Enabled = false;
            this.tbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbError.Location = new System.Drawing.Point(167, 48);
            this.tbError.Name = "tbError";
            this.tbError.ReadOnly = true;
            this.tbError.Size = new System.Drawing.Size(100, 26);
            this.tbError.TabIndex = 4;
            this.tbError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bRefresh
            // 
            this.bRefresh.BackColor = System.Drawing.Color.Teal;
            this.bRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bRefresh.Location = new System.Drawing.Point(593, 33);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(190, 46);
            this.bRefresh.TabIndex = 6;
            this.bRefresh.Text = "TẢI LẠI (W)";
            this.bRefresh.UseVisualStyleBackColor = false;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // timer
            // 
            this.timer.Interval = 60;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.home,
            this.thongtin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // home
            // 
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(71, 20);
            this.home.Text = "Thông tin";
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // thongtin
            // 
            this.thongtin.Name = "thongtin";
            this.thongtin.Size = new System.Drawing.Size(63, 20);
            this.thongtin.Text = "Trợ giúp";
            this.thongtin.Click += new System.EventHandler(this.Infor);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMinutes);
            this.groupBox1.Controls.Add(this.tbSetLQI);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.bSetting);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(593, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 256);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thiết lập thông số";
            // 
            // tbMinutes
            // 
            this.tbMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbMinutes.FormattingEnabled = true;
            this.tbMinutes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.tbMinutes.Location = new System.Drawing.Point(10, 135);
            this.tbMinutes.Name = "tbMinutes";
            this.tbMinutes.Size = new System.Drawing.Size(120, 28);
            this.tbMinutes.TabIndex = 13;
            this.tbMinutes.SelectedIndexChanged += new System.EventHandler(this.tbMinutes_SelectedIndexChanged);
            // 
            // tbSetLQI
            // 
            this.tbSetLQI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbSetLQI.FormattingEnabled = true;
            this.tbSetLQI.Items.AddRange(new object[] {
            "50",
            "60",
            "70"});
            this.tbSetLQI.Location = new System.Drawing.Point(10, 60);
            this.tbSetLQI.Name = "tbSetLQI";
            this.tbSetLQI.Size = new System.Drawing.Size(167, 28);
            this.tbSetLQI.TabIndex = 9;
            this.tbSetLQI.SelectedIndexChanged += new System.EventHandler(this.tbSetLQI_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "phút";
            // 
            // bSetting
            // 
            this.bSetting.BackColor = System.Drawing.SystemColors.Control;
            this.bSetting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bSetting.Location = new System.Drawing.Point(54, 192);
            this.bSetting.Name = "bSetting";
            this.bSetting.Size = new System.Drawing.Size(96, 30);
            this.bSetting.TabIndex = 10;
            this.bSetting.Text = "Lưu";
            this.bSetting.UseVisualStyleBackColor = false;
            this.bSetting.Click += new System.EventHandler(this.bSetting_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Thiết lập thời gian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cài đặt thông số LQI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(795, 352);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bRefresh);
            this.Controls.Add(this.grInfor);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPortName);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kiểm tra chất lượng sóng Zigbee v1.0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grInfor.ResumeLayout(false);
            this.grInfor.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPortName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.GroupBox grInfor;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLQI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbError;
        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbCounter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thongtin;
        private System.Windows.Forms.ToolStripMenuItem home;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bSetting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tbMinutes;
        private System.Windows.Forms.ComboBox tbSetLQI;
    }
}

