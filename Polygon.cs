using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OAIP_Laba2.Form1;
using Figures;
using System.Reflection;
using System.Windows.Forms;

namespace OAIP_Laba2
{
    internal class Polygon : Figure
    {
        Bitmap bitmap;
        PointF[] point;
        int numVertices;
        Triangle triangle;
        public Polygon(PointF[] point)
        {
            this.point = point;
        }

        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawPolygon(Init.pen, point);
            Init.pictureBox.Image = Init.bitmap;
        }

        Figure figure;
        public override void MoveTo(int x, int y)
        {
            bool mnog = false;
            try
            {
                for (int j = 0; j < point.Length; j++)
                {
                    if (!((this.point[j].X + x < 0 && this.point[j].Y + y < 0)
                     || (this.point[j].Y + y < 0)
                     || (this.point[j].X + x > Init.pictureBox.Width && this.point[j].Y + y < 0)
                     || (this.point[j].X + this.w + x > Init.pictureBox.Width)
                     || (this.point[j].X + x > Init.pictureBox.Width && this.point[j].Y + y > Init.pictureBox.Height)
                     || (this.point[j].Y + this.h + y > Init.pictureBox.Height)
                     || (this.point[j].X + x < 0 && this.point[j].Y + y > Init.pictureBox.Height) || (this.point[j].X + x < 0)))
                    {
                        mnog = true;
                    }
                    else
                    {
                        mnog = false;
                        break;
                    }
                }
                if (mnog)
                {
                    for (int i = 0; i < point.Length; i++)
                    {
                        point[i].X += x;
                        point[i].Y += y;
                    }
                }

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    class Triangle : Polygon
    {
        PointF[] point;
        Triangle triangle;
        Polygon polygon;
        Pen pen;
        Figure figure;

        public Triangle(PointF[] point) : base(point)
        {
            this.point = point;
        }
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawPolygon(Init.pen, point);
            Init.pictureBox.Image = Init.bitmap;
        }

        public override void MoveTo(int x, int y)
        {
            bool mnog = false;
            try
            {
                for (int j = 0; j < point.Length; j++)
                {
                    if (!((this.point[j].X + x < 0 && this.point[j].Y + y < 0)
                     ||(this.point[j].Y + y < 0)
                     ||(this.point[j].X + x > Init.pictureBox.Width && this.point[j].Y + y < 0)
                     ||(this.point[j].X + this.w + x > Init.pictureBox.Width)
                     ||(this.point[j].X + x > Init.pictureBox.Width && this.point[j].Y + y > Init.pictureBox.Height)
                     ||(this.point[j].Y + this.h + y > Init.pictureBox.Height)
                     ||(this.point[j].X + x < 0 && this.point[j].Y + y > Init.pictureBox.Height) || (this.point[j].X + x < 0)))
                    {
                        mnog = true;
                    }
                    else
                    {
                        mnog = false;
                        break;
                    }
                }
                if (mnog)
                {
                    for (int i = 0; i < point.Length; i++)
                    {
                        point[i].X += x;
                        point[i].Y += y;
                    }
                }

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
