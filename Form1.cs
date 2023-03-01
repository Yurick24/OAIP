using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Madara;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OAIP_Laba2
{
    public partial class Form1 : Form
    {
        public static class Init
        {
            public static Bitmap bitmap;
            public static PictureBox pictureBox;
            public static Pen pen;
        }

        Bitmap bitmap;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            this.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            this.pen = new Pen(Color.Black, 5);
            Init.bitmap = this.bitmap;
            Init.pictureBox = pictureBox1;
            Init.pen = this.pen;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { 
            Graphics g = Graphics.FromImage(Init.bitmap);
            Rectangle rectangle = new Rectangle(int.Parse(textBox1.Text),
            int.Parse(textBox2.Text),
            int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            rectangle.Draw();
            Init.pictureBox.Image = Init.bitmap;
            }
            if (radioButton2.Checked)
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                Rectangle rectangle = new Rectangle(int.Parse(textBox1.Text),
                int.Parse(textBox2.Text),
                int.Parse(textBox3.Text), int.Parse(textBox3.Text));
                rectangle.Draw();
                Init.pictureBox.Image = Init.bitmap;
            }
            if (radioButton3.Checked)
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                Elips elips = new Elips(int.Parse(textBox1.Text),
                int.Parse(textBox2.Text),
                int.Parse(textBox3.Text), int.Parse(textBox4.Text));
                elips.Draw();
                Init.pictureBox.Image = Init.bitmap;
            }
            if (radioButton4.Checked)
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                Elips Circle11 = new Elips(int.Parse(textBox1.Text),
                int.Parse(textBox2.Text),
                int.Parse(textBox3.Text), int.Parse(textBox3.Text));
                Circle11.Draw();
                Init.pictureBox.Image = Init.bitmap;
            }
            if (radioButton5.Checked)
            {
                
            }
            if (radioButton6.Checked)
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                Bur2000 bur2000 = new Bur2000(int.Parse(textBox1.Text),
                int.Parse(textBox2.Text),
                int.Parse(textBox3.Text), int.Parse(textBox4.Text));
                bur2000.Draw();
                Init.pictureBox.Image = Init.bitmap;
            }
            if (radioButton7.Checked)
            {
                
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Clear(Color.White);
            pictureBox1.Refresh();
            comboBox2.Items.Clear();
            comboBox2.Refresh();
        }
    }
}
