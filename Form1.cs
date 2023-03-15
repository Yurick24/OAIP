using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Figures;
using static OAIP_Laba2.Elips1;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Reflection.Emit;

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
        int i = 0;
        int count = 1;
        private int numPoints;
        private bool flag;
        Bitmap bitmap;
        Pen pen;
        Bur2000 Bur2000;
        Rectangle rectangle;
        Polygon polygon;
        PointF[] point = new PointF[0];
        Square square;
        Circle11 circle;
        Elips elips;
        Triangle triangle;
        Figure figure;
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
            if (radioButton1.Checked)
            {
                rectangle = new Rectangle
                    (int.Parse(textBox1.Text),
                    int.Parse(textBox2.Text),
                    int.Parse(textBox3.Text),
                    int.Parse(textBox4.Text));
                Figures.ShapeContainer.AddFigure(rectangle);
                comboBox2.Items.Clear();
                try
                {
                    foreach (Figure f in Figures.ShapeContainer.figureList)
                    {
                        comboBox2.Items.Add(rectangle);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                rectangle.Draw();
                Init.pictureBox.Image = Init.bitmap;
                textBox3.Clear();
                textBox4.Clear();
            }
            if (radioButton2.Checked)
            {
                square = new Square
                    (int.Parse(textBox1.Text),
                    int.Parse(textBox2.Text),
                    int.Parse(textBox3.Text));
                Figures.ShapeContainer.AddFigure(square);
                comboBox2.Items.Clear();
                try
                {
                    foreach (Figure f in Figures.ShapeContainer.figureList)
                    {
                        comboBox2.Items.Add(square);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                square.Draw();
                Init.pictureBox.Image = Init.bitmap;
                textBox3.Clear();
            }
            if (radioButton3.Checked)
            {
                elips = new Elips
                    (int.Parse(textBox1.Text),
                    int.Parse(textBox2.Text),
                    int.Parse(textBox3.Text),
                    int.Parse(textBox4.Text));
                Figures.ShapeContainer.AddFigure(elips);
                comboBox2.Items.Clear();
                try
                {
                    foreach (Figure f in Figures.ShapeContainer.figureList)
                    {
                        comboBox2.Items.Add(elips);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                elips.Draw();
                Init.pictureBox.Image = Init.bitmap;
                textBox3.Clear();
                textBox4.Clear();
            }
            if (radioButton4.Checked)
            {
                circle = new Circle11
                    (int.Parse(textBox1.Text),
                    int.Parse(textBox2.Text),
                    int.Parse(textBox3.Text));
                Figures.ShapeContainer.AddFigure(this.circle);
                comboBox2.Items.Clear();
                try
                {
                    foreach (Figure f in Figures.ShapeContainer.figureList)
                    {
                        comboBox2.Items.Add(this.circle);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                circle.Draw();
                Init.pictureBox.Image = Init.bitmap;
                textBox3.Clear();
            }
            if (radioButton5.Checked)
            {
                polygon = new Polygon(point);
                Figures.ShapeContainer.AddFigure(this.polygon);

                comboBox2.Items.Clear();
                try
                {
                    foreach (Figure f in Figures.ShapeContainer.figureList)
                    {
                        comboBox2.Items.Add(f);
                        polygon.Draw();
                        textBox2.Enabled = true;
                        textBox3.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (radioButton6.Checked)
            {
                Bur2000 = new Bur2000
                    (int.Parse(textBox1.Text),
                    int.Parse(textBox2.Text),
                    int.Parse(textBox3.Text),
                    int.Parse(textBox4.Text));
                Figures.ShapeContainer.AddFigure(this.Bur2000);
                comboBox2.Items.Clear();
                try
                {
                    foreach (Figure f in Figures.ShapeContainer.figureList)
                    {
                        comboBox2.Items.Add(this.Bur2000);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Bur2000.Draw();
                Init.pictureBox.Image = Init.bitmap;
                textBox3.Clear();
                textBox4.Clear();
            }
            if (radioButton7.Checked)
            {
                triangle = new Triangle(point);
                Figures.ShapeContainer.AddFigure(this.triangle);

                comboBox2.Items.Clear();
                try
                {
                    foreach (Figure f in Figures.ShapeContainer.figureList)
                    {
                        comboBox2.Items.Add(f);
                        triangle.Draw();
                        textBox2.Enabled = true;
                        textBox3.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.SelectedItem == null)
                {
                    MessageBox.Show("Null");
                }
                else if (comboBox2.SelectedItem == rectangle)
                {
                    this.rectangle = (Rectangle)comboBox2.SelectedItem;
                    this.rectangle.MoveTo(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                }
                else if (comboBox2.SelectedItem == this.square)
                {
                    this.square = (Square)comboBox2.SelectedItem;
                    this.square.MoveTo(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                }
                else if (comboBox2.SelectedItem == this.elips)
                {
                    this.elips = (Elips)comboBox2.SelectedItem;
                    this.elips.MoveTo(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                }
                else if (comboBox2.SelectedItem == this.circle)
                {
                    this.circle = (Circle11)comboBox2.SelectedItem;
                    this.circle.MoveTo(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                }
                else if (comboBox2.SelectedItem == this.polygon)
                {
                    this.polygon = (Polygon)comboBox2.SelectedItem;
                    this.polygon.MoveTo(int.Parse(textBox2.Text), int.Parse(textBox3.Text));
                }
                else if (comboBox2.SelectedItem == this.triangle)
                {
                    this.triangle = (Triangle)comboBox2.SelectedItem;
                    this.triangle.MoveTo(int.Parse(textBox2.Text), int.Parse(textBox3.Text));
                }
                else if (comboBox2.SelectedItem == this.Bur2000)
                {
                    this.Bur2000 = (Bur2000)comboBox2.SelectedItem;
                    this.Bur2000.MoveTo(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteF(Figure figure, bool flag = true)
        {
            if (flag == true)
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                Figures.ShapeContainer.RemoveFigure(figure);
                g.Clear(Color.WhiteSmoke);
                Init.pictureBox.Image = Init.bitmap;
                foreach (Figure f in Figures.ShapeContainer.figureList)
                {
                    f.Draw();
                }
            }
            else
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                Figures.ShapeContainer.RemoveFigure(figure);
                g.Clear(Color.WhiteSmoke);
                Init.pictureBox.Image = Init.bitmap;
                foreach (Figure f in Figures.ShapeContainer.figureList)
                {
                    f.Draw();
                }
                Figures.ShapeContainer.AddFigure(figure);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.SelectedItem == null)
                {
                    MessageBox.Show("Null");
                }
                else
                {
                    Figure figure;
                    figure = (Figure)comboBox2.SelectedItem;
                    DeleteF(figure, true);
                    comboBox2.Items.RemoveAt(comboBox2.SelectedIndex);
                    comboBox2.ResetText();
                    comboBox2.Update();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                numPoints = int.Parse(textBox1.Text);
                this.point = new PointF[numPoints];
                flag = true;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                label1.Text = $"{count}-я точка: ";
            }
            else
            {
                if (i < numPoints - 1)
                {
                    count++;
                    label1.Text = $"{count}-я точка: ";
                    point[i].X = float.Parse(textBox2.Text);
                    point[i].Y = float.Parse(textBox3.Text);
                    i++;
                    textBox2.Clear();
                    textBox3.Clear();
                }
                else
                {
                    point[i].X = float.Parse(textBox2.Text);
                    point[i].Y = float.Parse(textBox3.Text);
                    button1.Enabled = true;

                    label1.Text = "Многоугольник собран!";
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    flag = false;
                }
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "3";
            textBox1.Enabled = false;
            textBox4.Visible = false;
            textBox4.Enabled = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            flag = false;
            textBox1.Text = "";
            textBox1.Enabled = true;
            textBox4.Visible = false;
            textBox4.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Enabled = true;
            textBox4.Visible = true;
            textBox4.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Enabled = true;
            textBox4.Visible = false;
            textBox4.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Enabled = true;
            textBox4.Visible = true;
            textBox4.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Enabled = true;
            textBox4.Visible = false;
            textBox4.Enabled = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Enabled = true;
            textBox4.Visible = true;
            textBox4.Enabled = true;
        }
    }
}
