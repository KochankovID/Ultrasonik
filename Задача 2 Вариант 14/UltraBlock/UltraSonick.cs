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

        private int dist = 0; // Дистанция
        private SpisokPorts ports;
        private Rectangle PortR, LeftR, RightR, MenuR;
        private string blokFile = "E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\block.wmf",
                       Left = "E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Left.wmf",
                       Right = "E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Right.wmf",
                       Ports_up = "E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Port_up.wmf",
                       DownSpisok = "E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Port_down_spisok.wmf";


        private void UltraSonick_MouseClick(object sender, MouseEventArgs e)
        {
            if (!ports.getopenS())
            {
                if (PortR.Contains(e.Location))
                {
                    ports.open();
                    this.Invalidate();
                }
            }
            else
            {
                if (ports.isInside(e))
                {
                    ports.ChangePorts(e);
                    ports.open();
                    this.Invalidate();
                    return;
                }
                ports.open();
                this.Invalidate();
            }
        }
        private static bool flag = true;
        private void UltraSonick_MouseMove(object sender, MouseEventArgs e)
        {

            if (PortR.Contains(e.Location)||(ports.getopenS()&& ports.isInside(e)))
            {
                Ports_up = "E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Port_up_Fokused2.wmf";
                this.Invalidate();
                flag = true;
                return;
            }
            if(flag)
            {
                Ports_up = "E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Port_up.wmf";
                this.Invalidate();
                flag = false;
            }
        }

        Point PortText = new Point(); 

        // Методы класса
        public UltraSonick()
        {
            InitializeComponent();
            ports = new SpisokPorts("0#1#2#3#4");
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            double Portk = 0.54, Portg = 0.02, Portl = 0.3757, Porto = 0.18;
            PortR.X = (int)Math.Round(Width * Portk);
            PortR.Y = (int)Math.Round(Height * Portg) + 1;
            PortR.Height = (int)Math.Round(Height * Porto);
            PortR.Width = (int)Math.Round(Width * Portl);

            double Leftk = 0.03, Leftg = 0.395, Lefto = 0.17, Leftl = 0.156;
            LeftR.X = (int)Math.Round(Width * Leftk);
            LeftR.Y = (int)Math.Round(Height * Leftg) + 1;
            LeftR.Height = (int)Math.Round(Height * Lefto);
            LeftR.Width = (int)Math.Round(Width * Leftl);

            double Rightk = 0.82, Rightg = 0.395, Righto = 0.17, Rightl = 0.15;
            RightR.X = (int)Math.Round(Width * Rightk);
            RightR.Y = (int)Math.Round(Height * Rightg) + 1;
            RightR.Height = (int)Math.Round(Height * Righto);
            RightR.Width = (int)Math.Round(Width * Rightl);

            double Menuk = 0.07, Menug = 0.6, Menul = 0.442, Menuo = 0.3925;
            MenuR.X = (int)Math.Round(Width * Menuk);
            MenuR.Y = (int)Math.Round(Height * Menug) + 1;
            MenuR.Height = (int)Math.Round(Height * Menuo);
            MenuR.Width = (int)Math.Round(Width * Menul);

            double PTX = 0.45, PTY = 0.35;
            PortText.X = PortR.X + (int)Math.Round(PortR.Width * PTX); 
            PortText.Y = PortR.Y + (int)Math.Round(PortR.Height * PTY);

            base.OnPaint(e);
            e.Graphics.DrawImage(Image.FromFile(blokFile), ClientRectangle);
            e.Graphics.DrawImage(Image.FromFile(Ports_up), PortR);
            e.Graphics.DrawImage(Image.FromFile(Right), RightR);
            e.Graphics.DrawImage(Image.FromFile(Left), LeftR);
            e.Graphics.DrawImage(Image.FromFile(DownSpisok), MenuR);
            //e.Graphics.DrawString(port.ToString(), new Font("Ports", 12), Brushes.Black, PortText); 
            ports.Draw(e.Graphics, PortText.X, PortText.Y, (int)Math.Round(Width *0.052), (int)Math.Round(Height * 0.072));

        }
    }
}
