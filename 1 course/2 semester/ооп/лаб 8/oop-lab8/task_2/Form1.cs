using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_2
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        Point[] point = new Point[100];
        Rect[] rect = new Rect[100];
        Line[] line = new Line[100];
        Circ[] circ = new Circ[100];
        Ell[] ell = new Ell[100];
        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fl;

            for (int i = 0; i < 20; i++)
            {
                g = pictureBox1.CreateGraphics();
                fl = random.Next(1, 6);
                if (fl == 1)
                {
                    point[i] = new Point(RandX(), RandY());
                    point[i].Draw(g);
                }

                if (fl == 2)
                {
                    line[i] = new Line(RandX(), RandY(), RandX(), RandY());
                    line[i].Draw(g);
                }
                if (fl == 3)
                {
                    rect[i] = new Rect(RandX(), RandY());
                    rect[i].Draw(g);
                }
                if (fl == 4)
                {
                    circ[i] = new Circ(RandX(), RandY());
                    circ[i].Draw(g);
                }
                if (fl == 5)
                {
                    ell[i] = new Ell(RandX(), RandY());
                    ell[i].Draw(g);
                }
            }




        }
        public float RandX()
        {
            float x = random.Next(0, 800);
            return x;
        }
        public float RandY()
        {
            float y = random.Next(0, 300);
            return y;
        }
        public class Shape
        {
            protected float x;
            protected float y;
            protected float x1;
            protected float y1;
            public Shape(float x, float y)
            {
                this.x = x;
                this.y = y;
            }
            public Shape(Shape shape)
            {
                this.x = shape.x;
                this.y = shape.y;
            }

            public void Draw(Graphics g)
            {

            }

        }
        public class Point : Shape
        {
            public Point(float x, float y) : base(x, y)
            {
                this.x = x;
                this.y = y;
            }
            public virtual void Draw(Graphics g)
            {
                g.DrawEllipse(Pens.Black, x, y, 10, 10);
            }
        }
        public class Line : Point
        {

            public Line(float x, float y, float x1, float y1) : base(x, y)
            {
                this.x = x;
                this.y = y;
                this.x1 = x1;
                this.y1 = y1;
            }
            public virtual void Draw(Graphics g)
            {
                g.DrawLine(Pens.Black, x, y, x1, y1);
            }
        }
        public class Rect : Shape
        {
            public Rect(float x, float y) : base(x, y)
            {
                this.x = x;
                this.y = y;
            }
            public virtual void Draw(Graphics g)
            {
                g.DrawRectangle(Pens.Black, x, y, 75, 75);
            }
        }
        public class Circ : Shape
        {
            public Circ(float x, float y) : base(x, y)
            {
                this.x = x;
                this.y = y;
            }
            public virtual void Draw(Graphics g)
            {
                g.DrawEllipse(Pens.Black, x, y, 50, 50);
            }
        }
        public class Ell : Circ
        {
            public Ell(float x, float y) : base(x, y)
            {
                this.x = x;
                this.y = y;
            }
            public virtual void Draw(Graphics g)
            {
                g.DrawEllipse(Pens.Black, x, y, 50, 100);
            }
        }
    }
}
