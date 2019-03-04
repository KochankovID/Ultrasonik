using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задача_2_Вариант_14
{
    public partial class UltraSonick : UserControl
    {

        private int port; // Количество очков
        private int dist; // Дистанция
        private Rectangle PortR, LeftR, RightR, titelR;

        // Методы класса
        public UltraSonick()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            double Portk = 0.54, Portg = 0.02, Portl = 0.3757, Porto = 0.18;
            PortR.X = (int)Math.Round(Width * Portk);
            PortR.Y = (int)Math.Round(Height * Portg) + 1;
            PortR.Height = (int)Math.Round(Height * Porto);
            PortR.Width = (int)Math.Round(Width * Portl);

            double Leftk = 0.03, Leftg = 0.4, Lefto = 0.158, Leftl = 0.156;
            LeftR.X = (int)Math.Round(Width * Leftk);
            LeftR.Y = (int)Math.Round(Height * Leftg) + 1;
            LeftR.Height = (int)Math.Round(Height * Lefto);
            LeftR.Width = (int)Math.Round(Width * Leftl);

            double Rightk = 0.82, Rightg = 0.4, Righto = 0.158, Rightl = 0.15;
            RightR.X = (int)Math.Round(Width * Rightk);
            RightR.Y = (int)Math.Round(Height * Rightg) + 1;
            RightR.Height = (int)Math.Round(Height * Righto);
            RightR.Width = (int)Math.Round(Width * Rightl);

            base.OnPaint(e);
            e.Graphics.DrawImage(Image.FromFile("E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\block.wmf"), ClientRectangle);
            e.Graphics.DrawImage(Image.FromFile("E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Port_up.wmf"), PortR);
            e.Graphics.DrawImage(Image.FromFile("E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Right.wmf"), RightR);
            e.Graphics.DrawImage(Image.FromFile("E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Left.wmf"), LeftR);
        }
    }
}
