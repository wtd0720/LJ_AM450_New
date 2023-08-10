using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipperHelper
{
    public partial class ColorChangeControl : Form
    {
        public ColorDialog cd = new ColorDialog();
        public Color[][] colors = null;
        int PreI = 0;
        public ColorChangeControl(Color[][] _colors)
        {
            colors = _colors;
            InitializeComponent();
            OKButton.DialogResult = DialogResult.OK;
            CancelButton.DialogResult = DialogResult.Cancel;
            SetColor(colors[0]);
            for (int i = 0; i < _colors.Count(); i++)
            {
                this.SelectLaser.Items.Add("激光" + (i + 1).ToString());
            }
            SelectLaser.SelectedIndex = 0;
        }

        private void SetColor(Color[] color)
        {
            MB.BackColor = color[0];
            MF.BackColor = color[1];
            UB.BackColor = color[2];
            UF.BackColor = color[3];
            DB.BackColor = color[4];
            DF.BackColor = color[5];
            SB.BackColor = color[6];
            SF.BackColor = color[7];
        }
        private Color[] GetColor()
        {
            Color[] color = new Color[8];
            color[0] = MB.BackColor;
            color[1] = MF.BackColor ;
            color[2] = UB.BackColor ;
            color[3] = UF.BackColor ;
            color[4] = DB.BackColor ;
            color[5] = DF.BackColor ;
            color[6] = SB.BackColor ;
            color[7] = SF.BackColor ;
            return color;
        }

        private void MB_Click(object sender, EventArgs e)
        {
            DialogResult dr = cd.ShowDialog();
            //如果选中颜色，单击“确定”按钮则改变文本框的文本颜色
            if (dr == DialogResult.OK)
            {
                MB.BackColor = cd.Color;
            }
        }

        private void MF_Click(object sender, EventArgs e)
        {
            DialogResult dr = cd.ShowDialog();
            //如果选中颜色，单击“确定”按钮则改变文本框的文本颜色
            if (dr == DialogResult.OK)
            {
                MF.BackColor = cd.Color;
            }
        }

        private void DB_Click(object sender, EventArgs e)
        {
            DialogResult dr = cd.ShowDialog();
            //如果选中颜色，单击“确定”按钮则改变文本框的文本颜色
            if (dr == DialogResult.OK)
            {
                DB.BackColor = cd.Color;
            }
        }

        private void DF_Click(object sender, EventArgs e)
        {
            DialogResult dr = cd.ShowDialog();
            //如果选中颜色，单击“确定”按钮则改变文本框的文本颜色
            if (dr == DialogResult.OK)
            {
                DF.BackColor = cd.Color;
            }
        }

        private void UB_Click(object sender, EventArgs e)
        {
            DialogResult dr = cd.ShowDialog();
            //如果选中颜色，单击“确定”按钮则改变文本框的文本颜色
            if (dr == DialogResult.OK)
            {
                UB.BackColor = cd.Color;
            }
        }

        private void UF_Click(object sender, EventArgs e)
        {
            DialogResult dr = cd.ShowDialog();
            //如果选中颜色，单击“确定”按钮则改变文本框的文本颜色
            if (dr == DialogResult.OK)
            {
                UF.BackColor = cd.Color;
            }
        }

        private void SB_Click(object sender, EventArgs e)
        {
            DialogResult dr = cd.ShowDialog();
            //如果选中颜色，单击“确定”按钮则改变文本框的文本颜色
            if (dr == DialogResult.OK)
            {
                SB.BackColor = cd.Color;
            }
        }

        private void SF_Click(object sender, EventArgs e)
        {
            DialogResult dr = cd.ShowDialog();
            //如果选中颜色，单击“确定”按钮则改变文本框的文本颜色
            if (dr == DialogResult.OK)
            {
                SF.BackColor = cd.Color;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            colors[PreI] = GetColor();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SelectLaser_SelectedIndexChanged(object sender, EventArgs e)
        {
            colors[PreI] = GetColor();
            SetColor(colors[SelectLaser.SelectedIndex]);
            PreI = SelectLaser.SelectedIndex;
        }
    }
}
