
namespace TopSendSystem
{
    partial class TopSendControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopSendControl));
            this.panelUp = new System.Windows.Forms.Panel();
            this.TimePanel = new System.Windows.Forms.Panel();
            this.RemainTimeLable = new System.Windows.Forms.Label();
            this.RunTimeLabel = new System.Windows.Forms.Label();
            this.labRemain = new System.Windows.Forms.Label();
            this.labRun = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.uPanelCenter = new PaveSystem.UControls.UPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.cycloneFallFan = new PaveSystem.UControls.UCircleButton();
            this.cycloneGIveFan = new PaveSystem.UControls.UCircleButton();
            this.cycloneWind = new PaveSystem.UControls.UCircleButton();
            this.fallFan = new PaveSystem.UControls.UCircleButton();
            this.giveFan = new PaveSystem.UControls.UCircleButton();
            this.oxygenSet = new PaveSystem.UControls.UCircleButton();
            this.lamp7 = new ProcessSystem.lamp();
            this.lamp6 = new ProcessSystem.lamp();
            this.lamp5 = new ProcessSystem.lamp();
            this.lamp4 = new ProcessSystem.lamp();
            this.lamp3 = new ProcessSystem.lamp();
            this.lamp2 = new ProcessSystem.lamp();
            this.lamp1 = new ProcessSystem.lamp();
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
            this.panelUp.TabIndex = 4;
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
            // uPanelCenter
            // 
            this.uPanelCenter.BackColor = System.Drawing.Color.Transparent;
            this.uPanelCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uPanelCenter.BgColor = System.Drawing.Color.White;
            this.uPanelCenter.BgColor2 = System.Drawing.Color.White;
            this.uPanelCenter.BorderColor = System.Drawing.Color.Gray;
            this.uPanelCenter.BorderWidth = 0;
            this.uPanelCenter.Controls.Add(this.lamp7);
            this.uPanelCenter.Controls.Add(this.lamp6);
            this.uPanelCenter.Controls.Add(this.lamp5);
            this.uPanelCenter.Controls.Add(this.lamp4);
            this.uPanelCenter.Controls.Add(this.lamp3);
            this.uPanelCenter.Controls.Add(this.lamp2);
            this.uPanelCenter.Controls.Add(this.lamp1);
            this.uPanelCenter.Controls.Add(this.label10);
            this.uPanelCenter.Controls.Add(this.label9);
            this.uPanelCenter.Controls.Add(this.label8);
            this.uPanelCenter.Controls.Add(this.label7);
            this.uPanelCenter.Controls.Add(this.label5);
            this.uPanelCenter.Controls.Add(this.label1);
            this.uPanelCenter.Controls.Add(this.label19);
            this.uPanelCenter.Controls.Add(this.label2);
            this.uPanelCenter.Controls.Add(this.pictureBox1);
            this.uPanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uPanelCenter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uPanelCenter.Location = new System.Drawing.Point(0, 79);
            this.uPanelCenter.Name = "uPanelCenter";
            this.uPanelCenter.Radius = 0;
            this.uPanelCenter.Size = new System.Drawing.Size(894, 719);
            this.uPanelCenter.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(398, 490);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 23;
            this.label10.Text = "落粉蝶阀";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(183, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 42);
            this.label9.TabIndex = 22;
            this.label9.Text = "粉箱\r\n下极限";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(798, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 42);
            this.label8.TabIndex = 21;
            this.label8.Text = "旋风分离罐\r\n落粉蝶阀";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(801, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 42);
            this.label7.TabIndex = 20;
            this.label7.Text = "旋风分离罐\r\n下极限";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(798, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 42);
            this.label5.TabIndex = 19;
            this.label5.Text = "旋风分离罐\r\n上极限";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(536, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 42);
            this.label1.TabIndex = 18;
            this.label1.Text = "旋风分离罐\r\n送粉蝶阀";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label19.ForeColor = System.Drawing.Color.DarkRed;
            this.label19.Location = new System.Drawing.Point(536, 58);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 42);
            this.label19.TabIndex = 16;
            this.label19.Text = "旋风分离罐\r\n回风蝶阀";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(90, 619);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "风机频率：xx Hz";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.panelRight.Controls.Add(this.cycloneFallFan);
            this.panelRight.Controls.Add(this.cycloneGIveFan);
            this.panelRight.Controls.Add(this.cycloneWind);
            this.panelRight.Controls.Add(this.fallFan);
            this.panelRight.Controls.Add(this.giveFan);
            this.panelRight.Controls.Add(this.oxygenSet);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.panelRight.Location = new System.Drawing.Point(894, 79);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(200, 719);
            this.panelRight.TabIndex = 5;
            // 
            // cycloneFallFan
            // 
            this.cycloneFallFan.BackColor = System.Drawing.Color.Transparent;
            this.cycloneFallFan.BgColor = System.Drawing.Color.CornflowerBlue;
            this.cycloneFallFan.BgColor2 = System.Drawing.Color.RoyalBlue;
            this.cycloneFallFan.BorderColor = System.Drawing.Color.Gray;
            this.cycloneFallFan.BorderWidth = 1;
            this.cycloneFallFan.FlatAppearance.BorderSize = 0;
            this.cycloneFallFan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cycloneFallFan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cycloneFallFan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cycloneFallFan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.cycloneFallFan.ForeColor = System.Drawing.Color.White;
            this.cycloneFallFan.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.cycloneFallFan.Location = new System.Drawing.Point(12, 402);
            this.cycloneFallFan.MouseDownBgColor = System.Drawing.Color.RoyalBlue;
            this.cycloneFallFan.MouseDownFColor = System.Drawing.Color.White;
            this.cycloneFallFan.Name = "cycloneFallFan";
            this.cycloneFallFan.Radius = 0;
            this.cycloneFallFan.Size = new System.Drawing.Size(179, 47);
            this.cycloneFallFan.TabIndex = 54;
            this.cycloneFallFan.Text = "旋风分离罐落粉蝶阀";
            this.cycloneFallFan.UseVisualStyleBackColor = false;
            // 
            // cycloneGIveFan
            // 
            this.cycloneGIveFan.BackColor = System.Drawing.Color.Transparent;
            this.cycloneGIveFan.BgColor = System.Drawing.Color.CornflowerBlue;
            this.cycloneGIveFan.BgColor2 = System.Drawing.Color.RoyalBlue;
            this.cycloneGIveFan.BorderColor = System.Drawing.Color.Gray;
            this.cycloneGIveFan.BorderWidth = 1;
            this.cycloneGIveFan.FlatAppearance.BorderSize = 0;
            this.cycloneGIveFan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cycloneGIveFan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cycloneGIveFan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cycloneGIveFan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.cycloneGIveFan.ForeColor = System.Drawing.Color.White;
            this.cycloneGIveFan.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.cycloneGIveFan.Location = new System.Drawing.Point(12, 332);
            this.cycloneGIveFan.MouseDownBgColor = System.Drawing.Color.RoyalBlue;
            this.cycloneGIveFan.MouseDownFColor = System.Drawing.Color.White;
            this.cycloneGIveFan.Name = "cycloneGIveFan";
            this.cycloneGIveFan.Radius = 0;
            this.cycloneGIveFan.Size = new System.Drawing.Size(179, 47);
            this.cycloneGIveFan.TabIndex = 53;
            this.cycloneGIveFan.Text = "旋风分离罐送粉蝶阀";
            this.cycloneGIveFan.UseVisualStyleBackColor = false;
            // 
            // cycloneWind
            // 
            this.cycloneWind.BackColor = System.Drawing.Color.Transparent;
            this.cycloneWind.BgColor = System.Drawing.Color.CornflowerBlue;
            this.cycloneWind.BgColor2 = System.Drawing.Color.RoyalBlue;
            this.cycloneWind.BorderColor = System.Drawing.Color.Gray;
            this.cycloneWind.BorderWidth = 1;
            this.cycloneWind.FlatAppearance.BorderSize = 0;
            this.cycloneWind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cycloneWind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cycloneWind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cycloneWind.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.cycloneWind.ForeColor = System.Drawing.Color.White;
            this.cycloneWind.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.cycloneWind.Location = new System.Drawing.Point(12, 259);
            this.cycloneWind.MouseDownBgColor = System.Drawing.Color.RoyalBlue;
            this.cycloneWind.MouseDownFColor = System.Drawing.Color.White;
            this.cycloneWind.Name = "cycloneWind";
            this.cycloneWind.Radius = 0;
            this.cycloneWind.Size = new System.Drawing.Size(179, 47);
            this.cycloneWind.TabIndex = 52;
            this.cycloneWind.Text = "旋风分离罐回风蝶阀";
            this.cycloneWind.UseVisualStyleBackColor = false;
            // 
            // fallFan
            // 
            this.fallFan.BackColor = System.Drawing.Color.Transparent;
            this.fallFan.BgColor = System.Drawing.Color.CornflowerBlue;
            this.fallFan.BgColor2 = System.Drawing.Color.RoyalBlue;
            this.fallFan.BorderColor = System.Drawing.Color.Gray;
            this.fallFan.BorderWidth = 1;
            this.fallFan.FlatAppearance.BorderSize = 0;
            this.fallFan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.fallFan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.fallFan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fallFan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.fallFan.ForeColor = System.Drawing.Color.White;
            this.fallFan.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.fallFan.Location = new System.Drawing.Point(12, 187);
            this.fallFan.MouseDownBgColor = System.Drawing.Color.RoyalBlue;
            this.fallFan.MouseDownFColor = System.Drawing.Color.White;
            this.fallFan.Name = "fallFan";
            this.fallFan.Radius = 0;
            this.fallFan.Size = new System.Drawing.Size(179, 47);
            this.fallFan.TabIndex = 51;
            this.fallFan.Text = "落粉蝶阀开";
            this.fallFan.UseVisualStyleBackColor = false;
            // 
            // giveFan
            // 
            this.giveFan.BackColor = System.Drawing.Color.Transparent;
            this.giveFan.BgColor = System.Drawing.Color.Gainsboro;
            this.giveFan.BgColor2 = System.Drawing.Color.WhiteSmoke;
            this.giveFan.BorderColor = System.Drawing.Color.Gray;
            this.giveFan.BorderWidth = 1;
            this.giveFan.FlatAppearance.BorderSize = 0;
            this.giveFan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.giveFan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.giveFan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.giveFan.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.giveFan.Location = new System.Drawing.Point(28, 103);
            this.giveFan.MouseDownBgColor = System.Drawing.Color.WhiteSmoke;
            this.giveFan.MouseDownFColor = System.Drawing.Color.Black;
            this.giveFan.Name = "giveFan";
            this.giveFan.Radius = 5;
            this.giveFan.Size = new System.Drawing.Size(134, 47);
            this.giveFan.TabIndex = 2;
            this.giveFan.Text = "送粉风机频率";
            this.giveFan.UseVisualStyleBackColor = false;
            // 
            // oxygenSet
            // 
            this.oxygenSet.BackColor = System.Drawing.Color.Transparent;
            this.oxygenSet.BgColor = System.Drawing.Color.Gainsboro;
            this.oxygenSet.BgColor2 = System.Drawing.Color.WhiteSmoke;
            this.oxygenSet.BorderColor = System.Drawing.Color.Gray;
            this.oxygenSet.BorderWidth = 1;
            this.oxygenSet.FlatAppearance.BorderSize = 0;
            this.oxygenSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.oxygenSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.oxygenSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oxygenSet.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.oxygenSet.Location = new System.Drawing.Point(28, 37);
            this.oxygenSet.MouseDownBgColor = System.Drawing.Color.WhiteSmoke;
            this.oxygenSet.MouseDownFColor = System.Drawing.Color.Black;
            this.oxygenSet.Name = "oxygenSet";
            this.oxygenSet.Radius = 5;
            this.oxygenSet.Size = new System.Drawing.Size(134, 47);
            this.oxygenSet.TabIndex = 0;
            this.oxygenSet.Text = "氧含量设置";
            this.oxygenSet.UseVisualStyleBackColor = false;
            // 
            // lamp7
            // 
            this.lamp7.BackColor = System.Drawing.Color.Transparent;
            this.lamp7.Location = new System.Drawing.Point(196, 350);
            this.lamp7.Name = "lamp7";
            this.lamp7.Size = new System.Drawing.Size(34, 34);
            this.lamp7.TabIndex = 30;
            // 
            // lamp6
            // 
            this.lamp6.BackColor = System.Drawing.Color.Transparent;
            this.lamp6.Location = new System.Drawing.Point(358, 483);
            this.lamp6.Name = "lamp6";
            this.lamp6.Size = new System.Drawing.Size(34, 34);
            this.lamp6.TabIndex = 29;
            // 
            // lamp5
            // 
            this.lamp5.BackColor = System.Drawing.Color.Transparent;
            this.lamp5.Location = new System.Drawing.Point(768, 334);
            this.lamp5.Name = "lamp5";
            this.lamp5.Size = new System.Drawing.Size(34, 34);
            this.lamp5.TabIndex = 28;
            // 
            // lamp4
            // 
            this.lamp4.BackColor = System.Drawing.Color.Transparent;
            this.lamp4.Location = new System.Drawing.Point(768, 261);
            this.lamp4.Name = "lamp4";
            this.lamp4.Size = new System.Drawing.Size(34, 34);
            this.lamp4.TabIndex = 27;
            // 
            // lamp3
            // 
            this.lamp3.BackColor = System.Drawing.Color.Transparent;
            this.lamp3.Location = new System.Drawing.Point(768, 156);
            this.lamp3.Name = "lamp3";
            this.lamp3.Size = new System.Drawing.Size(34, 34);
            this.lamp3.TabIndex = 26;
            // 
            // lamp2
            // 
            this.lamp2.BackColor = System.Drawing.Color.Transparent;
            this.lamp2.Location = new System.Drawing.Point(564, 103);
            this.lamp2.Name = "lamp2";
            this.lamp2.Size = new System.Drawing.Size(34, 34);
            this.lamp2.TabIndex = 25;
            // 
            // lamp1
            // 
            this.lamp1.BackColor = System.Drawing.Color.Transparent;
            this.lamp1.Location = new System.Drawing.Point(564, 330);
            this.lamp1.Name = "lamp1";
            this.lamp1.Size = new System.Drawing.Size(34, 34);
            this.lamp1.TabIndex = 24;
            // 
            // TopSendControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.uPanelCenter);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelUp);
            this.Name = "TopSendControl";
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
        private PaveSystem.UControls.UCircleButton oxygenSet;
        private PaveSystem.UControls.UCircleButton giveFan;
        private PaveSystem.UControls.UCircleButton cycloneFallFan;
        private PaveSystem.UControls.UCircleButton cycloneGIveFan;
        private PaveSystem.UControls.UCircleButton cycloneWind;
        private PaveSystem.UControls.UCircleButton fallFan;
        private PaveSystem.UControls.UPanel uPanelCenter;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private ProcessSystem.lamp lamp7;
        private ProcessSystem.lamp lamp6;
        private ProcessSystem.lamp lamp5;
        private ProcessSystem.lamp lamp4;
        private ProcessSystem.lamp lamp3;
        private ProcessSystem.lamp lamp2;
        private ProcessSystem.lamp lamp1;
    }  
}      
       
       