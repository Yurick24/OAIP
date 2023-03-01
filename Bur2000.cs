using Madara;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OAIP_Laba2.Form1;

namespace OAIP_Laba2
{
    internal class Bur2000 : Figure
    {
        public Rectangle r1;
        public Rectangle r2;
        public Circle11 c1;
        public Circle11 c2;
        public Circle11 c3;
        public Circle11 c4;
        public Bur2000(int x, int y, int w, int h)
        {
            this.r1 = new Rectangle(x, y, w, h);
            this.r2 = new Rectangle(x + w / 5, y - h / 10 , w / 5, h / 10);
            this.c1 = new Circle11(x + w / 10, y + h, w / 20);
            this.c2 = new Circle11((x + w) - w / 15, y + h, w / 20);
            this.c3 = new Circle11((x + w) - (w + 1) / 8 , y + h, w / 20);
            this.c4 = new Circle11((x + w) - w / 5, y + h, w / 20);
        }
        public override void Draw()
        {
            this.r1.Draw();
            this.r2.Draw();
            this.c1.Draw();
            this.c2.Draw();
            this.c3.Draw();
            this.c4.Draw();
            Init.pictureBox.Image = Init.bitmap;
        }
        public override void MoveTo(int x, int y)
        {
            if (!((this.r1.x + x < 0 && this.r1.y + y < 0) || (this.r1.y + y < 0) || (this.r1.x + x > Init.pictureBox.Width && this.r1.y + y < 0) || (this.c2.x + this.r1.w + x > Init.pictureBox.Width) || (this.r1.x + x > Init.pictureBox.Width && this.r1.y + y > Init.pictureBox.Height) || (this.r1.y + this.c2.h + y
    > Init.pictureBox.Height) || (this.r1.x + x < 0 && this.r1.y + y > Init.pictureBox.Height) || (this.r1.x + x < 0)))
            {
                this.r1.x += x;
                this.r1.y += y;
                this.r2.x += x;
                this.r2.y += y;
                this.c1.x += x;
                this.c1.y += y;
                this.c2.x += x;
                this.c2.y += y;
                this.c3.x += x;
                this.c3.y += y;
                this.c4.x += x;
                this.c4.y += y;
                this.DeleteF(this, false);
                this.Draw();
            }
        }
    }
}
