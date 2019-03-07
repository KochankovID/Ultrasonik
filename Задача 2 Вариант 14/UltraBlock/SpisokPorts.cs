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
        // Путь до фоновой картинки списка
        private String spisokImage = "E:\\Desktop\\Визуальное программирование\\Ultrasonik\\Задача 2 Вариант 14\\Resources\\spisok.wmf";
        private string currentPort; // Поле, хранящее значение выбранного порта
        private bool openS; // Режим (открыт == true, закрыт == false)
        Rectangle Location; // Расположение списка

        private List<String> spisok = new List<string>(); // Список значений возможных для выбора из списка
        public SpisokPorts(string srt) // Конструктор класса список
        {
            // Инициализация списка значений
            spisok.AddRange(srt.Split('#'));
            currentPort = "0"; // Текущий порт по умолчанию == 0
            openS = false; // Режим по умолчанию - закрыт
        }

        public bool getopenS(){ // Возвращает текущий резим отображения списка
            return openS;
        }

        internal void open() // Меняет режим отображения списка
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

        internal bool isInside(System.Windows.Forms.MouseEventArgs e) // Проверка на нахождение координат внутри списка
        {
            if ((e.Y > Location.Y)||(e.X < Location.Y - (Location.Height * spisok.Count)))
            {
                return false;
            }
            if ((e.X < Location.X) || (e.X > Location.X+Location.Width))
            {
                return false;
            }
            return true;
        }

        internal void ChangePorts(MouseEventArgs e) // Метод изменения порта на основе координат щелчка
        {
            currentPort = spisok[((Location.Y - e.Y)-1) / Location.Height];
        }

        internal void Draw(Graphics graphics, int x, int y, int width, int height) // Метод рисования объекта
        {
            // Определение расположения объекта 
            Location.X = x;
            Location.Y = y;
            Location.Width = width;
            Location.Height = height;

            // Рисование текста выбранного порта
            graphics.DrawString(currentPort, new Font("Ports", Location.Height/3*2 < Location.Width / 3 * 2? Location.Height / 3 * 2: Location.Width / 3 * 2), Brushes.Black, Location);

            if (!openS) // Проверка режима отображения
            {
                return;
            }
            else
            {
                for(int i = 0; i < spisok.Count; i++)
                {
                    // Прорисовка открытого списка
                    graphics.DrawImage(Image.FromFile(spisokImage), Location.X, Location.Y - (Location.Height * (i + 1)), Location.Width, Location.Height);
                    graphics.DrawString(spisok[i], new Font("Ports", Location.Height / 3 * 2 < Location.Width / 3 * 2 ? Location.Height / 3 * 2 : Location.Width / 3 * 2), Brushes.Black, Location.X + Location.Width/6, Location.Y - (Location.Height * (i + 1)));
                }
            }
        }
    }
}
