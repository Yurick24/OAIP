using Madara;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OAIP_Laba2.Form1;

namespace OAIP_Laba2
{

   /* class ShapeContainer11 
    { 

    };*/
    class Elips : Figure
    {
        public Elips(int x, int y, int w, int h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }
        public Elips()
        {
            this.x = 0;
            this.y = 0;
            this.w = 0;
            this.h = 0;
        }
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawEllipse(Init.pen, this.x, this.y, this.w, this.h);
            Init.pictureBox.Image = Init.bitmap;
        }




        public void DeleteF(Figure figure, bool flag = true)
        {
            if (flag == true)
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                ShapeContainer11.figureList.Remove(figure);
                Init.pictureBox.Image = Init.bitmap;
                foreach (Figure f in ShapeContainer11.figureList)
                {
                    f.Draw();
                }
            }
            else
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                ShapeContainer11.figureList.Remove(figure);
                Init.pictureBox.Image = Init.bitmap;
                foreach (Figure f in ShapeContainer11.figureList)
                {
                    f.Draw();
                }
                ShapeContainer11.figureList.Add(figure);
            }
        }

        Figure figure;
        public override void MoveTo(int x, int y)
        {
            if (!((figure.x + x < 0 && this.y + y < 0)
                || (figure.y + y < 0)
                || (figure.x + x > Init.pictureBox.Width && this.y + y < 0)
                || (figure.x + this.w + x > Init.pictureBox.Width)
                || (figure.x + x > Init.pictureBox.Width && this.y + y > Init.pictureBox.Height)
                || (figure.y + this.h + y > Init.pictureBox.Height)
                || (figure.x + x < 0 && this.y + y > Init.pictureBox.Height) || (this.x + x < 0)))
            {
                figure.x += x;
                figure.y += y;
                figure.DeleteF(this, false);
                figure.Draw();
            }
        }
    }


    internal class Elips1 : Elips
    {
        internal class Elips
        {

        }
    }



}
