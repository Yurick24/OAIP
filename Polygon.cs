using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OAIP_Laba2.Form1;

namespace OAIP_Laba2
{
    internal class Polygon : Figure
    {
        public Polygon(int x, int y, int w, int h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
        }
        public Polygon()
        {
            this.x = 0;
            this.y = 0;
            this.w = 0;
        }
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            //g.DrawPolygon(Init.pen, this.x, this.y);
            Init.pictureBox.Image = Init.bitmap;
            /*while (i != n) { }
            int i;*/
        }
        public override void MoveTo(int x, int y)
        {
            if (!((this.x + x < 0 && this.y + y < 0)
                || (this.y + y < 0)
                || (this.x + x > Init.pictureBox.Width && this.y + y < 0)
                || (this.x + this.w + x > Init.pictureBox.Width)
                || (this.x + x > Init.pictureBox.Width && this.y + y > Init.pictureBox.Height)
                || (this.y + this.w + y > Init.pictureBox.Height)
                || (this.x + x < 0 && this.y + y > Init.pictureBox.Height) || (this.x + x < 0)))
            {
                this.x += x;
                this.y += y;
                this.DeleteF(false);
                this.Draw();
            }
        }
    }
}
