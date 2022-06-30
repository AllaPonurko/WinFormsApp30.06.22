using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp30._06._22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// создаем логическую переменную для определения нажатия мыши
        /// </summary>
        private bool IsClamped = false;
        Pen pen = new Pen(Color.Black);
        /// <summary>
        /// создаём класс массива точек для создания рисунка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private class ArrayPoints
        {
            int index = 0;
            Point[] points;
            public ArrayPoints(int size)
            {
                if (size <= 0) size = 2;
                points = new Point[size];
            }
           public void SetPoint(int x,int y)
            {
                if (index >= points.Length)
                    index = 0;
                points[index] = new Point(x, y);
                index++;
            }
            public void ResetPoint()
            {
                index = 0;
            }
            public int GetCountPoints()
            {
                return index;
            }
            public Point[]GetPoints()
            {
                return points;
            }
        }
        /// <summary>
        /// создаём объект класса ArrayPoints размером 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ArrayPoints points = new ArrayPoints(2);
        Bitmap bitmap = new Bitmap(100, 100);
        Graphics g;
        private void pictureBoxPaint_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPaint_MouseDown(object sender, MouseEventArgs e)
        {
            IsClamped = true;
        }

        private void pictureBoxPaint_MouseUp(object sender, MouseEventArgs e)
        {
            IsClamped = false;
        }

        private void pictureBoxPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (!IsClamped) return;
            points.SetPoint(e.X,e.Y);
            if (points.GetCountPoints() >= 2)
            { 
                g.DrawLines(pen, points.GetPoints());
            }
            
        }
    }
}
