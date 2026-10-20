using Tyuiu.FedorovskikhEO.Sprint3.Task2.V4.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint3.Task2.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Федоровских Е.О. | ИСТНб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 1;
            int stopValue = 9;


            Console.WriteLine("Начальное значение = " + startValue);
            Console.WriteLine("Конечное значение = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries( startValue, stopValue));

            Console.ReadKey();
        }
    }
}
