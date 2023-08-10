
namespace ProcessSystem
{
    partial class ProcessControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessControl));
            this.panelUp = new System.Windows.Forms.Panel();
            this.TimePanel = new System.Windows.Forms.Panel();
            this.RemainTimeLable = new System.Windows.Forms.Label();
            this.RunTimeLabel = new System.Windows.Forms.Label();
            this.labRemain = new System.Windows.Forms.Label();
            this.labRun = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.printPressureSet = new PaveSystem.UControls.UCircleButton();
            this.oxygenSet = new PaveSystem.UControls.UCircleButton();
            this.uPanelCenter = new PaveSystem.UControls.UPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lamp5 = new ProcessSystem.lamp();
            this.lamp4 = new ProcessSystem.lamp();
            this.lamp1 = new ProcessSystem.lamp();
            this.lamp3 = new ProcessSystem.lamp();
            this.lamp2 = new ProcessSystem.lamp();
            this.panelUp.SuspendLayout();
            this.TimePanel.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.uPanelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRight.Controls.Add(this.printPressureSet);
            this.panelRight.Controls.Add(this.oxygenSet);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.panelRight.Location = new System.Drawing.Point(894, 79);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(200, 719);
            this.panelRight.TabIndex = 5;
            // 
            // printPressureSet
            // 
            this.printPressureSet.BackColor = System.Drawing.Color.Transparent;
            this.printPressureSet.BgColor = System.Drawing.Color.CornflowerBlue;
            this.printPressureSet.BgColor2 = System.Drawing.Color.RoyalBlue;
            this.printPressureSet.BorderColor = System.Drawing.Color.Gray;
            this.printPressureSet.BorderWidth = 1;
            this.printPressureSet.FlatAppearance.BorderSize = 0;
            this.printPressureSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.printPressureSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.printPressureSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printPressureSet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.printPressureSet.ForeColor = System.Drawing.Color.White;
            this.printPressureSet.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.printPressureSet.Location = new System.Drawing.Point(32, 113);
            this.printPressureSet.MouseDownBgColor = System.Drawing.Color.RoyalBlue;
            this.printPressureSet.MouseDownFColor = System.Drawing.Color.White;
            this.printPressureSet.Name = "printPressureSet";
            this.printPressureSet.Radius = 0;
            this.printPressureSet.Size = new System.Drawing.Size(140, 48);
            this.printPressureSet.TabIndex = 47;
            this.printPressureSet.Text = "打印仓压力设置";
            this.printPressureSet.UseVisualStyleBackColor = false;
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
            this.oxygenSet.ForeColor = System.Drawing.Color.Black;
            this.oxygenSet.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.oxygenSet.Location = new System.Drawing.Point(43, 30);
            this.oxygenSet.MouseDownBgColor = System.Drawing.Color.WhiteSmoke;
            this.oxygenSet.MouseDownFColor = System.Drawing.Color.Black;
            this.oxygenSet.Name = "oxygenSet";
            this.oxygenSet.Radius = 5;
            this.oxygenSet.Size = new System.Drawing.Size(114, 48);
            this.oxygenSet.TabIndex = 0;
            this.oxygenSet.Text = "氧含量设置";
            this.oxygenSet.UseVisualStyleBackColor = false;
            // 
            // uPanelCenter
            // 
            this.uPanelCenter.BackColor = System.Drawing.Color.Transparent;
            this.uPanelCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uPanelCenter.BgColor = System.Drawing.Color.White;
            this.uPanelCenter.BgColor2 = System.Drawing.Color.White;
            this.uPanelCenter.BorderColor = System.Drawing.Color.Gray;
            this.uPanelCenter.BorderWidth = 0;
            this.uPanelCenter.Controls.Add(this.lamp5);
            this.uPanelCenter.Controls.Add(this.lamp4);
            this.uPanelCenter.Controls.Add(this.lamp1);
            this.uPanelCenter.Controls.Add(this.lamp3);
            this.uPanelCenter.Controls.Add(this.lamp2);
            this.uPanelCenter.Controls.Add(this.label20);
            this.uPanelCenter.Controls.Add(this.label19);
            this.uPanelCenter.Controls.Add(this.label18);
            this.uPanelCenter.Controls.Add(this.label17);
            this.uPanelCenter.Controls.Add(this.label16);
            this.uPanelCenter.Controls.Add(this.label15);
            this.uPanelCenter.Controls.Add(this.label14);
            this.uPanelCenter.Controls.Add(this.label13);
            this.uPanelCenter.Controls.Add(this.label9);
            this.uPanelCenter.Controls.Add(this.label10);
            this.uPanelCenter.Controls.Add(this.label11);
            this.uPanelCenter.Controls.Add(this.label12);
            this.uPanelCenter.Controls.Add(this.label8);
            this.uPanelCenter.Controls.Add(this.label7);
            this.uPanelCenter.Controls.Add(this.label5);
            this.uPanelCenter.Controls.Add(this.label2);
            this.uPanelCenter.Controls.Add(this.label1);
            this.uPanelCenter.Controls.Add(this.pictureBox1);
            this.uPanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uPanelCenter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uPanelCenter.Location = new System.Drawing.Point(0, 79);
            this.uPanelCenter.Name = "uPanelCenter";
            this.uPanelCenter.Radius = 0;
            this.uPanelCenter.Size = new System.Drawing.Size(894, 719);
            this.uPanelCenter.TabIndex = 18;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label20.ForeColor = System.Drawing.Color.DarkRed;
            this.label20.Location = new System.Drawing.Point(802, 275);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 42);
            this.label20.TabIndex = 17;
            this.label20.Text = "过滤器\r\n入口蝶阀";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label19.ForeColor = System.Drawing.Color.DarkRed;
            this.label19.Location = new System.Drawing.Point(734, 130);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 21);
            this.label19.TabIndex = 16;
            this.label19.Text = "过滤器出口蝶阀";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label18.ForeColor = System.Drawing.Color.DarkRed;
            this.label18.Location = new System.Drawing.Point(306, 244);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 21);
            this.label18.TabIndex = 15;
            this.label18.Text = "小氮";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label17.ForeColor = System.Drawing.Color.DarkRed;
            this.label17.Location = new System.Drawing.Point(225, 244);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 21);
            this.label17.TabIndex = 14;
            this.label17.Text = "大氮";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label16.ForeColor = System.Drawing.Color.DarkRed;
            this.label16.Location = new System.Drawing.Point(138, 244);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 21);
            this.label16.TabIndex = 13;
            this.label16.Text = "排气阀";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label15.ForeColor = System.Drawing.Color.DarkRed;
            this.label15.Location = new System.Drawing.Point(509, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(187, 21);
            this.label15.TabIndex = 12;
            this.label15.Text = "回风管道氧含量：mm %";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label14.ForeColor = System.Drawing.Color.DarkRed;
            this.label14.Location = new System.Drawing.Point(520, 434);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 21);
            this.label14.TabIndex = 11;
            this.label14.Text = "风速2：xx mm/s";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(454, 265);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 21);
            this.label13.TabIndex = 10;
            this.label13.Text = "风速1：xx mm/s";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(616, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "湿   度：mm %";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(616, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "温   度：mm ℃";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(616, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 21);
            this.label11.TabIndex = 7;
            this.label11.Text = "管内参数：";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(616, 265);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 21);
            this.label12.TabIndex = 6;
            this.label12.Text = "氧含量：mm %";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(172, 625);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "湿   度：mm %";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(172, 604);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "温   度：mm ℃";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(172, 583);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "压   力：mm Pa";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(172, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "腔内参数：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(172, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "氧含量：mm %";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // lamp5
            // 
            this.lamp5.BackColor = System.Drawing.Color.Transparent;
            this.lamp5.Location = new System.Drawing.Point(857, 237);
            this.lamp5.Name = "lamp5";
            this.lamp5.Size = new System.Drawing.Size(29, 28);
            this.lamp5.TabIndex = 23;
            // 
            // lamp4
            // 
            this.lamp4.BackColor = System.Drawing.Color.Transparent;
            this.lamp4.Location = new System.Drawing.Point(782, 154);
            this.lamp4.Name = "lamp4";
            this.lamp4.Size = new System.Drawing.Size(29, 28);
            this.lamp4.TabIndex = 22;
            // 
            // lamp1
            // 
            this.lamp1.BackColor = System.Drawing.Color.Transparent;
            this.lamp1.Location = new System.Drawing.Point(152, 268);
            this.lamp1.Name = "lamp1";
            this.lamp1.Size = new System.Drawing.Size(29, 28);
            this.lamp1.TabIndex = 21;
            // 
            // lamp3
            // 
            this.lamp3.BackColor = System.Drawing.Color.Transparent;
            this.lamp3.Location = new System.Drawing.Point(310, 268);
            this.lamp3.Name = "lamp3";
            this.lamp3.Size = new System.Drawing.Size(29, 28);
            this.lamp3.TabIndex = 20;
            // 
            // lamp2
            // 
            this.lamp2.BackColor = System.Drawing.Color.Transparent;
            this.lamp2.Location = new System.Drawing.Point(233, 268);
            this.lamp2.Name = "lamp2";
            this.lamp2.Size = new System.Drawing.Size(29, 28);
            this.lamp2.TabIndex = 19;
            // 
            // ProcessControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.uPanelCenter);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelUp);
            this.Name = "ProcessControl";
            this.Size = new System.Drawing.Size(1094, 798);
            this.panelUp.ResumeLayout(false);
            this.TimePanel.ResumeLayout(false);
            this.TimePanel.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.uPanelCenter.ResumeLayout(false);
            this.uPanelCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Panel TimePanel;
        private System.Windows.Forms.Label RemainTimeLable;
        private System.Windows.Forms.Label RunTimeLabel;
        private System.Windows.Forms.Label labRemain;
        private System.Windows.Forms.Label labRun;
        private System.Windows.Forms.Panel panelRight;
        private PaveSystem.UControls.UCircleButton oxygenSet;
        private PaveSystem.UControls.UCircleButton printPressureSet;
        private PaveSystem.UControls.UPanel uPanelCenter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private lamp lamp3;
        private lamp lamp2;
        private lamp lamp5;
        private lamp lamp4;
        private lamp lamp1;

    }
}
