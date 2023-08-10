
namespace ClipperHelper
{
    partial class SliceControl_New
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SliceControl_New));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.LayerSelect = new System.Windows.Forms.HScrollBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CurrentLayerNum = new System.Windows.Forms.Label();
            this.CurrentHeight = new System.Windows.Forms.Label();
            this.AllLayerNum = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PreButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PreViewButton = new System.Windows.Forms.Button();
            this.StopView = new System.Windows.Forms.Button();
            this.SetPara = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.PreViewButton);
            this.panel1.Controls.Add(this.NextButton);
            this.panel1.Controls.Add(this.PreButton);
            this.panel1.Controls.Add(this.StopView);
            this.panel1.Controls.Add(this.SetPara);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 68);
            this.panel1.TabIndex = 0;
            // 
            // ViewPanel
            // 
            this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPanel.Location = new System.Drawing.Point(0, 68);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(1094, 651);
            this.ViewPanel.TabIndex = 1;
            // 
            // LayerSelect
            // 
            this.LayerSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.LayerSelect.LargeChange = 1;
            this.LayerSelect.Location = new System.Drawing.Point(0, 0);
            this.LayerSelect.Name = "LayerSelect";
            this.LayerSelect.Size = new System.Drawing.Size(774, 25);
            this.LayerSelect.TabIndex = 0;
            this.LayerSelect.ValueChanged += new System.EventHandler(this.LayerSelect_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.LayerSelect);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(126, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(778, 64);
            this.panel3.TabIndex = 1;
            // 
            // CurrentLayerNum
            // 
            this.CurrentLayerNum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CurrentLayerNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentLayerNum.Dock = System.Windows.Forms.DockStyle.Left;
            this.CurrentLayerNum.Location = new System.Drawing.Point(0, 0);
            this.CurrentLayerNum.Name = "CurrentLayerNum";
            this.CurrentLayerNum.Size = new System.Drawing.Size(64, 31);
            this.CurrentLayerNum.TabIndex = 1;
            this.CurrentLayerNum.Text = "第N层";
            this.CurrentLayerNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentHeight
            // 
            this.CurrentHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentHeight.Location = new System.Drawing.Point(64, 0);
            this.CurrentHeight.Name = "CurrentHeight";
            this.CurrentHeight.Size = new System.Drawing.Size(642, 31);
            this.CurrentHeight.TabIndex = 2;
            this.CurrentHeight.Text = "当前层高：xx mm";
            this.CurrentHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllLayerNum
            // 
            this.AllLayerNum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AllLayerNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AllLayerNum.Dock = System.Windows.Forms.DockStyle.Right;
            this.AllLayerNum.Location = new System.Drawing.Point(706, 0);
            this.AllLayerNum.Name = "AllLayerNum";
            this.AllLayerNum.Size = new System.Drawing.Size(64, 31);
            this.AllLayerNum.TabIndex = 3;
            this.AllLayerNum.Text = "共N层";
            this.AllLayerNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.CurrentHeight);
            this.panel4.Controls.Add(this.AllLayerNum);
            this.panel4.Controls.Add(this.CurrentLayerNum);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(774, 35);
            this.panel4.TabIndex = 2;
            // 
            // PreButton
            // 
            this.PreButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PreButton.BackgroundImage")));
            this.PreButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PreButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.PreButton.Location = new System.Drawing.Point(0, 0);
            this.PreButton.Name = "PreButton";
            this.PreButton.Size = new System.Drawing.Size(64, 64);
            this.PreButton.TabIndex = 23;
            this.PreButton.UseVisualStyleBackColor = true;
            this.PreButton.Click += new System.EventHandler(this.PreButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NextButton.BackgroundImage")));
            this.NextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NextButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.NextButton.Location = new System.Drawing.Point(64, 0);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(62, 64);
            this.NextButton.TabIndex = 24;
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PreViewButton
            // 
            this.PreViewButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PreViewButton.BackgroundImage")));
            this.PreViewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PreViewButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.PreViewButton.Location = new System.Drawing.Point(904, 0);
            this.PreViewButton.Name = "PreViewButton";
            this.PreViewButton.Size = new System.Drawing.Size(62, 64);
            this.PreViewButton.TabIndex = 25;
            this.PreViewButton.UseVisualStyleBackColor = true;
            this.PreViewButton.Click += new System.EventHandler(this.PreViewButton_Click);
            // 
            // StopView
            // 
            this.StopView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StopView.BackgroundImage")));
            this.StopView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StopView.Dock = System.Windows.Forms.DockStyle.Right;
            this.StopView.Location = new System.Drawing.Point(966, 0);
            this.StopView.Name = "StopView";
            this.StopView.Size = new System.Drawing.Size(62, 64);
            this.StopView.TabIndex = 26;
            this.StopView.UseVisualStyleBackColor = true;
            this.StopView.Click += new System.EventHandler(this.StopView_Click);
            // 
            // SetPara
            // 
            this.SetPara.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SetPara.BackgroundImage")));
            this.SetPara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SetPara.Dock = System.Windows.Forms.DockStyle.Right;
            this.SetPara.Location = new System.Drawing.Point(1028, 0);
            this.SetPara.Name = "SetPara";
            this.SetPara.Size = new System.Drawing.Size(62, 64);
            this.SetPara.TabIndex = 27;
            this.SetPara.UseVisualStyleBackColor = true;
            this.SetPara.Click += new System.EventHandler(this.SetPara_Click);
            // 
            // SliceControl_New
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.ViewPanel);
            this.Controls.Add(this.panel1);
            this.Name = "SliceControl_New";
            this.Size = new System.Drawing.Size(1094, 719);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.HScrollBar LayerSelect;
        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label CurrentHeight;
        private System.Windows.Forms.Label AllLayerNum;
        private System.Windows.Forms.Label CurrentLayerNum;
        private System.Windows.Forms.Button SetPara;
        private System.Windows.Forms.Button StopView;
        private System.Windows.Forms.Button PreViewButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PreButton;
    }
}
