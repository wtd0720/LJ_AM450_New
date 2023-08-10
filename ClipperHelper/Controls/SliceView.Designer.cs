
namespace ClipperHelper
{
    partial class SliceView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SliceView));
            this.Viewer = new System.Windows.Forms.PictureBox();
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.ColorChange = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SF = new System.Windows.Forms.CheckBox();
            this.SB = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DF = new System.Windows.Forms.CheckBox();
            this.DB = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UF = new System.Windows.Forms.CheckBox();
            this.UB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MF = new System.Windows.Forms.CheckBox();
            this.MB = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LaserSelect = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.UpDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Viewer)).BeginInit();
            this.ViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Viewer
            // 
            this.Viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Viewer.Location = new System.Drawing.Point(0, 0);
            this.Viewer.Name = "Viewer";
            this.Viewer.Size = new System.Drawing.Size(1012, 651);
            this.Viewer.TabIndex = 0;
            this.Viewer.TabStop = false;
            this.Viewer.Paint += new System.Windows.Forms.PaintEventHandler(this.Viewer_Paint);
            this.Viewer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Viewer_MouseDown);
            this.Viewer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Viewer_MouseMove);
            this.Viewer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Viewer_MouseUp);
            this.Viewer.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Viewer_MouseWheel);
            this.Viewer.Resize += new System.EventHandler(this.Viewer_Resize);
            // 
            // ViewPanel
            // 
            this.ViewPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ViewPanel.Controls.Add(this.ColorChange);
            this.ViewPanel.Controls.Add(this.panel4);
            this.ViewPanel.Controls.Add(this.SF);
            this.ViewPanel.Controls.Add(this.SB);
            this.ViewPanel.Controls.Add(this.label4);
            this.ViewPanel.Controls.Add(this.panel3);
            this.ViewPanel.Controls.Add(this.DF);
            this.ViewPanel.Controls.Add(this.DB);
            this.ViewPanel.Controls.Add(this.label3);
            this.ViewPanel.Controls.Add(this.panel2);
            this.ViewPanel.Controls.Add(this.UF);
            this.ViewPanel.Controls.Add(this.UB);
            this.ViewPanel.Controls.Add(this.label1);
            this.ViewPanel.Controls.Add(this.panel1);
            this.ViewPanel.Controls.Add(this.MF);
            this.ViewPanel.Controls.Add(this.MB);
            this.ViewPanel.Controls.Add(this.label2);
            this.ViewPanel.Controls.Add(this.panel6);
            this.ViewPanel.Controls.Add(this.LaserSelect);
            this.ViewPanel.Controls.Add(this.panel5);
            this.ViewPanel.Controls.Add(this.UpDate);
            this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ViewPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ViewPanel.Location = new System.Drawing.Point(1012, 0);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(82, 651);
            this.ViewPanel.TabIndex = 1;
            // 
            // ColorChange
            // 
            this.ColorChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ColorChange.BackgroundImage")));
            this.ColorChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ColorChange.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ColorChange.Location = new System.Drawing.Point(0, 576);
            this.ColorChange.Name = "ColorChange";
            this.ColorChange.Size = new System.Drawing.Size(78, 71);
            this.ColorChange.TabIndex = 21;
            this.ColorChange.UseVisualStyleBackColor = true;
            this.ColorChange.Click += new System.EventHandler(this.ColorChange_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 548);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(78, 5);
            this.panel4.TabIndex = 39;
            // 
            // SF
            // 
            this.SF.Appearance = System.Windows.Forms.Appearance.Button;
            this.SF.Checked = true;
            this.SF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SF.Dock = System.Windows.Forms.DockStyle.Top;
            this.SF.Location = new System.Drawing.Point(0, 503);
            this.SF.Name = "SF";
            this.SF.Size = new System.Drawing.Size(78, 45);
            this.SF.TabIndex = 38;
            this.SF.Text = "填充";
            this.SF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SF.UseVisualStyleBackColor = true;
            this.SF.CheckedChanged += new System.EventHandler(this.SF_CheckedChanged);
            // 
            // SB
            // 
            this.SB.Appearance = System.Windows.Forms.Appearance.Button;
            this.SB.Checked = true;
            this.SB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SB.Dock = System.Windows.Forms.DockStyle.Top;
            this.SB.Location = new System.Drawing.Point(0, 458);
            this.SB.Name = "SB";
            this.SB.Size = new System.Drawing.Size(78, 45);
            this.SB.TabIndex = 37;
            this.SB.Text = "轮廓";
            this.SB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SB.UseVisualStyleBackColor = true;
            this.SB.CheckedChanged += new System.EventHandler(this.SB_CheckedChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "支撑";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 436);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(78, 5);
            this.panel3.TabIndex = 36;
            // 
            // DF
            // 
            this.DF.Appearance = System.Windows.Forms.Appearance.Button;
            this.DF.Checked = true;
            this.DF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DF.Dock = System.Windows.Forms.DockStyle.Top;
            this.DF.Location = new System.Drawing.Point(0, 391);
            this.DF.Name = "DF";
            this.DF.Size = new System.Drawing.Size(78, 45);
            this.DF.TabIndex = 34;
            this.DF.Text = "填充";
            this.DF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DF.UseVisualStyleBackColor = true;
            this.DF.CheckedChanged += new System.EventHandler(this.DF_CheckedChanged);
            // 
            // DB
            // 
            this.DB.Appearance = System.Windows.Forms.Appearance.Button;
            this.DB.Checked = true;
            this.DB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DB.Dock = System.Windows.Forms.DockStyle.Top;
            this.DB.Location = new System.Drawing.Point(0, 346);
            this.DB.Name = "DB";
            this.DB.Size = new System.Drawing.Size(78, 45);
            this.DB.TabIndex = 33;
            this.DB.Text = "轮廓";
            this.DB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DB.UseVisualStyleBackColor = true;
            this.DB.CheckedChanged += new System.EventHandler(this.DB_CheckedChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "下表面";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(78, 5);
            this.panel2.TabIndex = 32;
            // 
            // UF
            // 
            this.UF.Appearance = System.Windows.Forms.Appearance.Button;
            this.UF.Checked = true;
            this.UF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UF.Dock = System.Windows.Forms.DockStyle.Top;
            this.UF.Location = new System.Drawing.Point(0, 279);
            this.UF.Name = "UF";
            this.UF.Size = new System.Drawing.Size(78, 45);
            this.UF.TabIndex = 30;
            this.UF.Text = "填充";
            this.UF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UF.UseVisualStyleBackColor = true;
            this.UF.CheckedChanged += new System.EventHandler(this.UF_CheckedChanged);
            // 
            // UB
            // 
            this.UB.Appearance = System.Windows.Forms.Appearance.Button;
            this.UB.Checked = true;
            this.UB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UB.Dock = System.Windows.Forms.DockStyle.Top;
            this.UB.Location = new System.Drawing.Point(0, 234);
            this.UB.Name = "UB";
            this.UB.Size = new System.Drawing.Size(78, 45);
            this.UB.TabIndex = 29;
            this.UB.Text = "轮廓";
            this.UB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UB.UseVisualStyleBackColor = true;
            this.UB.CheckedChanged += new System.EventHandler(this.UB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "上表面";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(78, 5);
            this.panel1.TabIndex = 28;
            // 
            // MF
            // 
            this.MF.Appearance = System.Windows.Forms.Appearance.Button;
            this.MF.Checked = true;
            this.MF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MF.Dock = System.Windows.Forms.DockStyle.Top;
            this.MF.Location = new System.Drawing.Point(0, 167);
            this.MF.Name = "MF";
            this.MF.Size = new System.Drawing.Size(78, 45);
            this.MF.TabIndex = 26;
            this.MF.Text = "填充";
            this.MF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MF.UseVisualStyleBackColor = true;
            this.MF.CheckedChanged += new System.EventHandler(this.MF_CheckedChanged);
            // 
            // MB
            // 
            this.MB.Appearance = System.Windows.Forms.Appearance.Button;
            this.MB.Checked = true;
            this.MB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MB.Dock = System.Windows.Forms.DockStyle.Top;
            this.MB.Location = new System.Drawing.Point(0, 122);
            this.MB.Name = "MB";
            this.MB.Size = new System.Drawing.Size(78, 45);
            this.MB.TabIndex = 25;
            this.MB.Text = "轮廓";
            this.MB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MB.UseVisualStyleBackColor = true;
            this.MB.CheckedChanged += new System.EventHandler(this.MB_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "主体";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(78, 5);
            this.panel6.TabIndex = 24;
            // 
            // LaserSelect
            // 
            this.LaserSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.LaserSelect.FormattingEnabled = true;
            this.LaserSelect.Location = new System.Drawing.Point(0, 71);
            this.LaserSelect.Name = "LaserSelect";
            this.LaserSelect.Size = new System.Drawing.Size(78, 29);
            this.LaserSelect.TabIndex = 23;
            this.LaserSelect.SelectedIndexChanged += new System.EventHandler(this.LaserSelect_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 66);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(78, 5);
            this.panel5.TabIndex = 19;
            // 
            // UpDate
            // 
            this.UpDate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpDate.BackgroundImage")));
            this.UpDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpDate.Location = new System.Drawing.Point(0, 0);
            this.UpDate.Name = "UpDate";
            this.UpDate.Size = new System.Drawing.Size(78, 66);
            this.UpDate.TabIndex = 20;
            this.UpDate.UseVisualStyleBackColor = true;
            this.UpDate.Click += new System.EventHandler(this.UpDate_Click);
            // 
            // SliceView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Viewer);
            this.Controls.Add(this.ViewPanel);
            this.Name = "SliceView";
            this.Size = new System.Drawing.Size(1094, 651);
            ((System.ComponentModel.ISupportInitialize)(this.Viewer)).EndInit();
            this.ViewPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Viewer;
        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.Button ColorChange;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UpDate;
        private System.Windows.Forms.ComboBox LaserSelect;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox SF;
        private System.Windows.Forms.CheckBox SB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox DF;
        private System.Windows.Forms.CheckBox DB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox UF;
        private System.Windows.Forms.CheckBox UB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox MF;
        private System.Windows.Forms.CheckBox MB;
    }
}
