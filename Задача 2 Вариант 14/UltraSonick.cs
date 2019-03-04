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
        private Rectangle PortR, image1R, image2R, titelR;

        // Методы класса
        public UltraSonick()
        {
            InitializeComponent();
            port = 1;
            dist = 0;

            PortR.X = this.Height * 13 / 16;
            PortR.Y = this.Height / 35;
            PortR.Height = this.Height*2 / 13;
            PortR.Width = this.Width*6 /19;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.DrawImage(Image.FromFile("C:\\Users\\Илья\\Desktop\\Визуальное программирование\\Задача 2 Вариант 14\\Задача 2 Вариант 14\\Resources\\UltraSonik (1).wmf"), ClientRectangle);
            e.Graphics.DrawImage(Image.FromFile("C:\\Users\\Илья\\Desktop\\Визуальное программирование\\Задача 2 Вариант 14\\Задача 2 Вариант 14\\Resources\\up_port.wmf"), PortR);
        }
    }
}
