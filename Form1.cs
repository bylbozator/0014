using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0014
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }
      
       
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawCircles(e.Graphics, 5, 200, 200, 100);

        }
        // Метод для рекурсивного рисования кругов
        private void DrawCircles(Graphics g, int recursionDepth, int x, int y, int radius)
        {
            // Условие выхода из рекурсии
            if (recursionDepth == 0)
                return;
            // Рисование круга с использованием синего цвета и заданной толщины линии
            using (Pen pen = new Pen(Color.Blue, 2))
            {
                g.DrawEllipse(pen, x - radius, y - radius, 2 * radius, 2 * radius);
            }
            // Рекурсивные вызовы для рисования кругов с уменьшенным радиусом
            DrawCircles(g, recursionDepth - 1, x - radius, y +  radius, radius / 2);
            DrawCircles(g, recursionDepth - 1, x + radius, y +  radius, radius / 2);
        }


    }
}
