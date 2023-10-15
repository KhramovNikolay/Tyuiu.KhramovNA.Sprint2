using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KhramovNA.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {


        public int FindDateOfNextDay(int m, int n)
        {
            int res = 0;
            string w = "";
            switch (m)
            {
                case 1:
                    if (n == 31)
                    {
                        res = 1;
                    }
                    else if (n >= 1 && n <= 30)
                    {
                        res = n + 1;
                    }

                    break;
                case 2:
                    if (n == 28)
                    {
                        res = 1;
                    }
                    else if (n >= 1 && n <= 27)
                    {
                        res = n + 1;
                    }

                    break;

                case 3:
                    if (n == 31)
                    {
                        res = 1;
                    }
                    else if (n >= 1 && n <= 30)
                    {
                        res = n + 1;
                    }
                    break;

                case 4:
                    if (n == 30)
                    {
                        res = 1;
                    }
                    else if (n >= 1 && n <= 29)
                    {
                        res = n + 1;
                    }
                    break;

                case 5:
                    if (n == 31)
                    {
                        res = 1;
                    }
                    else if (n >= 1 && n <= 30)
                    {
                        res = n + 1;
                    }
                    break;

                case 6:
                    if (n == 30)
                    {
                        res = 1;
                    }
                    else if (n >= 1 && n <= 29)
                    {
                        res = n + 1;
                    }
                    break;

                case 7:
                    if (n == 31)
                    {
                        res = 1;
                    }
                    else if (n >= 1 && n <= 30)
                    {
                        res = n + 1;
                    }
                    break;

                case 8:
                    if (n == 31)
                    {
                        res = 1;
                    }
                    else if (n >= 1 && n <= 30)
                    {
                        res = n + 1;
                    }
                    break;

                case 9:
                    if (n == 30)
                    {
                        res = 1;
                    }
                    else if (n >= 1 && n <= 29)
                    {
                        res = n + 1;
                    }
                    break;

                case 10:
                    if (n == 31)
                    {
                        res = 1;
                    }
                    else if (n >= 1 && n <= 30)
                    {
                        res = n + 1;
                    }
                    break;

                case 11:
                    if (n == 30)
                    {
                        res = 1;
                    }
                    else if (n >= 1 && n <= 29)
                    {
                        res = n + 1;
                    }
                    break;

                case 12:
                    if (n == 31)
                    {
                        res = 1;
                    }
                    else if (n >= 1 && n <= 30)
                    {
                        res = n + 1;
                    }
                    break;

                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
                    break;
            }

            return res;





        }
    }
}