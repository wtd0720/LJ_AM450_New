
namespace PaveSystem.UControls
{
    partial class UC_Home
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
            this.uPanelCenter = new PaveSystem.UControls.UPanel();
            this.uPanelRight = new PaveSystem.UControls.UPanel();
            this.tableLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.homePiston = new System.Windows.Forms.GroupBox();
            this.pistonDistance = new System.Windows.Forms.Label();
            this.pistonPause = new PaveSystem.UControls.UPictureBox();
            this.pistonSpeed = new System.Windows.Forms.Label();
            this.pistonDown = new PaveSystem.UControls.UPictureBox();
            this.pistonConnect = new System.Windows.Forms.Label();
            this.pistonUp = new PaveSystem.UControls.UPictureBox();
            this.homeBlade = new System.Windows.Forms.GroupBox();
            this.bladeDistance = new System.Windows.Forms.Label();
            this.bladeSpeed = new System.Windows.Forms.Label();
            this.bladeConnect = new System.Windows.Forms.Label();
            this.bladeLeft = new PaveSystem.UControls.UPictureBox();
            this.bladeFanDown = new PaveSystem.UControls.UCircleButton();
            this.bladeRight = new PaveSystem.UControls.UPictureBox();
            this.bladePause = new PaveSystem.UControls.UPictureBox();
            this.bladeFanUp = new PaveSystem.UControls.UCircleButton();
            this.bladeFanSpot = new PaveSystem.UControls.UCircleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uPanelRight.SuspendLayout();
            this.tableLayoutPanelLeft.SuspendLayout();
            this.homePiston.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pistonPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistonDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistonUp)).BeginInit();
            this.homeBlade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bladeLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bladeRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bladePause)).BeginInit();
            this.SuspendLayout();
            // 
            // uPanelCenter
            // 
            this.uPanelCenter.BackColor = System.Drawing.Color.Transparent;
            this.uPanelCenter.BgColor = System.Drawing.Color.White;
            this.uPanelCenter.BgColor2 = System.Drawing.Color.White;
            this.uPanelCenter.BorderColor = System.Drawing.Color.Gray;
            this.uPanelCenter.BorderWidth = 0;
            this.uPanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uPanelCenter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uPanelCenter.Location = new System.Drawing.Point(0, 0);
            this.uPanelCenter.Name = "uPanelCenter";
            this.uPanelCenter.Radius = 10;
            this.uPanelCenter.Size = new System.Drawing.Size(752, 719);
            this.uPanelCenter.TabIndex = 22;
            // 
            // uPanelRight
            // 
            this.uPanelRight.BackColor = System.Drawing.Color.Transparent;
            this.uPanelRight.BgColor = System.Drawing.Color.White;
            this.uPanelRight.BgColor2 = System.Drawing.Color.White;
            this.uPanelRight.BorderColor = System.Drawing.Color.Gray;
            this.uPanelRight.BorderWidth = 0;
            this.uPanelRight.Controls.Add(this.tableLayoutPanelLeft);
            this.uPanelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.uPanelRight.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uPanelRight.Location = new System.Drawing.Point(752, 0);
            this.uPanelRight.Name = "uPanelRight";
            this.uPanelRight.Radius = 10;
            this.uPanelRight.Size = new System.Drawing.Size(342, 719);
            this.uPanelRight.TabIndex = 21;
            // 
            // tableLayoutPanelLeft
            // 
            this.tableLayoutPanelLeft.ColumnCount = 1;
            this.tableLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLeft.Controls.Add(this.homePiston, 0, 1);
            this.tableLayoutPanelLeft.Controls.Add(this.homeBlade, 0, 0);
            this.tableLayoutPanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
            this.tableLayoutPanelLeft.RowCount = 2;
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelLeft.Size = new System.Drawing.Size(342, 719);
            this.tableLayoutPanelLeft.TabIndex = 11;
            // 
            // homePiston
            // 
            this.homePiston.Controls.Add(this.pistonDistance);
            this.homePiston.Controls.Add(this.pistonPause);
            this.homePiston.Controls.Add(this.pistonSpeed);
            this.homePiston.Controls.Add(this.pistonDown);
            this.homePiston.Controls.Add(this.pistonConnect);
            this.homePiston.Controls.Add(this.pistonUp);
            this.homePiston.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePiston.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.homePiston.Location = new System.Drawing.Point(3, 434);
            this.homePiston.Name = "homePiston";
            this.homePiston.Size = new System.Drawing.Size(336, 282);
            this.homePiston.TabIndex = 1;
            this.homePiston.TabStop = false;
            this.homePiston.Text = "活塞";
            // 
            // pistonDistance
            // 
            this.pistonDistance.Location = new System.Drawing.Point(111, 188);
            this.pistonDistance.Name = "pistonDistance";
            this.pistonDistance.Size = new System.Drawing.Size(150, 24);
            this.pistonDistance.TabIndex = 28;
            this.pistonDistance.Text = "扭矩:  00mm";
            // 
            // pistonPause
            // 
            this.pistonPause.Image = global::PaveSystem.Properties.Resources.bluePause;
            this.pistonPause.ImageHover = global::PaveSystem.Properties.Resources.redPause;
            this.pistonPause.ImageNormal = global::PaveSystem.Properties.Resources.bluePause;
            this.pistonPause.Location = new System.Drawing.Point(36, 113);
            this.pistonPause.Name = "pistonPause";
            this.pistonPause.Size = new System.Drawing.Size(50, 50);
            this.pistonPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pistonPause.TabIndex = 19;
            this.pistonPause.TabStop = false;
            this.pistonPause.Click += new System.EventHandler(this.pistonPause_Click);
            // 
            // pistonSpeed
            // 
            this.pistonSpeed.Location = new System.Drawing.Point(111, 126);
            this.pistonSpeed.Name = "pistonSpeed";
            this.pistonSpeed.Size = new System.Drawing.Size(187, 24);
            this.pistonSpeed.TabIndex = 27;
            this.pistonSpeed.Text = "实际速度:  00mm/s";
            // 
            // pistonDown
            // 
            this.pistonDown.Image = global::PaveSystem.Properties.Resources.blueDown;
            this.pistonDown.ImageHover = global::PaveSystem.Properties.Resources.redDown;
            this.pistonDown.ImageNormal = global::PaveSystem.Properties.Resources.blueDown;
            this.pistonDown.Location = new System.Drawing.Point(36, 179);
            this.pistonDown.Name = "pistonDown";
            this.pistonDown.Size = new System.Drawing.Size(50, 50);
            this.pistonDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pistonDown.TabIndex = 19;
            this.pistonDown.TabStop = false;
            this.pistonDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pistonDown_MouseDown);
            this.pistonDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pistonDown_MouseUp);
            // 
            // pistonConnect
            // 
            this.pistonConnect.Location = new System.Drawing.Point(111, 59);
            this.pistonConnect.Name = "pistonConnect";
            this.pistonConnect.Size = new System.Drawing.Size(187, 24);
            this.pistonConnect.TabIndex = 26;
            this.pistonConnect.Text = "伺服状态:  未连接";
            // 
            // pistonUp
            // 
            this.pistonUp.Image = global::PaveSystem.Properties.Resources.blueUp;
            this.pistonUp.ImageHover = global::PaveSystem.Properties.Resources.redUp;
            this.pistonUp.ImageNormal = global::PaveSystem.Properties.Resources.blueUp;
            this.pistonUp.Location = new System.Drawing.Point(36, 44);
            this.pistonUp.Name = "pistonUp";
            this.pistonUp.Size = new System.Drawing.Size(50, 50);
            this.pistonUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pistonUp.TabIndex = 11;
            this.pistonUp.TabStop = false;
            this.pistonUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pistonUp_MouseDown);
            this.pistonUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pistonUp_MouseUp);
            // 
            // homeBlade
            // 
            this.homeBlade.Controls.Add(this.bladeDistance);
            this.homeBlade.Controls.Add(this.bladeSpeed);
            this.homeBlade.Controls.Add(this.bladeConnect);
            this.homeBlade.Controls.Add(this.bladeLeft);
            this.homeBlade.Controls.Add(this.bladeFanDown);
            this.homeBlade.Controls.Add(this.bladeRight);
            this.homeBlade.Controls.Add(this.bladePause);
            this.homeBlade.Controls.Add(this.bladeFanUp);
            this.homeBlade.Controls.Add(this.bladeFanSpot);
            this.homeBlade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeBlade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBlade.Location = new System.Drawing.Point(3, 3);
            this.homeBlade.Name = "homeBlade";
            this.homeBlade.Size = new System.Drawing.Size(336, 425);
            this.homeBlade.TabIndex = 0;
            this.homeBlade.TabStop = false;
            this.homeBlade.Text = "刮刀";
            // 
            // bladeDistance
            // 
            this.bladeDistance.Location = new System.Drawing.Point(111, 166);
            this.bladeDistance.Name = "bladeDistance";
            this.bladeDistance.Size = new System.Drawing.Size(150, 24);
            this.bladeDistance.TabIndex = 25;
            this.bladeDistance.Text = "扭矩:  00mm";
            // 
            // bladeSpeed
            // 
            this.bladeSpeed.Location = new System.Drawing.Point(111, 100);
            this.bladeSpeed.Name = "bladeSpeed";
            this.bladeSpeed.Size = new System.Drawing.Size(187, 24);
            this.bladeSpeed.TabIndex = 24;
            this.bladeSpeed.Text = "实际速度:  00mm/s";
            // 
            // bladeConnect
            // 
            this.bladeConnect.Location = new System.Drawing.Point(111, 39);
            this.bladeConnect.Name = "bladeConnect";
            this.bladeConnect.Size = new System.Drawing.Size(187, 24);
            this.bladeConnect.TabIndex = 23;
            this.bladeConnect.Text = "伺服状态:  未连接";
            // 
            // bladeLeft
            // 
            this.bladeLeft.Image = global::PaveSystem.Properties.Resources.blueRight;
            this.bladeLeft.ImageHover = global::PaveSystem.Properties.Resources.redRight;
            this.bladeLeft.ImageNormal = global::PaveSystem.Properties.Resources.blueRight;
            this.bladeLeft.Location = new System.Drawing.Point(36, 152);
            this.bladeLeft.Name = "bladeLeft";
            this.bladeLeft.Size = new System.Drawing.Size(50, 50);
            this.bladeLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bladeLeft.TabIndex = 2;
            this.bladeLeft.TabStop = false;
            this.bladeLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bladeLeft_MouseDown);
            this.bladeLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bladeLeft_MouseUp);
            // 
            // bladeFanDown
            // 
            this.bladeFanDown.BackColor = System.Drawing.Color.Transparent;
            this.bladeFanDown.BgColor = System.Drawing.Color.Gainsboro;
            this.bladeFanDown.BgColor2 = System.Drawing.Color.WhiteSmoke;
            this.bladeFanDown.BorderColor = System.Drawing.Color.Gray;
            this.bladeFanDown.BorderWidth = 1;
            this.bladeFanDown.FlatAppearance.BorderSize = 0;
            this.bladeFanDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bladeFanDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bladeFanDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bladeFanDown.ForeColor = System.Drawing.Color.Black;
            this.bladeFanDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bladeFanDown.Location = new System.Drawing.Point(196, 297);
            this.bladeFanDown.MouseDownBgColor = System.Drawing.Color.WhiteSmoke;
            this.bladeFanDown.MouseDownFColor = System.Drawing.Color.Black;
            this.bladeFanDown.Name = "bladeFanDown";
            this.bladeFanDown.Radius = 0;
            this.bladeFanDown.Size = new System.Drawing.Size(120, 40);
            this.bladeFanDown.TabIndex = 18;
            this.bladeFanDown.Text = "后溢粉槽";
            this.bladeFanDown.UseVisualStyleBackColor = false;
            // 
            // bladeRight
            // 
            this.bladeRight.Image = global::PaveSystem.Properties.Resources.blueLeft;
            this.bladeRight.ImageHover = global::PaveSystem.Properties.Resources.redLeft;
            this.bladeRight.ImageNormal = global::PaveSystem.Properties.Resources.blueLeft;
            this.bladeRight.Location = new System.Drawing.Point(36, 26);
            this.bladeRight.Name = "bladeRight";
            this.bladeRight.Size = new System.Drawing.Size(50, 50);
            this.bladeRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bladeRight.TabIndex = 1;
            this.bladeRight.TabStop = false;
            this.bladeRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bladeRight_MouseDown);
            this.bladeRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bladeRight_MouseUp);
            // 
            // bladePause
            // 
            this.bladePause.Image = global::PaveSystem.Properties.Resources.bluePause;
            this.bladePause.ImageHover = global::PaveSystem.Properties.Resources.redPause;
            this.bladePause.ImageNormal = global::PaveSystem.Properties.Resources.bluePause;
            this.bladePause.Location = new System.Drawing.Point(36, 87);
            this.bladePause.Name = "bladePause";
            this.bladePause.Size = new System.Drawing.Size(50, 50);
            this.bladePause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bladePause.TabIndex = 12;
            this.bladePause.TabStop = false;
            this.bladePause.Click += new System.EventHandler(this.bladePause_Click);
            // 
            // bladeFanUp
            // 
            this.bladeFanUp.BackColor = System.Drawing.Color.Transparent;
            this.bladeFanUp.BgColor = System.Drawing.Color.Gainsboro;
            this.bladeFanUp.BgColor2 = System.Drawing.Color.WhiteSmoke;
            this.bladeFanUp.BorderColor = System.Drawing.Color.Gray;
            this.bladeFanUp.BorderWidth = 1;
            this.bladeFanUp.FlatAppearance.BorderSize = 0;
            this.bladeFanUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bladeFanUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bladeFanUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bladeFanUp.ForeColor = System.Drawing.Color.Black;
            this.bladeFanUp.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bladeFanUp.Location = new System.Drawing.Point(20, 297);
            this.bladeFanUp.MouseDownBgColor = System.Drawing.Color.WhiteSmoke;
            this.bladeFanUp.MouseDownFColor = System.Drawing.Color.Black;
            this.bladeFanUp.Name = "bladeFanUp";
            this.bladeFanUp.Radius = 0;
            this.bladeFanUp.Size = new System.Drawing.Size(120, 40);
            this.bladeFanUp.TabIndex = 17;
            this.bladeFanUp.Text = "前溢粉槽";
            this.bladeFanUp.UseVisualStyleBackColor = false;
            // 
            // bladeFanSpot
            // 
            this.bladeFanSpot.BackColor = System.Drawing.Color.Transparent;
            this.bladeFanSpot.BgColor = System.Drawing.Color.Gainsboro;
            this.bladeFanSpot.BgColor2 = System.Drawing.Color.WhiteSmoke;
            this.bladeFanSpot.BorderColor = System.Drawing.Color.Gray;
            this.bladeFanSpot.BorderWidth = 1;
            this.bladeFanSpot.FlatAppearance.BorderSize = 0;
            this.bladeFanSpot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bladeFanSpot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bladeFanSpot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bladeFanSpot.ForeColor = System.Drawing.Color.Black;
            this.bladeFanSpot.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bladeFanSpot.Location = new System.Drawing.Point(108, 224);
            this.bladeFanSpot.MouseDownBgColor = System.Drawing.Color.WhiteSmoke;
            this.bladeFanSpot.MouseDownFColor = System.Drawing.Color.Black;
            this.bladeFanSpot.Name = "bladeFanSpot";
            this.bladeFanSpot.Radius = 0;
            this.bladeFanSpot.Size = new System.Drawing.Size(120, 40);
            this.bladeFanSpot.TabIndex = 16;
            this.bladeFanSpot.Text = "接粉位置";
            this.bladeFanSpot.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.uPanelCenter);
            this.Controls.Add(this.uPanelRight);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(1094, 719);
            this.Load += new System.EventHandler(this.UC_Home_Load);
            this.uPanelRight.ResumeLayout(false);
            this.tableLayoutPanelLeft.ResumeLayout(false);
            this.homePiston.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pistonPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistonDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistonUp)).EndInit();
            this.homeBlade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bladeLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bladeRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bladePause)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeft;
        private System.Windows.Forms.GroupBox homeBlade;
        private System.Windows.Forms.GroupBox homePiston;
        private UPictureBox pistonUp;
        private UPictureBox bladePause;
        private UCircleButton bladeFanDown;
        private UCircleButton bladeFanUp;
        private UCircleButton bladeFanSpot;
        private UPictureBox pistonDown;
        private UPictureBox pistonPause;
        private UPanel uPanelRight;
        private UPanel uPanelCenter;
        private UPictureBox bladeLeft;
        private UPictureBox bladeRight;
        private System.Windows.Forms.Label bladeConnect;
        private System.Windows.Forms.Label bladeDistance;
        private System.Windows.Forms.Label bladeSpeed;
        private System.Windows.Forms.Label pistonDistance;
        private System.Windows.Forms.Label pistonSpeed;
        private System.Windows.Forms.Label pistonConnect;
        private System.Windows.Forms.Timer timer1;
    }
}
