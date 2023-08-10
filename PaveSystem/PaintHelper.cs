using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaveSystem
{
    public class PaintHelper
    {
        /// <summary>
        /// 返回圆角矩形路径   四个圆角是一样的
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static GraphicsPath GetRoundRect(Rectangle rect, int r)
        {
            GraphicsPath path = new GraphicsPath();
            int x = rect.X;
            int y = rect.Y;
            int w = rect.Width;
            int h = rect.Height;
            int d = 2 * r;//直径
            //左上角
            path.AddArc(new Rectangle(x, y, d, d), 180, 90);
            //上方
            path.AddLine(x + r, y, x + w - r, y);
            //右上角
            path.AddArc(new Rectangle(x + w - d, y, d, d), 270, 90);
            //右边
            path.AddLine(x + w, y + r, x + w, y + h - r);
            //右下角
            path.AddArc(new Rectangle(x + w - d, y + h - d, d, d), 0, 90);
            //下边
            path.AddLine(x + w - r, y + h, x + r, y + h);
            //左下角
            path.AddArc(new Rectangle(x, y + h - d, d, d), 90, 90);
            //左边
            path.AddLine(x, y + h - r, x, y + r);

            return path;
        }
    }
}
