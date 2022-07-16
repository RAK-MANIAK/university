using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicPlotter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            one();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            one();
        }

        void one()
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            Pen a = new Pen(Color.Blue, 1);
            Pen b = new Pen(Color.Green, 2);
            Font drawFont = new Font("Arial", 12);
            Font signatureFont = new Font("Arial", 7);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            int sizeWidth = Form1.ActiveForm.Size.Width;
            int sizeHeight = Form1.ActiveForm.Size.Height;
            Point center = new Point((((int)sizeWidth / 2) - 8), (int)((sizeHeight / 2) - 19));
            g.DrawLine(a, 10, center.Y, center.X, center.Y);
            g.DrawLine(a, center.X, center.Y, 2 * center.X - 10, center.Y);
            g.DrawLine(a, center.X, 10, center.X, center.Y);
            g.DrawLine(a, center.X, center.Y, center.X, 2 * center.Y - 10);
            g.DrawString("X", drawFont, drawBrush, new PointF(2 * center.X - 5, center.Y + 10), drawFormat);
            g.DrawString("Y", drawFont, drawBrush, new PointF(center.X + 30, 5), drawFormat);
            g.DrawString("0", drawFont, drawBrush, new PointF(center.X, center.Y), drawFormat);
            g.DrawLine(a, center.X + 5, 20, center.X, 10);
            g.DrawLine(a, center.X - 5, 20, center.X, 10);
            g.DrawLine(a, 2 * center.X - 10, center.Y, center.X * 2 - 20, center.Y - 10);
            g.DrawLine(a, 2 * center.X - 10, center.Y, center.X * 2 - 20, center.Y + 10);
            int stepForAxes = 25;
            int lenghtShtrih = 3;
            int maxValueforAxesX = 10;
            int maxValueforAxesY = 10;
            float oneDelenieX = (float)maxValueforAxesX / ((float)center.X /
           (float)stepForAxes);
            float oneDelenieY = (float)maxValueforAxesY / ((float)center.Y /
           (float)stepForAxes);
            for (int i = center.X, j = center.X, k = 1; i < 2 * center.X - 30; j -= stepForAxes, i += stepForAxes, k++)
            {
                g.DrawLine(a, i, center.Y - lenghtShtrih, i, center.Y + lenghtShtrih);
                g.DrawLine(a, j, center.Y - lenghtShtrih, j, center.Y + lenghtShtrih);
                if (i < 2 * center.X - 55)
                {
                    g.DrawString((k * oneDelenieX).ToString("0.0"), signatureFont, drawBrush,
                   new Point(i + stepForAxes + 9, center.Y + 6), drawFormat);
                    g.DrawString(((k * oneDelenieX).ToString("0.0").ToString() + "-"), signatureFont, drawBrush, new Point(j - stepForAxes + 9, center.Y + 6), drawFormat);
                }
            }
            for (int i = center.Y, j = center.Y, k = 1; i < 2 * center.Y - 30; j -= stepForAxes, i += stepForAxes, k++)
            {
                g.DrawLine(a, center.X - lenghtShtrih, j, center.X + lenghtShtrih, j);
                g.DrawLine(a, center.X - lenghtShtrih, i, center.X + lenghtShtrih, i);
                if (i < 2 * center.X - 55)
                {
                    g.DrawString((k * oneDelenieY).ToString("0.0"), signatureFont, drawBrush,
                   new Point(center.X + 25, j - stepForAxes - 5), drawFormat);
                    g.DrawString(((k * oneDelenieY).ToString("0.0").ToString() + "-"), signatureFont, drawBrush, new Point(center.X + 25, i + stepForAxes - 5), drawFormat);
                }
            }
            int numOfPoint = 100;
            float[] first = new float[numOfPoint];
            for (int i = 0; i < numOfPoint; i++)
            {
                first[i] = (float)maxValueforAxesX / (float)numOfPoint * (i + 1) -
               (float)(maxValueforAxesX / 2);
            }
            float[] second = new float[numOfPoint];
            for (int i = 0; i < numOfPoint; i++)
            {
                second[i] = (float)(Math.Pow(Math.E, first[i]/2) * Math.Sin(2 * first[i]));
            }
            Point[] pointOne = new Point[numOfPoint];
            float tempX = 1 / oneDelenieX * stepForAxes;
            float tempY = 1 / oneDelenieY * stepForAxes;
            for (int i = 0; i < numOfPoint; i++)
            {
                pointOne[i].X = center.X + (int)(first[i] * tempX);
                pointOne[i].Y = center.Y - (int)(second[i] * tempY);
                chart1.Series[0].Points.AddXY(pointOne[i].X, pointOne[i].Y);
            }
            g.DrawCurve(b, pointOne);

        }
    }
}
