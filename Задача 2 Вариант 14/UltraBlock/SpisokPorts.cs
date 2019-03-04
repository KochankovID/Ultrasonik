using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

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

        public bool getopenS(){
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
            if ((e.X > Location.X)||(e.X < Location.X - (Location.Width * spisok.Count)))
            {
                return false;
            }
            if ((e.Y < Location.Y) || (e.Y > Location.Y+Location.Height))
            {
                return false;
            }
            return true;
        }

        internal void ChangePorts(MouseEventArgs e)
        {
            currentPort = spisok[(Location.X - e.X) / Location.Width];
        }

        internal void Draw(Graphics graphics, int x, int y, int width, int height)
        {
            Location.X = x;
            Location.Y = y;
            Location.Width = width;
            Location.Height = height;
            graphics.DrawString(currentPort, new Font("Ports", 14), Brushes.Black, Location);
            if (!openS)
            {
                return;
            }
            else
            {
                for(int i = 0; i < spisok.Count; i++)
                {
                    graphics.FillRectangle(Brushes.Gray, Location.X - (Location.Width * (i + 1)), Location.Y, Location.Width, Location.Height);
                    graphics.DrawRectangle(Pens.Black, Location.X - (Location.Width * (i + 1)), Location.Y, Location.Width, Location.Height);
                    graphics.DrawString(spisok[i], new Font("Ports", 12), Brushes.Black, Location.X - (Location.Width * (i + 1)), Location.Y);
                }
            }
        }
    }
}
