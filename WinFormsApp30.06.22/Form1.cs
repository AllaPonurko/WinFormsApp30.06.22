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
            SetSize();
            this.Text = Convert.ToString(Screen.PrimaryScreen.Bounds);
        }
        /// <summary>
        /// создаем логическую переменную для определения нажатия мыши
        /// </summary>
        private bool IsClamped = false;
        Pen pen = new Pen(Color.Black,3);
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
            /// <summary>
            /// метод сброса, позволяющий не сохранять массив точек при отпускании мыши
            /// </summary>
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
        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;//позволяет установить размеры экрана
            bitmap = new Bitmap(rectangle.Width, rectangle.Height);
            g = Graphics.FromImage(bitmap);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;//делаем рисование линии
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;  //  гладким                                                  //более гладким
        }
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
            points.ResetPoint();
        }

        private void pictureBoxPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (!IsClamped) return;
            points.SetPoint(e.X,e.Y);
            if (points.GetCountPoints() >= 2)
            { 
                g.DrawLines(pen, points.GetPoints());
                pictureBoxPaint.Image = bitmap;
                points.SetPoint(e.X, e.Y);
            }
            
        }
        /// <summary>
        /// выход из приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// очистка изображения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            g. Clear(Color.White);
            pictureBoxPaint.Image = bitmap;
        }

        private void btnColor1_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }
        /// <summary>
        /// вызываем палитру цветов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColor8_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }
        /// <summary>
        /// изменение толщины карандаша
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Image file JPG(*.JPG)|*.jpg";
            if(saveFileDialog1.ShowDialog()==DialogResult.OK/*&&pictureBoxPaint!=null*/)
            {
                try
                {
                    pictureBoxPaint.Image.Save(saveFileDialog1.FileName);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {openFileDialog1.Filter= "Image file JPG(*.JPG)|*.jpg";
            
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                //pictureBoxPaint.ImageLocation = openFileDialog1.FileName;
                pictureBoxPaint.Image = new Bitmap(openFileDialog1.FileName);
            }
        }
    }
}
