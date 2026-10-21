using Tyuiu.FedorovskikhEO.Sprint3.Task3.V11.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint3.Task3.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("************************************************************");

            string value = "sqwreq vqwqq q";
            char replaceable = 'q';
            char replacement = '7';

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Искомый символ = " + replaceable);
            Console.WriteLine("Символ замены = " + replacement);

            Console.WriteLine("************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("************************************************************");

            Console.WriteLine("Измененная строка = " + ds.ReplaceCharOnNum(value, replaceable, replacement));

            Console.ReadKey();
        }
    }
}
