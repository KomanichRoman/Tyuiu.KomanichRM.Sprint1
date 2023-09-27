using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KomanichRM.Sprint1.Task5.V5.Lib;

namespace Tyuiu.KomanichRM.Sprint1.Task5.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            //Task5

            Console.Title = "Спринт #1 | Выполнил: Команич Р. М. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Команич Роман Маркович | АСОиУб-23-3                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая присваивает целой переменной первую цифру   *");
            Console.WriteLine("* из дробной части положительного вещественного числа X.                  *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите переменную X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Первая цифра дробной части числа X = " + ds.Calculate(x));
            Console.ReadKey();
        }
    }
}
