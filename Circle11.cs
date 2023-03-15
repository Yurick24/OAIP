using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OAIP_Laba2.Form1;
using Figures;

namespace OAIP_Laba2
{
    internal class Circle11 : Elips
    {
        Figure figure;
        public Circle11(int x, int y, int w)
        {
            this.x = x;
            this.y = y;
            this.w = w;
        }
        public Circle11()
        {
            this.x = 0;
            this.y = 0;
            this.w = 0;
        }
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawEllipse(Init.pen, this.x, this.y, this.w, this.w);
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
