using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        SolidBrush Fill;
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
        Point pointStart = new Point();
        Point pointEnd = new Point();
        Point toPoint = new Point();
        Rectangle rect = new Rectangle();
        private bool SelectRect = false;
        private bool SelectLine = false;
        private bool SelectCircle = false;
        private bool SelectPaint = true;
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
            if (e.Button == MouseButtons.Right) // Если нажата правая кнопка мыши
            {
                rect.Width = 0;
                rect.Height = 0;
                rect.X = e.X;
                rect.Y = e.Y;
            }
            if (e.Button == MouseButtons.Left) // Если нажата левая кнопка мыши
            {
                // Если рисуем линию
                if (SelectLine)
                {
                    // Получаем координаты нажатия левой кнопки мыши в PictureBox
                    pointStart.X = e.X;
                    pointStart.Y = e.Y;
                    toPoint = pointStart;
                }
                // Если рисуем прямоугольник
                if (SelectRect)
                {
                    rect.Width = 0;
                    rect.Height = 0;
                    rect.X = e.X;
                    rect.Y = e.Y;
                }
                // Если рисуем окружность
                if (SelectCircle)
                {
                    rect.Height = 0;
                    rect.Width = 0;
                    rect.X = e.X;
                    rect.Y = e.Y;
                }
            }
        }

        private void pictureBoxPaint_MouseUp(object sender, MouseEventArgs e)
        {
            IsClamped = false;
            points.ResetPoint();
            if (e.Button == MouseButtons.Right)// Если нажата правая кнопка мыши
            {
                g = Graphics.FromImage(bitmap);
                g.DrawRectangle(pen, rect); // Нарисуем прямоугольник-контур для осветлённой области
                g.Dispose();
                pictureBoxPaint.Invalidate();
            }
            if (e.Button == MouseButtons.Left) // Если нажата левая кнопка мыши
            {
                // Рисуем в PictureBox (только в загруженном в элементе изображении)
                g = Graphics.FromImage(bitmap);
                if (SelectLine)
                {
                    pointEnd.X = e.X;
                    pointEnd.Y = e.Y;
                    g.DrawLine(pen, pointStart, pointEnd);

                }
                if (SelectRect)
                {
                    //if (Color_Fill != Color.Violet) { g.FillRectangle(Fill, rect); }
                    // Заполнение цветом прямоугольной области ограниченной rect

                    g.DrawRectangle(pen, rect);

                }
                if (SelectCircle)
                {
                    //if (Color_Fill != Color.Violet) { g.FillEllipse(Fill, rect); }
                    //// Заполнение цветом эллептической области ограниченной CircleRect
                    g.DrawEllipse(pen, rect);
                }
                g.Dispose();
               pictureBoxPaint.Invalidate(); // Обновляем PictureBox
            }

        }

        private void pictureBoxPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (!IsClamped) return;
            if (e.Button == MouseButtons.Right)// Если нажата правая кнопка мыши
            {
                rect.Width = e.X - rect.X;
                rect.Height = e.Y - rect.Y;
            }
            if (e.Button == MouseButtons.Left)// Если нажата левая кнопка мыши      
            {
                try 
                { 
                // Если рисуем прямоугольник, отображаем заготовку прямоугольника пунктирными линиями
                if (SelectRect)
                {
                    ControlPaint.DrawReversibleFrame(pictureBoxPaint.RectangleToScreen(rect),
                        Color.Black, FrameStyle.Dashed);
                    rect.Width = e.X - rect.X; // Получаем значение ширины прямоугольника
                    rect.Height = e.Y - rect.Y; // Получаем значение высоты прямоугольника
                    ControlPaint.DrawReversibleFrame(pictureBoxPaint.RectangleToScreen(rect),
                        Color.Black, FrameStyle.Dashed);
                    pictureBoxPaint.Refresh();
                }
                // Если рисуем линию, отображаем заготовку линии

                if (SelectLine)
                {
                    // Отображаем заготовку линии до тех пор пока не отпустим левую кнопку мыши

                    ControlPaint.DrawReversibleLine(pictureBoxPaint.PointToScreen(pointStart),
                        pictureBoxPaint.PointToScreen(toPoint), Color.Black);
                    toPoint = new Point(e.X, e.Y);
                    ControlPaint.DrawReversibleLine(pictureBoxPaint.PointToScreen(pointStart),
                       pictureBoxPaint.PointToScreen(toPoint), Color.Black);
                    pictureBoxPaint.Refresh();
                }
                if (SelectCircle)
                // Если рисуем окружность, отображаем заготовку окружности пунктирными линиями
                {
                    ControlPaint.DrawReversibleFrame(pictureBoxPaint.RectangleToScreen(rect),
                        Color.Black, FrameStyle.Dashed);
                    rect.Width = e.X - rect.X;
                    rect.Height = e.Y - rect.Y;
                    ControlPaint.DrawReversibleFrame(pictureBoxPaint.RectangleToScreen
                        (rect),
                        Color.Black, FrameStyle.Dashed);
                    pictureBoxPaint.Refresh();
                }
                if(SelectPaint)
                {
                   points.SetPoint(e.X, e.Y);
                if (points.GetCountPoints() >= 2)
                   {
                    g.DrawLines(pen, points.GetPoints());
                    pictureBoxPaint.Image = bitmap;
                    points.SetPoint(e.X, e.Y);
                   }
                }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
        /// <summary>
        /// сохранение изображения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// открытие файла с изображением
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripButton_Click(object sender, EventArgs e)
        {openFileDialog1.Filter= "Image file JPG(*.JPG)|*.jpg";
            
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                //pictureBoxPaint.ImageLocation = openFileDialog1.FileName;
                pictureBoxPaint.Image = new Bitmap(openFileDialog1.FileName);
                //this.Controls.Add(pictureBoxPaint);
            }
        }

        private void btnDrawCircle_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnDrawCircle, "Нарисовать круг");
        }
        
        private void btnDrawCircle_Click(object sender, EventArgs e)
        {
            SelectCircle = true;
            SelectLine = false;
            SelectRect = false;
        }
        
        private void pictureBoxPaint_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
            pen.Width = 5;
        }

        private void btnEraser_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnEraser, "Ластик");
        }

        private void btnDrawRectangle_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnDrawRectangle, "Нарисовать прямоугольник");
        }

        private void btnDrawLine_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnDrawLine, "Нарисовать линию");
        }

        private void btnDrawLine_Click(object sender, EventArgs e)
        {
            SelectCircle = false;
            SelectLine = true;
            SelectRect = false;
        }
        

        private void btnDrawRectangle_Click(object sender, EventArgs e)
        {
            SelectRect = true;
            SelectCircle = false;
            SelectLine = false;
        }
        
        private void pictureBoxPaint_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}

