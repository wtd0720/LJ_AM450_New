
namespace ScanSystem
{
    partial class ScanControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanControl));
            this.ParaGrid = new System.Windows.Forms.PropertyGrid();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PicSelect = new System.Windows.Forms.ComboBox();
            this.PicSize = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ScanSpace = new System.Windows.Forms.NumericUpDown();
            this.IsFill = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StateLabel = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelUP = new System.Windows.Forms.Panel();
            this.Strech = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.PicState = new System.Windows.Forms.PictureBox();
            this.Input = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScanSpace)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelUP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Strech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicState)).BeginInit();
            this.SuspendLayout();
            // 
            // ParaGrid
            // 
            this.ParaGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParaGrid.Location = new System.Drawing.Point(0, 0);
            this.ParaGrid.Name = "ParaGrid";
            this.ParaGrid.Size = new System.Drawing.Size(221, 527);
            this.ParaGrid.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.PicSelect);
            this.groupBox3.Controls.Add(this.PicSize);
            this.groupBox3.Location = new System.Drawing.Point(430, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 88);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "图形设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "选择图形";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "选择尺寸";
            // 
            // PicSelect
            // 
            this.PicSelect.FormattingEnabled = true;
            this.PicSelect.Items.AddRange(new object[] {
            "圆形",
            "正方形",
            "十字点阵"});
            this.PicSelect.Location = new System.Drawing.Point(90, 19);
            this.PicSelect.Name = "PicSelect";
            this.PicSelect.Size = new System.Drawing.Size(79, 28);
            this.PicSelect.TabIndex = 0;
            this.PicSelect.Text = "圆形";
            this.PicSelect.SelectedIndexChanged += new System.EventHandler(this.PicSelect_SelectedIndexChanged);
            // 
            // PicSize
            // 
            this.PicSize.DecimalPlaces = 2;
            this.PicSize.Location = new System.Drawing.Point(90, 51);
            this.PicSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PicSize.Name = "PicSize";
            this.PicSize.Size = new System.Drawing.Size(79, 26);
            this.PicSize.TabIndex = 4;
            this.PicSize.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.PicSize.ValueChanged += new System.EventHandler(this.PicSize_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ScanSpace);
            this.groupBox2.Controls.Add(this.IsFill);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(633, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 87);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "填充设置";
            // 
            // ScanSpace
            // 
            this.ScanSpace.DecimalPlaces = 2;
            this.ScanSpace.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ScanSpace.Location = new System.Drawing.Point(95, 50);
            this.ScanSpace.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ScanSpace.Name = "ScanSpace";
            this.ScanSpace.Size = new System.Drawing.Size(79, 26);
            this.ScanSpace.TabIndex = 8;
            this.ScanSpace.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ScanSpace.ValueChanged += new System.EventHandler(this.ScanSpace_ValueChanged);
            // 
            // IsFill
            // 
            this.IsFill.AutoSize = true;
            this.IsFill.Checked = true;
            this.IsFill.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsFill.Location = new System.Drawing.Point(16, 25);
            this.IsFill.Name = "IsFill";
            this.IsFill.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IsFill.Size = new System.Drawing.Size(92, 24);
            this.IsFill.TabIndex = 10;
            this.IsFill.Text = "是否填充";
            this.IsFill.UseVisualStyleBackColor = true;
            this.IsFill.CheckedChanged += new System.EventHandler(this.IsFill_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "填充间距";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PicState);
            this.groupBox1.Controls.Add(this.StateLabel);
            this.groupBox1.Location = new System.Drawing.Point(322, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 88);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接状态";
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(32, 40);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(57, 20);
            this.StateLabel.TabIndex = 0;
            this.StateLabel.Text = "未连接";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelLeft);
            this.panelMain.Controls.Add(this.panelRight);
            this.panelMain.Controls.Add(this.panelUP);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(838, 625);
            this.panelMain.TabIndex = 3;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.Strech);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 98);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(617, 527);
            this.panelLeft.TabIndex = 4;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.ParaGrid);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(617, 98);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(221, 527);
            this.panelRight.TabIndex = 3;
            // 
            // panelUP
            // 
            this.panelUP.Controls.Add(this.groupBox3);
            this.panelUP.Controls.Add(this.Start);
            this.panelUP.Controls.Add(this.Connect);
            this.panelUP.Controls.Add(this.groupBox1);
            this.panelUP.Controls.Add(this.Input);
            this.panelUP.Controls.Add(this.groupBox2);
            this.panelUP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUP.Location = new System.Drawing.Point(0, 0);
            this.panelUP.Name = "panelUP";
            this.panelUP.Size = new System.Drawing.Size(838, 98);
            this.panelUP.TabIndex = 2;
            // 
            // Strech
            // 
            this.Strech.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Strech.Location = new System.Drawing.Point(0, 0);
            this.Strech.Name = "Strech";
            this.Strech.Size = new System.Drawing.Size(617, 527);
            this.Strech.TabIndex = 2;
            this.Strech.TabStop = false;
            this.Strech.Paint += new System.Windows.Forms.PaintEventHandler(this.Strech_Paint);
            this.Strech.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Strech_MouseWheel);
            // 
            // Start
            // 
            this.Start.Image = global::ScanSystem.Properties.Resources.scan;
            this.Start.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Start.Location = new System.Drawing.Point(117, 14);
            this.Start.Name = "Start";
            this.Start.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Start.Size = new System.Drawing.Size(97, 78);
            this.Start.TabIndex = 3;
            this.Start.Text = "开始扫描";
            this.Start.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Connect
            // 
            this.Connect.Image = global::ScanSystem.Properties.Resources.connect;
            this.Connect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Connect.Location = new System.Drawing.Point(10, 14);
            this.Connect.Name = "Connect";
            this.Connect.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Connect.Size = new System.Drawing.Size(98, 79);
            this.Connect.TabIndex = 1;
            this.Connect.Text = "连接振镜";
            this.Connect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // PicState
            // 
            this.PicState.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PicState.ErrorImage")));
            this.PicState.Image = global::ScanSystem.Properties.Resources.errorstate;
            this.PicState.InitialImage = null;
            this.PicState.Location = new System.Drawing.Point(11, 38);
            this.PicState.Name = "PicState";
            this.PicState.Size = new System.Drawing.Size(21, 21);
            this.PicState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicState.TabIndex = 1;
            this.PicState.TabStop = false;
            // 
            // Input
            // 
            this.Input.Image = global::ScanSystem.Properties.Resources.input;
            this.Input.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Input.Location = new System.Drawing.Point(221, 14);
            this.Input.Name = "Input";
            this.Input.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Input.Size = new System.Drawing.Size(93, 78);
            this.Input.TabIndex = 6;
            this.Input.Text = "导入图像";
            this.Input.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Input.UseVisualStyleBackColor = true;
            this.Input.Click += new System.EventHandler(this.Input_Click);
            // 
            // ScanControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ScanControl";
            this.Size = new System.Drawing.Size(838, 625);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScanSpace)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelUP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Strech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PropertyGrid ParaGrid;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox Strech;
        private System.Windows.Forms.Button Input;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PicState;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.CheckBox IsFill;
        private System.Windows.Forms.NumericUpDown ScanSpace;
        private System.Windows.Forms.NumericUpDown PicSize;
        private System.Windows.Forms.ComboBox PicSelect;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelUP;
        private System.Windows.Forms.Panel panelLeft;
    }
}
