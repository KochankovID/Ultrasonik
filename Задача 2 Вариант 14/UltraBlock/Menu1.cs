using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2_Вариант_14
{
    class Menu1
    {

        private String menuBack;
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
        private bool openS;
        Rectangle Location;
        private List<String> Files;

        private List<String> menuPunct;
        private List<String> menuPodpunct;
        public Menu1(string srt1, string str2)
        {
            menuBack = "E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\BackMenucdr.wmf";
            Files = new List<string>();
            Files.Add("E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Port_Down_Spisok.wmf");
            Files.Add("E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\Port_Down_Spisok_Fokused.wmf");
            Files.Add("");

            menuPunct = new List<string>();
            menuPodpunct = new List<string>();
            menuPunct.AddRange(srt1.Split('#'));
            menuPodpunct.AddRange(str2.Split('#'));
            currentMenu = 0;
            openS = false;
        }

        public bool getopenS()
        {
            return openS;
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
            if ((e.Y < Location.Y) || (e.Y > Location.Height + Location.Y + (Location.Height/3 * menuPunct.Count)))
            {
                return false;
            }
            if ((e.X < Location.X) || (e.X > Location.X + Location.Width))
            {
                return false;
            }
            return true;
        }

        internal void ChangePorts(MouseEventArgs e)
        {
            currentPort = spisok[((Location.Y - e.Y) - 1) / Location.Width];
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
                    graphics.DrawImage(Image.FromFile(menuBack), Location.X, Location.Height + Location.Y + (Location.Height/3 * i), Location.Width, Location.Height/3);
                    graphics.DrawString(menuPunct[i], new Font("Ports", Location.Height / 13 * 2 < Location.Width / 13 * 2 ? Location.Height / 13 * 2 : Location.Width / 13 * 2), Brushes.Black, Location.X+Location.Width/20, Location.Height/ 20 + Location.Height+Location.Y + (Location.Height/3 * i));
                }
            }
        }
    }
}