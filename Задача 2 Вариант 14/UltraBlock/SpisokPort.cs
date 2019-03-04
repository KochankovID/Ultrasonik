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
    public partial class SpisokPort : UserControl
    {
        private string currentPort;
        private bool openS;

        private List<String> spisok = new List<string>();
        public SpisokPort()
        {
            InitializeComponent();
        }
        public void addSpisok(string srt)
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

        protected override void OnPaint(PaintEventArgs e)
        {
            for (int i = spisok.Count - 1; i >= 0; i--)
            {
                e.Graphics.FillRectangle(Brushes.Gray, Location.X, Location.Y + Height * (spisok.Count - i - 1), Width, Height / 5);
                e.Graphics.DrawRectangle(Pens.Black, Location.X, Location.Y + Height * (spisok.Count - i - 1), Width, Height / 5);
                e.Graphics.DrawString(spisok[i], new Font("Ports", 12), Brushes.Black, Location.X, Location.Y + Height * (spisok.Count - i - 1));
            }
            if (openS)
            {
                this.Visible = true;
            }
            else
            {
                this.Visible = true;
            }
        }
    }
}
