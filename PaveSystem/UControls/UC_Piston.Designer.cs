
namespace PaveSystem.UControls
{
    partial class UC_Piston
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
            this.pistonSet = new System.Windows.Forms.GroupBox();
            this.pistonZero = new PaveSystem.UControls.UCircleButton();
            this.pistonFanSet = new PaveSystem.UControls.UCircleButton();
            this.pistonSpeedSet = new PaveSystem.UControls.UCircleButton();
            this.pistonFirst = new System.Windows.Forms.GroupBox();
            this.pistonFirstSpot = new System.Windows.Forms.Label();
            this.pistonFirstDIstance = new System.Windows.Forms.Label();
            this.pistonFirstSpeed = new System.Windows.Forms.Label();
            this.pistonFirstConnect = new System.Windows.Forms.Label();
            this.pistonSecond = new System.Windows.Forms.GroupBox();
            this.pistonSecondSpot = new System.Windows.Forms.Label();
            this.pistonSecondDistance = new System.Windows.Forms.Label();
            this.pistonSecondSpeed = new System.Windows.Forms.Label();
            this.pistonSecondConnect = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uPanelRight.SuspendLayout();
            this.tableLayoutPanelLeft.SuspendLayout();
            this.pistonSet.SuspendLayout();
            this.pistonFirst.SuspendLayout();
            this.pistonSecond.SuspendLayout();
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
            this.uPanelCenter.Size = new System.Drawing.Size(851, 719);
            this.uPanelCenter.TabIndex = 2;
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
            this.uPanelRight.Location = new System.Drawing.Point(851, 0);
            this.uPanelRight.Name = "uPanelRight";
            this.uPanelRight.Radius = 10;
            this.uPanelRight.Size = new System.Drawing.Size(243, 719);
            this.uPanelRight.TabIndex = 1;
            // 
            // tableLayoutPanelLeft
            // 
            this.tableLayoutPanelLeft.ColumnCount = 1;
            this.tableLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLeft.Controls.Add(this.pistonSet, 0, 2);
            this.tableLayoutPanelLeft.Controls.Add(this.pistonFirst, 0, 0);
            this.tableLayoutPanelLeft.Controls.Add(this.pistonSecond, 0, 1);
            this.tableLayoutPanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
            this.tableLayoutPanelLeft.RowCount = 3;
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelLeft.Size = new System.Drawing.Size(243, 719);
            this.tableLayoutPanelLeft.TabIndex = 26;
            // 
            // pistonSet
            // 
            this.pistonSet.Controls.Add(this.pistonZero);
            this.pistonSet.Controls.Add(this.pistonFanSet);
            this.pistonSet.Controls.Add(this.pistonSpeedSet);
            this.pistonSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pistonSet.Location = new System.Drawing.Point(3, 481);
            this.pistonSet.Name = "pistonSet";
            this.pistonSet.Size = new System.Drawing.Size(237, 235);
            this.pistonSet.TabIndex = 26;
            this.pistonSet.TabStop = false;
            // 
            // pistonZero
            // 
            this.pistonZero.BackColor = System.Drawing.Color.Transparent;
            this.pistonZero.BgColor = System.Drawing.Color.CornflowerBlue;
            this.pistonZero.BgColor2 = System.Drawing.Color.RoyalBlue;
            this.pistonZero.BorderColor = System.Drawing.Color.Gray;
            this.pistonZero.BorderWidth = 1;
            this.pistonZero.FlatAppearance.BorderSize = 0;
            this.pistonZero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.pistonZero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.pistonZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pistonZero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.pistonZero.ForeColor = System.Drawing.Color.White;
            this.pistonZero.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pistonZero.Location = new System.Drawing.Point(54, 153);
            this.pistonZero.MouseDownBgColor = System.Drawing.Color.RoyalBlue;
            this.pistonZero.MouseDownFColor = System.Drawing.Color.White;
            this.pistonZero.Name = "pistonZero";
            this.pistonZero.Radius = 0;
            this.pistonZero.Size = new System.Drawing.Size(120, 40);
            this.pistonZero.TabIndex = 38;
            this.pistonZero.Text = "活塞回零";
            this.pistonZero.UseVisualStyleBackColor = false;
            // 
            // pistonFanSet
            // 
            this.pistonFanSet.BackColor = System.Drawing.Color.Transparent;
            this.pistonFanSet.BgColor = System.Drawing.Color.Gainsboro;
            this.pistonFanSet.BgColor2 = System.Drawing.Color.WhiteSmoke;
            this.pistonFanSet.BorderColor = System.Drawing.Color.Gray;
            this.pistonFanSet.BorderWidth = 1;
            this.pistonFanSet.FlatAppearance.BorderSize = 0;
            this.pistonFanSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.pistonFanSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.pistonFanSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pistonFanSet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pistonFanSet.ForeColor = System.Drawing.Color.Black;
            this.pistonFanSet.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pistonFanSet.Location = new System.Drawing.Point(54, 87);
            this.pistonFanSet.MouseDownBgColor = System.Drawing.Color.WhiteSmoke;
            this.pistonFanSet.MouseDownFColor = System.Drawing.Color.Black;
            this.pistonFanSet.Name = "pistonFanSet";
            this.pistonFanSet.Radius = 0;
            this.pistonFanSet.Size = new System.Drawing.Size(120, 40);
            this.pistonFanSet.TabIndex = 37;
            this.pistonFanSet.Text = "铺粉区域设置";
            this.pistonFanSet.UseVisualStyleBackColor = false;
            // 
            // pistonSpeedSet
            // 
            this.pistonSpeedSet.BackColor = System.Drawing.Color.Transparent;
            this.pistonSpeedSet.BgColor = System.Drawing.Color.Gainsboro;
            this.pistonSpeedSet.BgColor2 = System.Drawing.Color.WhiteSmoke;
            this.pistonSpeedSet.BorderColor = System.Drawing.Color.Gray;
            this.pistonSpeedSet.BorderWidth = 1;
            this.pistonSpeedSet.FlatAppearance.BorderSize = 0;
            this.pistonSpeedSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.pistonSpeedSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.pistonSpeedSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pistonSpeedSet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pistonSpeedSet.ForeColor = System.Drawing.Color.Black;
            this.pistonSpeedSet.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pistonSpeedSet.Location = new System.Drawing.Point(54, 22);
            this.pistonSpeedSet.MouseDownBgColor = System.Drawing.Color.WhiteSmoke;
            this.pistonSpeedSet.MouseDownFColor = System.Drawing.Color.Black;
            this.pistonSpeedSet.Name = "pistonSpeedSet";
            this.pistonSpeedSet.Radius = 0;
            this.pistonSpeedSet.Size = new System.Drawing.Size(120, 40);
            this.pistonSpeedSet.TabIndex = 35;
            this.pistonSpeedSet.Text = "活塞速度设置";
            this.pistonSpeedSet.UseVisualStyleBackColor = false;
            // 
            // pistonFirst
            // 
            this.pistonFirst.Controls.Add(this.pistonFirstSpot);
            this.pistonFirst.Controls.Add(this.pistonFirstDIstance);
            this.pistonFirst.Controls.Add(this.pistonFirstSpeed);
            this.pistonFirst.Controls.Add(this.pistonFirstConnect);
            this.pistonFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pistonFirst.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pistonFirst.Location = new System.Drawing.Point(3, 3);
            this.pistonFirst.Name = "pistonFirst";
            this.pistonFirst.Size = new System.Drawing.Size(237, 233);
            this.pistonFirst.TabIndex = 26;
            this.pistonFirst.TabStop = false;
            this.pistonFirst.Text = "活塞升降(主)";
            // 
            // pistonFirstSpot
            // 
            this.pistonFirstSpot.Location = new System.Drawing.Point(41, 182);
            this.pistonFirstSpot.Name = "pistonFirstSpot";
            this.pistonFirstSpot.Size = new System.Drawing.Size(169, 24);
            this.pistonFirstSpot.TabIndex = 37;
            this.pistonFirstSpot.Text = "光栅位置:  00mm";
            // 
            // pistonFirstDIstance
            // 
            this.pistonFirstDIstance.Location = new System.Drawing.Point(41, 138);
            this.pistonFirstDIstance.Name = "pistonFirstDIstance";
            this.pistonFirstDIstance.Size = new System.Drawing.Size(150, 24);
            this.pistonFirstDIstance.TabIndex = 37;
            this.pistonFirstDIstance.Text = "扭矩:  00mm";
            // 
            // pistonFirstSpeed
            // 
            this.pistonFirstSpeed.Location = new System.Drawing.Point(41, 95);
            this.pistonFirstSpeed.Name = "pistonFirstSpeed";
            this.pistonFirstSpeed.Size = new System.Drawing.Size(160, 24);
            this.pistonFirstSpeed.TabIndex = 37;
            this.pistonFirstSpeed.Text = "实际速度:  00mm/s";
            // 
            // pistonFirstConnect
            // 
            this.pistonFirstConnect.Location = new System.Drawing.Point(41, 51);
            this.pistonFirstConnect.Name = "pistonFirstConnect";
            this.pistonFirstConnect.Size = new System.Drawing.Size(150, 24);
            this.pistonFirstConnect.TabIndex = 33;
            this.pistonFirstConnect.Text = "伺服状态:  未连接";
            // 
            // pistonSecond
            // 
            this.pistonSecond.Controls.Add(this.pistonSecondSpot);
            this.pistonSecond.Controls.Add(this.pistonSecondDistance);
            this.pistonSecond.Controls.Add(this.pistonSecondSpeed);
            this.pistonSecond.Controls.Add(this.pistonSecondConnect);
            this.pistonSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pistonSecond.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pistonSecond.Location = new System.Drawing.Point(3, 242);
            this.pistonSecond.Name = "pistonSecond";
            this.pistonSecond.Size = new System.Drawing.Size(237, 233);
            this.pistonSecond.TabIndex = 27;
            this.pistonSecond.TabStop = false;
            this.pistonSecond.Text = "活塞升降(从)";
            // 
            // pistonSecondSpot
            // 
            this.pistonSecondSpot.Location = new System.Drawing.Point(41, 190);
            this.pistonSecondSpot.Name = "pistonSecondSpot";
            this.pistonSecondSpot.Size = new System.Drawing.Size(169, 24);
            this.pistonSecondSpot.TabIndex = 36;
            this.pistonSecondSpot.Text = "光栅位置:  00mm";
            // 
            // pistonSecondDistance
            // 
            this.pistonSecondDistance.Location = new System.Drawing.Point(41, 148);
            this.pistonSecondDistance.Name = "pistonSecondDistance";
            this.pistonSecondDistance.Size = new System.Drawing.Size(150, 24);
            this.pistonSecondDistance.TabIndex = 34;
            this.pistonSecondDistance.Text = "扭矩:  00mm";
            // 
            // pistonSecondSpeed
            // 
            this.pistonSecondSpeed.Location = new System.Drawing.Point(41, 102);
            this.pistonSecondSpeed.Name = "pistonSecondSpeed";
            this.pistonSecondSpeed.Size = new System.Drawing.Size(160, 24);
            this.pistonSecondSpeed.TabIndex = 33;
            this.pistonSecondSpeed.Text = "实际速度:  00mm/s";
            // 
            // pistonSecondConnect
            // 
            this.pistonSecondConnect.Location = new System.Drawing.Point(41, 56);
            this.pistonSecondConnect.Name = "pistonSecondConnect";
            this.pistonSecondConnect.Size = new System.Drawing.Size(150, 24);
            this.pistonSecondConnect.TabIndex = 32;
            this.pistonSecondConnect.Text = "伺服状态:  未连接";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_Piston
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uPanelCenter);
            this.Controls.Add(this.uPanelRight);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Piston";
            this.Size = new System.Drawing.Size(1094, 719);
            this.Load += new System.EventHandler(this.UC_Piston_Load);
            this.uPanelRight.ResumeLayout(false);
            this.tableLayoutPanelLeft.ResumeLayout(false);
            this.pistonSet.ResumeLayout(false);
            this.pistonFirst.ResumeLayout(false);
            this.pistonSecond.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UPanel uPanelRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeft;
        private System.Windows.Forms.GroupBox pistonSet;
        private System.Windows.Forms.GroupBox pistonFirst;
        private System.Windows.Forms.GroupBox pistonSecond;
        private System.Windows.Forms.Label pistonSecondConnect;
        private System.Windows.Forms.Label pistonSecondSpeed;
        private System.Windows.Forms.Label pistonSecondDistance;
        private UCircleButton pistonFanSet;
        private UCircleButton pistonSpeedSet;
        private System.Windows.Forms.Label pistonSecondSpot;
        private System.Windows.Forms.Label pistonFirstSpot;
        private System.Windows.Forms.Label pistonFirstDIstance;
        private System.Windows.Forms.Label pistonFirstSpeed;
        private System.Windows.Forms.Label pistonFirstConnect;
        private UPanel uPanelCenter;
        private System.Windows.Forms.Timer timer1;
        private UCircleButton pistonZero;
    }
}
