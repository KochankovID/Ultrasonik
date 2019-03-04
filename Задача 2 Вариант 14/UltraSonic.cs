using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Задача_2_Вариант_14
{
    class UltraSonic
    {
        // Данные классы
        private int port; // Количество очков
        private int dist; // Дистанция
        private Rectangle BlockR, PortR, image1R, image2R, titelR;

        // Методы класса
        public UltraSonic(Point p, int size)
        {
            // Блок
            port = 1;
            dist = 0;
            BlockR.X = p.X;
            BlockR.Y = p.Y;
            BlockR.Width = size;
            BlockR.Height = size;

            // Заголовок
            titelR.X = BlockR.X;
            titelR.Y = BlockR.Y;
            titelR.Height = size / 5;
            titelR.Width = size;

            // Меню портов
            PortR.X = size * 2 / 3 + BlockR.X;
            PortR.Y = size  / 20 + BlockR.Y;
            PortR.Height = size / 3;
            PortR.Width = size / 7;

            // Картика блока
            //xyImage.X = size / 6 + xyBlock.X;
            //xyImage.Y = size / 4 + xyBlock.Y;
            //width_image = size / 4 + 5;
            //height_image = size / 4;
        }
        internal void Draw(Graphics g)
        {
            g.FillPie(Brushes.Black, BlockR, 1.5f, 1.5f);
        }
    }

}
