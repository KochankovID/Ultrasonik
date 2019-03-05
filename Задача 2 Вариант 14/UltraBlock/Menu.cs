using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2_Вариант_14.UltraBlock
{
    class Menu
    {
            private String menuImage = "E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\spisok.wmf";
            private string currentMenu;
            private bool openS;
            Rectangle Location;

        private List<String> menuPunct;
        private List<String> menuPodpunct;
        public Menu(string srt1, String str2)
            {
            menuPunct = new List<string>();
            menuPodpunct = new List<string>();
            menuPunct.AddRange(srt.Split('#'));
            menuPodpunct.AddRange(srt.Split('#'));
            currentPort = "0";
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
                if ((e.Y > Location.X) || (e.X < Location.Y - (Location.Width * spisok.Count)))
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
                graphics.DrawString(currentPort, new Font("Ports", Location.Height / 3 * 2 < Location.Width / 3 * 2 ? Location.Height / 3 * 2 : Location.Width / 3 * 2), Brushes.Black, Location);
                if (!openS)
                {
                    return;
                }
                else
                {
                    for (int i = 0; i < spisok.Count; i++)
                    {
                        //graphics.FillRectangle(Brushes.Gray, Location.X - (Location.Width * (i + 1)), Location.Y, Location.Width, Location.Height);
                        //graphics.DrawRectangle(Pens.Black, Location.X - (Location.Width * (i + 1)), Location.Y, Location.Width, Location.Height);
                        graphics.DrawImage(Image.FromFile(spisokImage), Location.X, Location.Y - (Location.Height * (i + 1)), Location.Width, Location.Height);
                        graphics.DrawString(spisok[i], new Font("Ports", Location.Height / 3 * 2 < Location.Width / 3 * 2 ? Location.Height / 3 * 2 : Location.Width / 3 * 2), Brushes.Black, Location.X + Location.Width / 6, Location.Y - (Location.Height * (i + 1)));
                    }
                }
            }
        }
    }