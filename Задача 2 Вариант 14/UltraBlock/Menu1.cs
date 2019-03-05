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
        private int currentPodpunct;

        private List<String> menuPunct;
        private List<String> menuPodpunct;
        public Menu1(string srt1, string str2)
        {
            menuBack = "E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\BackMenucdr.wmf";
            menuPodpukt = "E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Podpunkt.wmf";
            Files = new List<string>();
            Files.Add("E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Port_Down_Spisok.wmf");
            Files.Add("E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Port_Down_Spisok_Fokused.wmf");
            Files.Add("");
            Files.Add("");

            menuPunct = new List<string>();
            menuPodpunct = new List<string>();
            menuPunct.AddRange(srt1.Split('#'));
            menuPodpunct.AddRange(str2.Split('#'));
            currentMenu = 0;
            currentPodpunct = 0;
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
            if ((e.Y < Location.Y) || (e.Y > Location.Height + Location.Y + (Location.Height / 3 * menuPunct.Count)))
            {
                if (getopenp())
                {

            }
            if ((e.X < Location.X) || (e.X > Location.X + Location.Width))
            {
                return false;
            }
        }

        internal void ChangePorts(MouseEventArgs e)
        {
            currentMenu = ((e.Y- Location.Height + Location.Y) - 1) /Location.Height/3;
        }

        internal void Draw(Graphics graphics, int x, int y, int width, int height)
        {
            Location.X = x;
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
                    graphics.ResetClip();
                    graphics.DrawImage(Image.FromFile(menuBack), Location.X, Location.Height + Location.Y + (Location.Height / 3 * i), Location.Width, Location.Height / 3);
                    graphics.DrawString(menuPunct[i], new Font("Ports", Location.Height / 13 * 2 < Location.Width / 13 * 2 ? Location.Height / 13 * 2 : Location.Width / 13 * 2), Brushes.Black, Location.X + Location.Width / 20, Location.Height / 20 + Location.Height + Location.Y + (Location.Height / 3 * i));
                }
                if (getopenp())
                {
                    for (int i = 0; i < menuPodpunct.Count; i++)
                    {
                        graphics.ResetClip();
                        graphics.DrawImage(Image.FromFile(menuPodpukt), Location.X+Location.Width, Location.Height + (Location.Y*(currentMenu+1)) + (Location.Height / 3 * i), Location.Width, Location.Height / 3);
                        graphics.DrawString(menuPunct[i], new Font("Ports", Location.Height / 13 * 2 < Location.Width / 13 * 2 ? Location.Height / 13 * 2 : Location.Width / 13 * 2), Brushes.Black, Location.X + Location.Width + Location.Width / 20, Location.Height / 20 + Location.Height + (Location.Y * (currentMenu + 1)) + (Location.Height / 3 * i));
                    }
                }
            }
        }
    }
}