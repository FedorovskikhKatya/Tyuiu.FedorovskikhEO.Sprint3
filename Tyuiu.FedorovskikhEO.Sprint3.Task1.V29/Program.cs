using Tyuiu.FedorovskikhEO.Sprint3.Task1.V29.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint3.Task1.V29
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
            int stopValue = 11;
            double value = 0.25;


            Console.WriteLine("Начальное значение = " + startValue);
            Console.WriteLine("Конечное значение = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value,startValue, stopValue));

            Console.ReadKey();
        }
    }
}
