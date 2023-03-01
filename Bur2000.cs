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
        public Circle11 c1;
        public Circle11 c2;
        public Car(int x, int y, int w, int h, string nameCar)
        {
            this.r1 = new Rectangle(x, y, w, h);
            this.c1 = new Circle11(x, y + h, w / 5);
            this.c2 = new Circle11((x + w) - w / 5, y + h, w / 5);
        }
        public override void Draw()
        {
            this.r1.Draw();
            this.c1.Draw();
            this.c2.Draw();
            Init.pictureBox.Image = Init.bitmap;
        }
        public override void MoveTo(int x, int y)
        {

            if (!((this.r1.x + x < 0 && this.r1.y + y < 0) || (this.r1.y + y < 0) || (this.r1.x + x > Init.pictureBox.Width && this.r1.y + y < 0) || (this.r2.x + this.r1.w + x > Init.pictureBox.Width) || (this.r1.x + x > Init.pictureBox.Width && this.r1.y + y > Init.pictureBox.Height) || (this.r1.y + this.r2.h + y
    > Init.pictureBox.Height) || (this.r1.x + x < 0 && this.r1.y + y > Init.pictureBox.Height) || (this.r1.x + x < 0)))
            {
                this.r1.x += x;
                this.r1.y += y;
                this.c1.x += x;
                this.c1.y += y;
                this.c2.x += x;
                this.c2.y += y;
                //this.DeleteF(this, false);
                this.Draw();
            }
        }
    }


}
