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
        private Menu1 regims;
        private Rectangle PortR, LeftR, RightR, MenuR, BlockR, PictureR;
        private string blokFile = "E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\block.wmf",
                       Left = "E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Left.wmf",
                       Right = "E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Right.wmf",
                       Ports_up = "E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Port_up.wmf";
        private List<String> Picture;
                       

        private void UltraSonick_MouseClick(object sender, MouseEventArgs e)
        {
            if (PortR.Contains(e.Location))
            {
                if (ports.getopenS()&&ports.isInside(e))
                {
                    ports.ChangePorts(e);
                    ports.open();
                    this.Invalidate();
                    return;
                }
                else
                {
                    ports.open();
                    this.Invalidate();
                    return;
                }
            }
            else
            {
                if (ports.getopenS())
                {
                    if (ports.isInside(e))
                    {
                        ports.ChangePorts(e);
                        ports.open();
                        this.Invalidate();
                        return;
                    }
                    else
                    {
                        ports.open();
                        this.Invalidate();
                    }
                }
            }


            if (MenuR.Contains(e.Location))
            {
                    regims.open();
                    this.Invalidate();
                    return;
            }
            else
            {
                if ((regims.isInside(e))||(regims.isInsidePod(e)))
                {
                    if (regims.getopenS()&&regims.isInside(e))
                    {
                        regims.ChangePodpunct(e);
                        regims.openPP();
                        this.Invalidate();
                        return;
                    }
                    else
                    {
                        if (regims.getopenp() && regims.isInsidePod(e))
                        {
                            regims.ChangePorts(e);
                            regims.openPP();
                            regims.open();
                            this.Invalidate();
                            return;
                        }
                    }
                }
                else
                {
                    if (regims.getopenS())
                    {
                        regims.open();
                    }
                    if (regims.getopenp())
                    {
                        regims.openPP();
                    }
                    this.Invalidate();
                }
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
            if (LeftR.Contains(e.Location))
            {
                Left = "E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Left_Fokused1.wmf";
                this.Invalidate();
                flag = true;
                return;
            }
            if (RightR.Contains(e.Location))
            {
                Right = "E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Right_Fokused.wmf";
                this.Invalidate();
                flag = true;
                return;
            }
            if (MenuR.Contains(e.Location)||(regims.getopenS() && regims.isInside(e)||(regims.getopenp() && regims.isInsidePod(e))))
            {
                regims.setMenuFokused();
                this.Invalidate();
                flag = true;
                return;
            }
            if (flag)
            {
                Ports_up = "E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Port_up.wmf";
                Left = "E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Left.wmf";
                Right = "E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Right.wmf";
                regims.setMenuUnFokused();
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
            regims = new Menu1("Измерения#Сравнения", "Cантиметры#Дюймы#Присутствие", "раст. см#расст. дюймы#присутствие");
            Picture = new List<string>();
            Picture.Add("E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Image1.wmf");
            Picture.Add("E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\image2.wmf");
            Picture.Add("E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Image3.wmf");
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            BlockR.X = 0;
            BlockR.Y = Height/5;
            BlockR.Height = Height*3 / 5;
            BlockR.Width = Width;
            e.Graphics.SetClip(BlockR);

            double Pik = 0.21, Pig = 0.135, Pio = 0.6, Pil = 0.6;
            PictureR.X = (int)Math.Round(BlockR.Width * Pik);
            PictureR.Y = BlockR.Y + (int)Math.Round(BlockR.Height * Pig) + 1;
            PictureR.Height = (int)Math.Round(BlockR.Height * Pio);
            PictureR.Width = (int)Math.Round(BlockR.Width * Pil);

            double Portk = 0.54, Portg = 0.02, Portl = 0.3757, Porto = 0.18;
            PortR.X = (int)Math.Round(BlockR.Width * Portk);
            PortR.Y = BlockR.Y + (int)Math.Round(BlockR.Height * Portg) + 1;
            PortR.Height = (int)Math.Round(BlockR.Height * Porto);
            PortR.Width = (int)Math.Round(BlockR.Width * Portl);

            double Leftk = 0.03, Leftg = 0.395, Lefto = 0.17, Leftl = 0.156;
            LeftR.X = (int)Math.Round(BlockR.Width * Leftk);
            LeftR.Y = BlockR.Y + (int)Math.Round(BlockR.Height * Leftg) + 1;
            LeftR.Height = (int)Math.Round(BlockR.Height * Lefto);
            LeftR.Width = (int)Math.Round(BlockR.Width * Leftl);

            double Rightk = 0.82, Rightg = 0.395, Righto = 0.17, Rightl = 0.15;
            RightR.X = (int)Math.Round(BlockR.Width * Rightk);
            RightR.Y = BlockR.Y + (int)Math.Round(BlockR.Height * Rightg) + 1;
            RightR.Height = (int)Math.Round(BlockR.Height * Righto);
            RightR.Width = (int)Math.Round(BlockR.Width * Rightl);

            double Menuk = 0.07, Menug = 0.6, Menul = 0.442, Menuo = 0.3925;
            MenuR.X = (int)Math.Round(BlockR.Width * Menuk);
            MenuR.Y = BlockR.Y + (int)Math.Round(BlockR.Height * Menug) + 1;
            MenuR.Height = (int)Math.Round(BlockR.Height * Menuo);
            MenuR.Width = (int)Math.Round(BlockR.Width * Menul);

            double PTX = 0.45, PTY = 0.35;
            PortText.X = PortR.X + (int)Math.Round(PortR.Width * PTX); 
            PortText.Y = PortR.Y + (int)Math.Round(PortR.Height * PTY);

            base.OnPaint(e);
            e.Graphics.DrawImage(Image.FromFile(blokFile), e.Graphics.ClipBounds);
            e.Graphics.DrawImage(Image.FromFile(Ports_up), PortR);
            e.Graphics.DrawImage(Image.FromFile(Right), RightR);
            e.Graphics.DrawImage(Image.FromFile(Left), LeftR);
            e.Graphics.DrawImage(Image.FromFile(Picture[regims.getCurrentMenu()/2]), PictureR);
            regims.Draw(e.Graphics, MenuR.X, MenuR.Y, MenuR.Width, MenuR.Height);

            e.Graphics.ResetClip();
            ports.Draw(e.Graphics, PortText.X, PortText.Y, (int)Math.Round(Width *0.052), (int)Math.Round(Height * 0.044));
        }
    }
}
