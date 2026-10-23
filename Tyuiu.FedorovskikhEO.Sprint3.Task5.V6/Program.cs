
using System;
using Tyuiu.FedorovskikhEO.Sprint3.Task5.V6.Lib;

namespace Tyuiu.FedorovskikhEO.Sprint3.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнила: Федоровских Е.О. | ИСТНб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                 *");
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #6                                                               *");
            Console.WriteLine("* Выполнила: Федоровских Екатерина Олеговна | ИСТНб-26-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Вычислить сумму двойного ряда.                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 10;

            Console.WriteLine("x = " + 2);
            Console.WriteLine("Начало первого ряда = " + startValue1);
            Console.WriteLine("Конец первого ряда = " + stopValue1);
            Console.WriteLine("Начало второго ряда = " + startValue2);
            Console.WriteLine("Конец второго ряда = " + stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            double res = ds.GetSumSumSeries(startValue1, startValue2, stopValue1, stopValue2);

            Console.WriteLine("Сумма двойного ряда = " + res);

            Console.ReadKey();
        }
    }
}
