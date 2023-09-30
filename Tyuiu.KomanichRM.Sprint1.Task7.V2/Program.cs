using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KomanichRM.Sprint1.Task7.V2.Lib;

namespace Tyuiu.KomanichRM.Sprint1.Task7.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Команич Р. М. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Команич Роман Маркович | АСОиУб-23-3                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* (sin(x) + cos(y)) / (cos(x) - sin(y)) * tg(xy)                          *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите переменную X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите переменную Y:");
            double y = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine(ds.Calculate(x,y));
            Console.ReadKey();
        }
    }
}
