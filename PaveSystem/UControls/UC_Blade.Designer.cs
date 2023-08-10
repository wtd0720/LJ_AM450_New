
namespace PaveSystem.UControls
{
    partial class UC_Blade
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uPanelRight = new PaveSystem.UControls.UPanel();
            this.bladeFanDownSet = new PaveSystem.UControls.UCircleButton();
            this.bladeFanUpSet = new PaveSystem.UControls.UCircleButton();
            this.bladeFanGetSet = new PaveSystem.UControls.UCircleButton();
            this.bladeFanSpeedSet = new PaveSystem.UControls.UCircleButton();
            this.bladeConnect = new System.Windows.Forms.Label();
            this.bladeFanBaseSet = new PaveSystem.UControls.UCircleButton();
            this.bladeSpeed = new System.Windows.Forms.Label();
            this.bladeDistance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.uPanelRight.SuspendLayout();
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
            this.uPanelCenter.Radius = 0;
            this.uPanelCenter.Size = new System.Drawing.Size(885, 719);
            this.uPanelCenter.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PaveSystem.Properties.Resources.two;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(885, 719);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // uPanelRight
            // 
            this.uPanelRight.BackColor = System.Drawing.Color.Transparent;
            this.uPanelRight.BgColor = System.Drawing.Color.White;
            this.uPanelRight.BgColor2 = System.Drawing.Color.White;
            this.uPanelRight.BorderColor = System.Drawing.Color.Gray;
            this.uPanelRight.BorderWidth = 1;
            this.uPanelRight.Controls.Add(this.bladeFanDownSet);
            this.uPanelRight.Controls.Add(this.bladeFanUpSet);
            this.uPanelRight.Controls.Add(this.bladeFanGetSet);
            this.uPanelRight.Controls.Add(this.bladeFanSpeedSet);
            this.uPanelRight.Controls.Add(this.bladeConnect);
            this.uPanelRight.Controls.Add(this.bladeFanBaseSet);
            this.uPanelRight.Controls.Add(this.bladeSpeed);
            this.uPanelRight.Controls.Add(this.bladeDistance);
            this.uPanelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.uPanelRight.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uPanelRight.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uPanelRight.Location = new System.Drawing.Point(885, 0);
            this.uPanelRight.Name = "uPanelRight";
            this.uPanelRight.Radius = 0;
            this.uPanelRight.Size = new System.Drawing.Size(209, 719);
            this.uPanelRight.TabIndex = 16;
            // 
            // bladeFanDownSet
            // 
            this.bladeFanDownSet.BackColor = System.Drawing.Color.Transparent;
            this.bladeFanDownSet.BgColor = System.Drawing.Color.CornflowerBlue;
            this.bladeFanDownSet.BgColor2 = System.Drawing.Color.RoyalBlue;
            this.bladeFanDownSet.BorderColor = System.Drawing.Color.Gray;
            this.bladeFanDownSet.BorderWidth = 1;
            this.bladeFanDownSet.FlatAppearance.BorderSize = 0;
            this.bladeFanDownSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bladeFanDownSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bladeFanDownSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bladeFanDownSet.ForeColor = System.Drawing.Color.White;
            this.bladeFanDownSet.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bladeFanDownSet.Location = new System.Drawing.Point(26, 424);
            this.bladeFanDownSet.MouseDownBgColor = System.Drawing.Color.RoyalBlue;
            this.bladeFanDownSet.MouseDownFColor = System.Drawing.Color.White;
            this.bladeFanDownSet.Name = "bladeFanDownSet";
            this.bladeFanDownSet.Radius = 0;
            this.bladeFanDownSet.Size = new System.Drawing.Size(146, 40);
            this.bladeFanDownSet.TabIndex = 38;
            this.bladeFanDownSet.Text = "后溢粉槽停止位";
            this.bladeFanDownSet.UseVisualStyleBackColor = false;
            // 
            // bladeFanUpSet
            // 
            this.bladeFanUpSet.BackColor = System.Drawing.Color.Transparent;
            this.bladeFanUpSet.BgColor = System.Drawing.Color.CornflowerBlue;
            this.bladeFanUpSet.BgColor2 = System.Drawing.Color.RoyalBlue;
            this.bladeFanUpSet.BorderColor = System.Drawing.Color.Gray;
            this.bladeFanUpSet.BorderWidth = 1;
            this.bladeFanUpSet.FlatAppearance.BorderSize = 0;
            this.bladeFanUpSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bladeFanUpSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bladeFanUpSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bladeFanUpSet.ForeColor = System.Drawing.Color.White;
            this.bladeFanUpSet.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bladeFanUpSet.Location = new System.Drawing.Point(26, 362);
            this.bladeFanUpSet.MouseDownBgColor = System.Drawing.Color.RoyalBlue;
            this.bladeFanUpSet.MouseDownFColor = System.Drawing.Color.White;
            this.bladeFanUpSet.Name = "bladeFanUpSet";
            this.bladeFanUpSet.Radius = 0;
            this.bladeFanUpSet.Size = new System.Drawing.Size(146, 40);
            this.bladeFanUpSet.TabIndex = 37;
            this.bladeFanUpSet.Text = "前溢粉槽停止位";
            this.bladeFanUpSet.UseVisualStyleBackColor = false;
            // 
            // bladeFanGetSet
            // 
            this.bladeFanGetSet.BackColor = System.Drawing.Color.Transparent;
            this.bladeFanGetSet.BgColor = System.Drawing.Color.CornflowerBlue;
            this.bladeFanGetSet.BgColor2 = System.Drawing.Color.RoyalBlue;
            this.bladeFanGetSet.BorderColor = System.Drawing.Color.Gray;
            this.bladeFanGetSet.BorderWidth = 1;
            this.bladeFanGetSet.FlatAppearance.BorderSize = 0;
            this.bladeFanGetSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bladeFanGetSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bladeFanGetSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bladeFanGetSet.ForeColor = System.Drawing.Color.White;
            this.bladeFanGetSet.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bladeFanGetSet.Location = new System.Drawing.Point(26, 301);
            this.bladeFanGetSet.MouseDownBgColor = System.Drawing.Color.RoyalBlue;
            this.bladeFanGetSet.MouseDownFColor = System.Drawing.Color.White;
            this.bladeFanGetSet.Name = "bladeFanGetSet";
            this.bladeFanGetSet.Radius = 0;
            this.bladeFanGetSet.Size = new System.Drawing.Size(146, 40);
            this.bladeFanGetSet.TabIndex = 36;
            this.bladeFanGetSet.Text = "接粉位置设置";
            this.bladeFanGetSet.UseVisualStyleBackColor = false;
            // 
            // bladeFanSpeedSet
            // 
            this.bladeFanSpeedSet.BackColor = System.Drawing.Color.Transparent;
            this.bladeFanSpeedSet.BgColor = System.Drawing.Color.Gainsboro;
            this.bladeFanSpeedSet.BgColor2 = System.Drawing.Color.WhiteSmoke;
            this.bladeFanSpeedSet.BorderColor = System.Drawing.Color.Gray;
            this.bladeFanSpeedSet.BorderWidth = 1;
            this.bladeFanSpeedSet.FlatAppearance.BorderSize = 0;
            this.bladeFanSpeedSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bladeFanSpeedSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bladeFanSpeedSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bladeFanSpeedSet.ForeColor = System.Drawing.Color.Black;
            this.bladeFanSpeedSet.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bladeFanSpeedSet.Location = new System.Drawing.Point(36, 230);
            this.bladeFanSpeedSet.MouseDownBgColor = System.Drawing.Color.WhiteSmoke;
            this.bladeFanSpeedSet.MouseDownFColor = System.Drawing.Color.Black;
            this.bladeFanSpeedSet.Name = "bladeFanSpeedSet";
            this.bladeFanSpeedSet.Radius = 0;
            this.bladeFanSpeedSet.Size = new System.Drawing.Size(120, 40);
            this.bladeFanSpeedSet.TabIndex = 35;
            this.bladeFanSpeedSet.Text = "铺粉速度设置";
            this.bladeFanSpeedSet.UseVisualStyleBackColor = false;
            // 
            // bladeConnect
            // 
            this.bladeConnect.Location = new System.Drawing.Point(32, 49);
            this.bladeConnect.Name = "bladeConnect";
            this.bladeConnect.Size = new System.Drawing.Size(150, 24);
            this.bladeConnect.TabIndex = 31;
            this.bladeConnect.Text = "伺服状态:  未连接";
            // 
            // bladeFanBaseSet
            // 
            this.bladeFanBaseSet.BackColor = System.Drawing.Color.Transparent;
            this.bladeFanBaseSet.BgColor = System.Drawing.Color.Gainsboro;
            this.bladeFanBaseSet.BgColor2 = System.Drawing.Color.WhiteSmoke;
            this.bladeFanBaseSet.BorderColor = System.Drawing.Color.Gray;
            this.bladeFanBaseSet.BorderWidth = 1;
            this.bladeFanBaseSet.FlatAppearance.BorderSize = 0;
            this.bladeFanBaseSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bladeFanBaseSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bladeFanBaseSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bladeFanBaseSet.ForeColor = System.Drawing.Color.Black;
            this.bladeFanBaseSet.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.bladeFanBaseSet.Location = new System.Drawing.Point(36, 172);
            this.bladeFanBaseSet.MouseDownBgColor = System.Drawing.Color.WhiteSmoke;
            this.bladeFanBaseSet.MouseDownFColor = System.Drawing.Color.Black;
            this.bladeFanBaseSet.Name = "bladeFanBaseSet";
            this.bladeFanBaseSet.Radius = 0;
            this.bladeFanBaseSet.Size = new System.Drawing.Size(120, 40);
            this.bladeFanBaseSet.TabIndex = 34;
            this.bladeFanBaseSet.Text = "铺粉区域设置";
            this.bladeFanBaseSet.UseVisualStyleBackColor = false;
            // 
            // bladeSpeed
            // 
            this.bladeSpeed.Location = new System.Drawing.Point(32, 93);
            this.bladeSpeed.Name = "bladeSpeed";
            this.bladeSpeed.Size = new System.Drawing.Size(160, 24);
            this.bladeSpeed.TabIndex = 32;
            this.bladeSpeed.Text = "实际速度:  00mm/s";
            // 
            // bladeDistance
            // 
            this.bladeDistance.Location = new System.Drawing.Point(32, 131);
            this.bladeDistance.Name = "bladeDistance";
            this.bladeDistance.Size = new System.Drawing.Size(150, 24);
            this.bladeDistance.TabIndex = 33;
            this.bladeDistance.Text = "扭矩:  00mm";
            // 
            // UC_Blade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uPanelCenter);
            this.Controls.Add(this.uPanelRight);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Blade";
            this.Size = new System.Drawing.Size(1094, 719);
            this.Load += new System.EventHandler(this.UC_Blade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.uPanelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UPanel uPanelRight;
        private System.Windows.Forms.Label bladeConnect;
        private System.Windows.Forms.Label bladeSpeed;
        private System.Windows.Forms.Label bladeDistance;
        private UCircleButton bladeFanSpeedSet;
        private UCircleButton bladeFanBaseSet;
        private UPanel uPanelCenter;
        private System.Windows.Forms.Timer timer1;
        private UCircleButton bladeFanDownSet;
        private UCircleButton bladeFanUpSet;
        private UCircleButton bladeFanGetSet;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
