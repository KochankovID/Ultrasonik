using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Задача_2_Вариант_14
{
    class SpisokPorts
    {
        private string currentPort;
        private bool openS;
        Rectangle Location;

        private List<String> spisok = new List<string>();
        public SpisokPorts(string srt)
        {
            spisok.AddRange(srt.Split('#'));
            currentPort = "0";
            openS = false;
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

        internal void Draw(Graphics graphics, int x, int y, int height, int width)
        {
            Location.X = x;
            Location.Y = y;
            graphics.DrawString(currentPort, new Font("Ports", 12), Brushes.Black, Location);
            if (!openS)
            {
                return;
            }
            else
            {
                for(int i = 0; i < spisok.Count; i++)
                {
                    graphics.DrawRectangle(Pens.Black, Location.X, Location.Y-2 - (Location.Height * i + 1), Location.Width, Location.Height);
                    graphics.DrawString(spisok[i], new Font("Ports", 12), Brushes.Black, Location.X, Location.Y - 2 - (Location.Height * i + 1));
                }
            }
        }
    }
}
