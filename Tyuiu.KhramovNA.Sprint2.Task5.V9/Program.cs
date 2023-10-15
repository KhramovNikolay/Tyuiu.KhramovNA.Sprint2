using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KhramovNA.Sprint2.Task5.V9.Lib;

namespace Tyuiu.KhramovNA.Sprint2.Task5.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Храмов Н. А.  | АСОиУБ-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Храмов Н. А. | АСОиУБ-23-3                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер месяца: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число месяца: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.FindDateOfNextDay(x, y);

            if ((x == 1 || x == 3 || x == 5 || x == 7 || x == 8 || x == 10) && y >= 1 && y <= 31)
            {
                Console.WriteLine($"Дата следующего дня: {res}");
            }

            else if ((x == 4 || x == 6 || x == 9 || x == 11) && y >= 1 && y <= 30)
            {
                Console.WriteLine($"Дата следующего дня: {res}");
            }

            else if ((x == 2) && y >= 1 && y <= 28)
            {
                Console.WriteLine($"Дата следующего дня: {res}");
            }

            else if ((x == 1 || x == 3 || x == 5 || x == 7 || x == 8 || x == 10) && (y < 1 || y > 31))
            {
                Console.WriteLine("Вы ввели некоректное значение числа месяца. Пожалуйста, поменяйте значение!!!");
            }

            else if ((x == 4 || x == 6 || x == 9 || x == 11) && (y < 1 || y > 30))
            {
                Console.WriteLine("Вы ввели некоректное значение числа месяца. Пожалуйста, поменяйте значение!!!");
            }

            else if ((x == 2) && (y < 1 || y > 28))
            {
                Console.WriteLine("Вы ввели некоректное значение числа месяца. Пожалуйста, поменяйте значение!!!");
            }

            else if (x == 12 && y >= 1 && y < 31)
            {
                Console.WriteLine($"Дата следующего дня: {res}");
            }

            else if (x == 12 && (y < 1 || y > 31))
            {
                Console.WriteLine($"Дата следующего дня: {res}");
            }

            else if (x == 12 && y == 31)
            {
                Console.WriteLine("А это последняя дата года))))");
            }

            else if (x < 1 || x > 12)
            {
                Console.WriteLine("Вы ввели некоректное значение месяца. Пожалуйста, поменяйте значение!!!");
            }




            Console.ReadKey();


        }
    }
}