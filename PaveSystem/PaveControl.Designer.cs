
namespace PaveSystem
{
    partial class PaveControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaveControl));
            this.panelUp = new System.Windows.Forms.Panel();
            this.TimePanel = new System.Windows.Forms.Panel();
            this.RemainTimeLable = new System.Windows.Forms.Label();
            this.RunTimeLabel = new System.Windows.Forms.Label();
            this.labRemain = new System.Windows.Forms.Label();
            this.labRun = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPiston = new System.Windows.Forms.Button();
            this.btnBlade = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pavePanelCenter = new System.Windows.Forms.Panel();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.panelRun = new System.Windows.Forms.Panel();
            this.labRunControl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelUp.SuspendLayout();
            this.TimePanel.SuspendLayout();
            this.panelRun.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.DarkGray;
            this.panelUp.Controls.Add(this.panelRun);
            this.panelUp.Controls.Add(this.TimePanel);
            this.panelUp.Controls.Add(this.btnPrint);
            this.panelUp.Controls.Add(this.btnPiston);
            this.panelUp.Controls.Add(this.btnBlade);
            this.panelUp.Controls.Add(this.btnHome);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(1094, 79);
            this.panelUp.TabIndex = 2;
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
            this.TimePanel.Location = new System.Drawing.Point(845, 6);
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
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DimGray;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::PaveSystem.Properties.Resources.print;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrint.Location = new System.Drawing.Point(237, 0);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(105, 79);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "打印仓平移";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPiston
            // 
            this.btnPiston.BackColor = System.Drawing.Color.DimGray;
            this.btnPiston.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPiston.FlatAppearance.BorderSize = 0;
            this.btnPiston.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPiston.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPiston.ForeColor = System.Drawing.Color.White;
            this.btnPiston.Image = global::PaveSystem.Properties.Resources.piston;
            this.btnPiston.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPiston.Location = new System.Drawing.Point(158, 0);
            this.btnPiston.Margin = new System.Windows.Forms.Padding(0);
            this.btnPiston.Name = "btnPiston";
            this.btnPiston.Size = new System.Drawing.Size(79, 79);
            this.btnPiston.TabIndex = 13;
            this.btnPiston.Text = "活塞";
            this.btnPiston.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPiston.UseVisualStyleBackColor = false;
            this.btnPiston.Click += new System.EventHandler(this.btnPiston_Click);
            // 
            // btnBlade
            // 
            this.btnBlade.BackColor = System.Drawing.Color.DimGray;
            this.btnBlade.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBlade.FlatAppearance.BorderSize = 0;
            this.btnBlade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlade.ForeColor = System.Drawing.Color.White;
            this.btnBlade.Image = global::PaveSystem.Properties.Resources.blade;
            this.btnBlade.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBlade.Location = new System.Drawing.Point(79, 0);
            this.btnBlade.Margin = new System.Windows.Forms.Padding(0);
            this.btnBlade.Name = "btnBlade";
            this.btnBlade.Size = new System.Drawing.Size(79, 79);
            this.btnBlade.TabIndex = 14;
            this.btnBlade.Text = "刮刀";
            this.btnBlade.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBlade.UseVisualStyleBackColor = false;
            this.btnBlade.Click += new System.EventHandler(this.btnBlade_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DimGray;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(79, 79);
            this.btnHome.TabIndex = 12;
            this.btnHome.Text = "主界面";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pavePanelCenter
            // 
            this.pavePanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pavePanelCenter.Location = new System.Drawing.Point(0, 79);
            this.pavePanelCenter.Name = "pavePanelCenter";
            this.pavePanelCenter.Size = new System.Drawing.Size(1094, 719);
            this.pavePanelCenter.TabIndex = 3;
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // panelRun
            // 
            this.panelRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRun.BackColor = System.Drawing.Color.DimGray;
            this.panelRun.Controls.Add(this.labRunControl);
            this.panelRun.Controls.Add(this.label4);
            this.panelRun.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRun.Location = new System.Drawing.Point(611, 13);
            this.panelRun.Name = "panelRun";
            this.panelRun.Size = new System.Drawing.Size(215, 53);
            this.panelRun.TabIndex = 2;
            // 
            // labRunControl
            // 
            this.labRunControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labRunControl.AutoSize = true;
            this.labRunControl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRunControl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labRunControl.Location = new System.Drawing.Point(147, 17);
            this.labRunControl.Name = "labRunControl";
            this.labRunControl.Size = new System.Drawing.Size(30, 18);
            this.labRunControl.TabIndex = 5;
            this.labRunControl.Text = "00s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(13, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "运动控制器时间：";
            // 
            // PaveControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pavePanelCenter);
            this.Controls.Add(this.panelUp);
            this.Name = "PaveControl";
            this.Size = new System.Drawing.Size(1094, 798);
            this.panelUp.ResumeLayout(false);
            this.TimePanel.ResumeLayout(false);
            this.TimePanel.PerformLayout();
            this.panelRun.ResumeLayout(false);
            this.panelRun.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Panel pavePanelCenter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPiston;
        private System.Windows.Forms.Button btnBlade;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel TimePanel;
        private System.Windows.Forms.Label RemainTimeLable;
        private System.Windows.Forms.Label RunTimeLabel;
        private System.Windows.Forms.Label labRemain;
        private System.Windows.Forms.Label labRun;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Panel panelRun;
        private System.Windows.Forms.Label labRunControl;
        private System.Windows.Forms.Label label4;
    }
}
