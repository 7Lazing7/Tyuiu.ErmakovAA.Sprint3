using Tyuiu.ErmakovAA.Sprint3.Task3.V18.Lib;
namespace Tyuiu.ErmakovAA.Sprint3.Task3.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполгил: Ермаков А.А. | ПКТб-24-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #3                                                                    *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                                  *");
            Console.WriteLine("* Задание #3                                                                  *");
            Console.WriteLine("* Вариант #18                                                                  *");
            Console.WriteLine("* Выполнил: Ермаков А.А.                                                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            string str = "4n5nvf 56 bgy";
            char chr = 'n';

            Console.WriteLine("Исходная строка  = " + str);
            Console.WriteLine("Искомый символ = " + chr);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Конечная строка = " + ds.ReplaceNumOnChar(str, chr));

            Console.ReadKey();
        }
    }
}
