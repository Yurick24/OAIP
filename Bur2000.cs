using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static OAIP_Laba2.Form1;
using Figures;

namespace OAIP_Laba2
{
    internal class Bur2000 : Figure
    {
        Figure figure;
        public PointF[] pointFS;
        private int numPoints = 3;
        public Bur2000(int x, int y, int w, int h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }
        public Bur2000()
        {
            this.x = 0;
            this.y = 0;
            this.w = 0;
            this.h = 0;
        }
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            this.pointFS = new PointF[numPoints];
            g.DrawRectangle(Init.pen, this.x, this.y + this.h / 5, this.w - this.w / 4, this.h - this.h / 5 - this.h / 5);
            g.DrawRectangle(Init.pen, this.x + this.w / 8, this.y, this.w - this.w / 2 - this.w / 8, this.h / 5);
            g.DrawEllipse(Init.pen, this.x + this.w / 10, this.y + (this.h - this.h / 5), this.h / 7, this.h / 7);
            g.DrawEllipse(Init.pen, this.x + (this.w / 3) + (this.w / 10), this.y + (this.h - this.h / 5), this.h / 7, this.h / 7);
            g.DrawEllipse(Init.pen, this.x + (this.w / 3) + (this.w / 5) + (this.w / 55), this.y + (this.h - this.h / 5), this.h / 7, this.h / 7);
            g.DrawEllipse(Init.pen, this.x + (this.w / 3) + (this.w / 3), this.y + (this.h - this.h / 5), this.h / 7, this.h / 7);
            pointFS[0].X = this.x + this.w * 3 / 4;
            pointFS[0].Y = this.y + this.h / 5;
            pointFS[1].X = this.x + this.w * 3 / 4;
            pointFS[1].Y = this.y + this.h - (this.h / 5);
            pointFS[2].X = this.x + (this.w - this.w / 55);
            pointFS[2].Y = this.y + this.h - (this.h / 5);
            g.DrawPolygon(Init.pen, pointFS);
            Init.pictureBox.Image = Init.bitmap;
        }
        public override void MoveTo(int x, int y)
        {
            if (!((this.x + x < 0 && this.y + y < 0)
                || (this.y + y < 0)
                || (this.x + x > Init.pictureBox.Width && this.y + y < 0)
                || (this.x + this.w + x > Init.pictureBox.Width)
                || (this.x + x > Init.pictureBox.Width && this.y + y > Init.pictureBox.Height)
                || (this.y + this.h + y > Init.pictureBox.Height)
                || (this.x + x < 0 && this.y + y > Init.pictureBox.Height) || (this.x + x < 0)))
            {
                this.x += x;
                this.y += y;
                Graphics g = Graphics.FromImage(Init.bitmap);
                Figures.ShapeContainer.RemoveFigure(figure);

                g.Clear(Color.White);

                Init.pictureBox.Image = Init.bitmap;
                foreach (Figure f in Figures.ShapeContainer.figureList)
                {
                    f.Draw();
                }
                Figures.ShapeContainer.AddFigure(figure);
            }
        }
    }
}
