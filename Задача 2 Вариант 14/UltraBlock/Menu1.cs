using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задача_2_Вариант_14
{
    class Menu1
    {

        private String menuBack, menuPodpukt;
        public void setMenuFokused()
        {
            if((currentMenu % 2)==0)
            {
                currentMenu++;
            }
            return;
        }
        public void setMenuUnFokused()
        {
            if (((currentMenu % 2) != 0)&&(currentMenu>0))
            {
                currentMenu--;
            }
            return;
        }
        private int currentMenu;
        private bool openS, openP;
        Rectangle Location;
        private List<String> Files;

        private List<String> menuPunct;
        private List<String> menuPodpunct;
        private List<String> menuPodpunct1;
        private List<String> menuPodpunct2;
        public Menu1(string srt1, string str2, string str3)
        {
            menuBack = "E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\BackMenucdr.wmf";
            menuPodpukt = "E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Podpunkt.wmf";
            Files = new List<string>();
            Files.Add("E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Port_Down_Spisok.wmf");
            Files.Add("E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Port_Down_Spisok_Fokused.wmf");
            Files.Add("E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\inch.wmf");
            Files.Add("E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\inch_Fokused.wmf");
            Files.Add("E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\pere.wmf");
            Files.Add("E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\pere_fokused.wmf");

            menuPunct = new List<string>();
            menuPodpunct1 = new List<string>();
            menuPodpunct2 = new List<string>();
            menuPunct.AddRange(srt1.Split('#'));
            menuPodpunct1.AddRange(str2.Split('#'));
            menuPodpunct2.AddRange(str3.Split('#'));
            currentMenu = 0;
            openS = false;
            openP = false;
        }

        public bool getopenS()
        {
            return openS;
        }
        public bool getopenp()
        {
            return openP;
        }
        internal void openPP()
        {
            if (openP)
            {
                openP = false;
            }
            else
            {
                openP = true;
            }
        }

        internal void open()
        {
            if (openS)
            {
                openS = false;
            }
            else
            {
                openS = true;
            }
        }

        internal bool isInside(System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Y < Location.Height + Location.Y) || (e.Y > Location.Height + Location.Y + (Location.Height / 3 * menuPunct.Count)))
            {

                    return false;
            }
            if ((e.X < Location.X) || (e.X > Location.X + Location.Width))
            {
                return false;
            }
            return true;
        }

        internal bool isInsidePod(System.Windows.Forms.MouseEventArgs e)
        {
        if ((e.Y < Location.Height + Location.Y) || (e.Y > Location.Height + Location.Y + (Location.Height / 3 * menuPodpunct.Count)))
        {
            return false;
        }

        if((e.X < Location.X + Location.Width) || (e.X > Location.X + Location.Width + Location.Width))
        {
            return false;
        }
        return true;
        }

        internal void ChangePorts(MouseEventArgs e)
        {
            if (menuPodpunct == menuPodpunct1)
            {
                currentMenu = (((e.Y - Location.Height - Location.Y) - 1) / (Location.Height / 4)) + (((e.Y - Location.Height - Location.Y) - 1) / (Location.Height / 4));

            }
        }
        internal void ChangePodpunct(MouseEventArgs e)
        {
            if((((e.Y - Location.Height - Location.Y) - 1) / (Location.Height / 3)) == 0)
            {
                menuPodpunct = menuPodpunct1;
            }
            else
            {
                menuPodpunct = menuPodpunct2;
            }
        }

        public int getCurrentMenu()
        {
            return currentMenu;
        }
        internal void Draw(Graphics graphics, int x, int y, int width, int height)
        {
            graphics.ResetClip();
            Location.X = x;
            int k = 15;
            int l = 2;
            Location.Y = y;
            Location.Width = width;
            Location.Height = height;
            graphics.DrawImage(Image.FromFile(Files[currentMenu]), Location);
            if (!openS)
            {
                return;

            }
            else
            {
                for (int i = 0; i < menuPunct.Count; i++)
                {
                    graphics.DrawImage(Image.FromFile(menuBack), Location.X, Location.Height + Location.Y + (Location.Height / 3 * i), Location.Width, Location.Height / 3);
                    graphics.DrawString(menuPunct[i], new Font("Ports", Location.Height / k * l < Location.Width / k * l ? Location.Height / k * l : Location.Width / k * l), Brushes.Black, Location.X + Location.Width / 20, Location.Height / 20 + Location.Height + Location.Y + (Location.Height / 3 * i));
                }
                if (getopenp())
                {
                    for (int i = 0; i < menuPodpunct.Count; i++)
                    {
                        graphics.DrawImage(Image.FromFile(menuPodpukt), Location.X + Location.Width, Location.Height + Location.Y + (Location.Height / 4 * i), Location.Width, Location.Height / 4);
                        graphics.DrawString(menuPodpunct[i], new Font("Ports", Location.Height / k * l < Location.Width / k * l ? Location.Height / k * l : Location.Width / k * l), Brushes.Black, Location.X + Location.Width + Location.Width / 15, Location.Height / 30 + Location.Height + Location.Y + (Location.Height / 4 * i));
                    }
                }
            }
        }
    }
}