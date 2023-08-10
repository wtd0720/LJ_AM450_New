
namespace SendSystem
{
    partial class SendControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendControl));
            this.panelUp = new System.Windows.Forms.Panel();
            this.TimePanel = new System.Windows.Forms.Panel();
            this.RemainTimeLable = new System.Windows.Forms.Label();
            this.RunTimeLabel = new System.Windows.Forms.Label();
            this.labRemain = new System.Windows.Forms.Label();
            this.labRun = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.uCircleButton1 = new PaveSystem.UControls.UCircleButton();
            this.uCircleButton5 = new PaveSystem.UControls.UCircleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uPanelCenter = new PaveSystem.UControls.UPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.lamp5 = new ProcessSystem.lamp();
            this.lamp4 = new ProcessSystem.lamp();
            this.lamp3 = new ProcessSystem.lamp();
            this.lamp2 = new ProcessSystem.lamp();
            this.lamp1 = new ProcessSystem.lamp();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.sendDown = new PaveSystem.UControls.UCircleButton();
            this.sendWind = new PaveSystem.UControls.UCircleButton();
            this.sendGiveFan = new PaveSystem.UControls.UCircleButton();
            this.sendZero = new PaveSystem.UControls.UCircleButton();
            this.sendSpeedSet = new PaveSystem.UControls.UCircleButton();
            this.sendAddFan = new PaveSystem.UControls.UCircleButton();
            this.sendFall = new PaveSystem.UControls.UCircleButton();
            this.sendDistance = new System.Windows.Forms.Label();
            this.sendSpeed = new System.Windows.Forms.Label();
            this.sendConnect = new System.Windows.Forms.Label();
            this.panelUp.SuspendLayout();
            this.TimePanel.SuspendLayout();
            this.uPanelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.DarkGray;
            this.panelUp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelUp.Controls.Add(this.TimePanel);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(1094, 79);
            this.panelUp.TabIndex = 3;
            // 
            // TimePanel
            // 
            this.TimePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimePanel.BackColor = System.Drawing.Color.DimGray;
            this.TimePanel.Controls.Add(this.RemainTimeLable);
            this.TimePanel.Controls.Add(this.RunTimeLabel);
            this.TimePanel.Controls.Add(this.labRemain);
            this.TimePanel.Controls.Add(this.labRun);
            this.TimePanel.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePanel.Location = new System.Drawing.Point(841, 6);
            this.TimePanel.Name = "TimePanel";
            this.TimePanel.Size = new System.Drawing.Size(249, 68);
            this.TimePanel.TabIndex = 1;
            // 
            // RemainTimeLable
            // 
            this.RemainTimeLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RemainTimeLable.AutoSize = true;
            this.RemainTimeLable.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainTimeLable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RemainTimeLable.Location = new System.Drawing.Point(89, 42);
            this.RemainTimeLable.Name = "RemainTimeLable";
            this.RemainTimeLable.Size = new System.Drawing.Size(84, 18);
            this.RemainTimeLable.TabIndex = 6;
            this.RemainTimeLable.Text = "HH:MM:SS ";
            // 
            // RunTimeLabel
            // 
            this.RunTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RunTimeLabel.AutoSize = true;
            this.RunTimeLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunTimeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RunTimeLabel.Location = new System.Drawing.Point(89, 8);
            this.RunTimeLabel.Name = "RunTimeLabel";
            this.RunTimeLabel.Size = new System.Drawing.Size(84, 18);
            this.RunTimeLabel.TabIndex = 5;
            this.RunTimeLabel.Text = "HH:MM:SS ";
            // 
            // labRemain
            // 
            this.labRemain.AutoSize = true;
            this.labRemain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labRemain.Location = new System.Drawing.Point(9, 41);
            this.labRemain.Name = "labRemain";
            this.labRemain.Size = new System.Drawing.Size(83, 17);
            this.labRemain.TabIndex = 4;
            this.labRemain.Text = "剩余时间：";
            // 
            // labRun
            // 
            this.labRun.AutoSize = true;
            this.labRun.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labRun.Location = new System.Drawing.Point(9, 7);
            this.labRun.Name = "labRun";
            this.labRun.Size = new System.Drawing.Size(83, 17);
            this.labRun.TabIndex = 3;
            this.labRun.Text = "运行时间：";
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // uCircleButton1
            // 
            this.uCircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.uCircleButton1.BgColor = System.Drawing.Color.Gainsboro;
            this.uCircleButton1.BgColor2 = System.Drawing.Color.WhiteSmoke;
            this.uCircleButton1.BorderColor = System.Drawing.Color.Gray;
            this.uCircleButton1.BorderWidth = 1;
            this.uCircleButton1.FlatAppearance.BorderSize = 0;
            this.uCircleButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.uCircleButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.uCircleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uCircleButton1.ForeColor = System.Drawing.Color.Black;
            this.uCircleButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uCircleButton1.Location = new System.Drawing.Point(43, 204);
            this.uCircleButton1.MouseDownBgColor = System.Drawing.Color.WhiteSmoke;
            this.uCircleButton1.MouseDownFColor = System.Drawing.Color.Black;
            this.uCircleButton1.Name = "uCircleButton1";
            this.uCircleButton1.Radius = 0;
            this.uCircleButton1.Size = new System.Drawing.Size(120, 40);
            this.uCircleButton1.TabIndex = 30;
            this.uCircleButton1.Text = "手动加粉";
            this.uCircleButton1.UseVisualStyleBackColor = false;
            // 
            // uCircleButton5
            // 
            this.uCircleButton5.BackColor = System.Drawing.Color.Transparent;
            this.uCircleButton5.BgColor2 = System.Drawing.Color.White;
            this.uCircleButton5.BorderColor = System.Drawing.Color.Gray;
            this.uCircleButton5.BorderWidth = 0;
            this.uCircleButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uCircleButton5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uCircleButton5.Location = new System.Drawing.Point(0, 0);
            this.uCircleButton5.MouseDownBgColor = System.Drawing.Color.OrangeRed;
            this.uCircleButton5.MouseDownFColor = System.Drawing.Color.Blue;
            this.uCircleButton5.Name = "uCircleButton5";
            this.uCircleButton5.Radius = 5;
            this.uCircleButton5.Size = new System.Drawing.Size(80, 30);
            this.uCircleButton5.TabIndex = 0;
            this.uCircleButton5.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(39, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "扭矩:  00mm";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(35, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "实际速度:  00mm/s";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "伺服状态:  未连接";
            // 
            // uPanelCenter
            // 
            this.uPanelCenter.BackColor = System.Drawing.Color.Transparent;
            this.uPanelCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uPanelCenter.BgColor = System.Drawing.Color.White;
            this.uPanelCenter.BgColor2 = System.Drawing.Color.White;
            this.uPanelCenter.BorderColor = System.Drawing.Color.Gray;
            this.uPanelCenter.BorderWidth = 0;
            this.uPanelCenter.Controls.Add(this.label11);
            this.uPanelCenter.Controls.Add(this.lamp5);
            this.uPanelCenter.Controls.Add(this.lamp4);
            this.uPanelCenter.Controls.Add(this.lamp3);
            this.uPanelCenter.Controls.Add(this.lamp2);
            this.uPanelCenter.Controls.Add(this.lamp1);
            this.uPanelCenter.Controls.Add(this.label10);
            this.uPanelCenter.Controls.Add(this.label9);
            this.uPanelCenter.Controls.Add(this.label8);
            this.uPanelCenter.Controls.Add(this.label7);
            this.uPanelCenter.Controls.Add(this.label19);
            this.uPanelCenter.Controls.Add(this.pictureBox1);
            this.uPanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uPanelCenter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uPanelCenter.Location = new System.Drawing.Point(0, 79);
            this.uPanelCenter.Name = "uPanelCenter";
            this.uPanelCenter.Radius = 0;
            this.uPanelCenter.Size = new System.Drawing.Size(894, 719);
            this.uPanelCenter.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(518, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 21);
            this.label11.TabIndex = 26;
            this.label11.Text = "粉箱料位";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lamp5
            // 
            this.lamp5.BackColor = System.Drawing.Color.Transparent;
            this.lamp5.Location = new System.Drawing.Point(575, 548);
            this.lamp5.Name = "lamp5";
            this.lamp5.Size = new System.Drawing.Size(30, 30);
            this.lamp5.TabIndex = 25;
            // 
            // lamp4
            // 
            this.lamp4.BackColor = System.Drawing.Color.Transparent;
            this.lamp4.Location = new System.Drawing.Point(316, 548);
            this.lamp4.Name = "lamp4";
            this.lamp4.Size = new System.Drawing.Size(30, 30);
            this.lamp4.TabIndex = 24;
            // 
            // lamp3
            // 
            this.lamp3.BackColor = System.Drawing.Color.Transparent;
            this.lamp3.Location = new System.Drawing.Point(243, 307);
            this.lamp3.Name = "lamp3";
            this.lamp3.Size = new System.Drawing.Size(30, 30);
            this.lamp3.TabIndex = 23;
            // 
            // lamp2
            // 
            this.lamp2.BackColor = System.Drawing.Color.Transparent;
            this.lamp2.Location = new System.Drawing.Point(319, 92);
            this.lamp2.Name = "lamp2";
            this.lamp2.Size = new System.Drawing.Size(30, 30);
            this.lamp2.TabIndex = 22;
            // 
            // lamp1
            // 
            this.lamp1.BackColor = System.Drawing.Color.Transparent;
            this.lamp1.Location = new System.Drawing.Point(310, 223);
            this.lamp1.Name = "lamp1";
            this.lamp1.Size = new System.Drawing.Size(30, 30);
            this.lamp1.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(611, 553);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "下料位状态";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(214, 553);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "下料位状态";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(154, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "落粉蝶阀";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(150, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "上部旋风分离罐蝶阀";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label19.ForeColor = System.Drawing.Color.DarkRed;
            this.label19.Location = new System.Drawing.Point(150, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(154, 21);
            this.label19.TabIndex = 16;
            this.label19.Text = "上部旋风分离罐蝶阀";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(894, 719);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRight.Controls.Add(this.sendDown);
            this.panelRight.Controls.Add(this.sendWind);
            this.panelRight.Controls.Add(this.sendGiveFan);
            this.panelRight.Controls.Add(this.sendZero);
            this.panelRight.Controls.Add(this.sendSpeedSet);
            this.panelRight.Controls.Add(this.sendAddFan);
            this.panelRight.Controls.Add(this.sendFall);
            this.panelRight.Controls.Add(this.sendDistance);
            this.panelRight.Controls.Add(this.sendSpeed);
            this.panelRight.Controls.Add(this.sendConnect);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.panelRight.Location = new System.Drawing.Point(894, 79);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(200, 719);
            this.panelRight.TabIndex = 4;
            // 
            // sendDown
            // 
            this.sendDown.BackColor = System.Drawing.Color.Transparent;
            this.sendDown.BgColor = System.Drawing.Color.CornflowerBlue;
            this.sendDown.BgColor2 = System.Drawing.Color.RoyalBlue;
            this.sendDown.BorderColor = System.Drawing.Color.Gray;
            this.sendDown.BorderWidth = 1;
            this.sendDown.FlatAppearance.BorderSize = 0;
            this.sendDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sendDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sendDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendDown.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.sendDown.ForeColor = System.Drawing.Color.White;
            this.sendDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.sendDown.Location = new System.Drawing.Point(39, 522);
            this.sendDown.MouseDownBgColor = System.Drawing.Color.RoyalBlue;
            this.sendDown.MouseDownFColor = System.Drawing.Color.White;
            this.sendDown.Name = "sendDown";
            this.sendDown.Radius = 0;
            this.sendDown.Size = new System.Drawing.Size(134, 40);
            this.sendDown.TabIndex = 51;
            this.sendDown.Text = "落粉蝶阀";
            this.sendDown.UseVisualStyleBackColor = false;
            // 
            // sendWind
            // 
            this.sendWind.BackColor = System.Drawing.Color.Transparent;
            this.sendWind.BgColor = System.Drawing.Color.CornflowerBlue;
            this.sendWind.BgColor2 = System.Drawing.Color.RoyalBlue;
            this.sendWind.BorderColor = System.Drawing.Color.Gray;
            this.sendWind.BorderWidth = 1;
            this.sendWind.FlatAppearance.BorderSize = 0;
            this.sendWind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sendWind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sendWind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendWind.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.sendWind.ForeColor = System.Drawing.Color.White;
            this.sendWind.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.sendWind.Location = new System.Drawing.Point(39, 460);
            this.sendWind.MouseDownBgColor = System.Drawing.Color.RoyalBlue;
            this.sendWind.MouseDownFColor = System.Drawing.Color.White;
            this.sendWind.Name = "sendWind";
            this.sendWind.Radius = 0;
            this.sendWind.Size = new System.Drawing.Size(134, 40);
            this.sendWind.TabIndex = 50;
            this.sendWind.Text = "回风蝶阀";
            this.sendWind.UseVisualStyleBackColor = false;
            // 
            // sendGiveFan
            // 
            this.sendGiveFan.BackColor = System.Drawing.Color.Transparent;
            this.sendGiveFan.BgColor = System.Drawing.Color.CornflowerBlue;
            this.sendGiveFan.BgColor2 = System.Drawing.Color.RoyalBlue;
            this.sendGiveFan.BorderColor = System.Drawing.Color.Gray;
            this.sendGiveFan.BorderWidth = 1;
            this.sendGiveFan.FlatAppearance.BorderSize = 0;
            this.sendGiveFan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sendGiveFan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sendGiveFan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendGiveFan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.sendGiveFan.ForeColor = System.Drawing.Color.White;
            this.sendGiveFan.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.sendGiveFan.Location = new System.Drawing.Point(39, 399);
            this.sendGiveFan.MouseDownBgColor = System.Drawing.Color.RoyalBlue;
            this.sendGiveFan.MouseDownFColor = System.Drawing.Color.White;
            this.sendGiveFan.Name = "sendGiveFan";
            this.sendGiveFan.Radius = 0;
            this.sendGiveFan.Size = new System.Drawing.Size(134, 40);
            this.sendGiveFan.TabIndex = 49;
            this.sendGiveFan.Text = "送粉蝶阀";
            this.sendGiveFan.UseVisualStyleBackColor = false;
            // 
            // sendZero
            // 
            this.sendZero.BackColor = System.Drawing.Color.Transparent;
            this.sendZero.BgColor = System.Drawing.Color.CornflowerBlue;
            this.sendZero.BgColor2 = System.Drawing.Color.RoyalBlue;
            this.sendZero.BorderColor = System.Drawing.Color.Gray;
            this.sendZero.BorderWidth = 1;
            this.sendZero.FlatAppearance.BorderSize = 0;
            this.sendZero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sendZero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sendZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendZero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.sendZero.ForeColor = System.Drawing.Color.White;
            this.sendZero.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.sendZero.Location = new System.Drawing.Point(39, 341);
            this.sendZero.MouseDownBgColor = System.Drawing.Color.RoyalBlue;
            this.sendZero.MouseDownFColor = System.Drawing.Color.White;
            this.sendZero.Name = "sendZero";
            this.sendZero.Radius = 0;
            this.sendZero.Size = new System.Drawing.Size(134, 40);
            this.sendZero.TabIndex = 48;
            this.sendZero.Text = "落粉回零";
            this.sendZero.UseVisualStyleBackColor = false;
            // 
            // sendSpeedSet
            // 
            this.sendSpeedSet.BackColor = System.Drawing.Color.Transparent;
            this.sendSpeedSet.BgColor = System.Drawing.Color.CornflowerBlue;
            this.sendSpeedSet.BgColor2 = System.Drawing.Color.RoyalBlue;
            this.sendSpeedSet.BorderColor = System.Drawing.Color.Gray;
            this.sendSpeedSet.BorderWidth = 1;
            this.sendSpeedSet.FlatAppearance.BorderSize = 0;
            this.sendSpeedSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sendSpeedSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sendSpeedSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendSpeedSet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.sendSpeedSet.ForeColor = System.Drawing.Color.White;
            this.sendSpeedSet.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.sendSpeedSet.Location = new System.Drawing.Point(39, 281);
            this.sendSpeedSet.MouseDownBgColor = System.Drawing.Color.RoyalBlue;
            this.sendSpeedSet.MouseDownFColor = System.Drawing.Color.White;
            this.sendSpeedSet.Name = "sendSpeedSet";
            this.sendSpeedSet.Radius = 0;
            this.sendSpeedSet.Size = new System.Drawing.Size(134, 40);
            this.sendSpeedSet.TabIndex = 47;
            this.sendSpeedSet.Text = "落粉速度设置";
            this.sendSpeedSet.UseVisualStyleBackColor = false;
            // 
            // sendAddFan
            // 
            this.sendAddFan.BackColor = System.Drawing.Color.Transparent;
            this.sendAddFan.BgColor = System.Drawing.Color.Gainsboro;
            this.sendAddFan.BgColor2 = System.Drawing.Color.WhiteSmoke;
            this.sendAddFan.BorderColor = System.Drawing.Color.Gray;
            this.sendAddFan.BorderWidth = 1;
            this.sendAddFan.FlatAppearance.BorderSize = 0;
            this.sendAddFan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sendAddFan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sendAddFan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendAddFan.ForeColor = System.Drawing.Color.Black;
            this.sendAddFan.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.sendAddFan.Location = new System.Drawing.Point(43, 204);
            this.sendAddFan.MouseDownBgColor = System.Drawing.Color.WhiteSmoke;
            this.sendAddFan.MouseDownFColor = System.Drawing.Color.Black;
            this.sendAddFan.Name = "sendAddFan";
            this.sendAddFan.Radius = 0;
            this.sendAddFan.Size = new System.Drawing.Size(120, 40);
            this.sendAddFan.TabIndex = 30;
            this.sendAddFan.Text = "手动加粉";
            this.sendAddFan.UseVisualStyleBackColor = false;
            // 
            // sendFall
            // 
            this.sendFall.BackColor = System.Drawing.Color.Transparent;
            this.sendFall.BgColor = System.Drawing.Color.Gainsboro;
            this.sendFall.BgColor2 = System.Drawing.Color.WhiteSmoke;
            this.sendFall.BorderColor = System.Drawing.Color.Gray;
            this.sendFall.BorderWidth = 1;
            this.sendFall.FlatAppearance.BorderSize = 0;
            this.sendFall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sendFall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sendFall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendFall.ForeColor = System.Drawing.Color.Black;
            this.sendFall.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.sendFall.Location = new System.Drawing.Point(43, 145);
            this.sendFall.MouseDownBgColor = System.Drawing.Color.WhiteSmoke;
            this.sendFall.MouseDownFColor = System.Drawing.Color.Black;
            this.sendFall.Name = "sendFall";
            this.sendFall.Radius = 0;
            this.sendFall.Size = new System.Drawing.Size(120, 40);
            this.sendFall.TabIndex = 17;
            this.sendFall.Text = "落粉量";
            this.sendFall.UseVisualStyleBackColor = false;
            // 
            // sendDistance
            // 
            this.sendDistance.Location = new System.Drawing.Point(39, 104);
            this.sendDistance.Name = "sendDistance";
            this.sendDistance.Size = new System.Drawing.Size(150, 24);
            this.sendDistance.TabIndex = 29;
            this.sendDistance.Text = "扭矩:  00mm";
            // 
            // sendSpeed
            // 
            this.sendSpeed.Location = new System.Drawing.Point(35, 65);
            this.sendSpeed.Name = "sendSpeed";
            this.sendSpeed.Size = new System.Drawing.Size(160, 24);
            this.sendSpeed.TabIndex = 28;
            this.sendSpeed.Text = "实际速度:  00mm/s";
            // 
            // sendConnect
            // 
            this.sendConnect.Location = new System.Drawing.Point(35, 20);
            this.sendConnect.Name = "sendConnect";
            this.sendConnect.Size = new System.Drawing.Size(150, 24);
            this.sendConnect.TabIndex = 27;
            this.sendConnect.Text = "伺服状态:  未连接";
            // 
            // SendControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uPanelCenter);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelUp);
            this.Name = "SendControl";
            this.Size = new System.Drawing.Size(1094, 798);
            this.panelUp.ResumeLayout(false);
            this.TimePanel.ResumeLayout(false);
            this.TimePanel.PerformLayout();
            this.uPanelCenter.ResumeLayout(false);
            this.uPanelCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Panel TimePanel;
        private System.Windows.Forms.Label RemainTimeLable;
        private System.Windows.Forms.Label RunTimeLabel;
        private System.Windows.Forms.Label labRemain;
        private System.Windows.Forms.Label labRun;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label sendConnect;
        private System.Windows.Forms.Label sendSpeed;
        private System.Windows.Forms.Label sendDistance;
        private PaveSystem.UControls.UCircleButton sendAddFan;
        private PaveSystem.UControls.UCircleButton sendFall;
        private PaveSystem.UControls.UCircleButton sendDown;
        private PaveSystem.UControls.UCircleButton sendWind;
        private PaveSystem.UControls.UCircleButton sendGiveFan;
        private PaveSystem.UControls.UCircleButton sendZero;
        private PaveSystem.UControls.UCircleButton sendSpeedSet;
        private PaveSystem.UControls.UPanel uPanelCenter;
        private System.Windows.Forms.Label label11;
        private ProcessSystem.lamp lamp5;
        private ProcessSystem.lamp lamp4;
        private ProcessSystem.lamp lamp3;
        private ProcessSystem.lamp lamp2;
        private ProcessSystem.lamp lamp1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PaveSystem.UControls.UCircleButton uCircleButton1;
        private PaveSystem.UControls.UCircleButton uCircleButton5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;

    }
}
