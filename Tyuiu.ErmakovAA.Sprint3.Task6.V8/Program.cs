using Tyuiu.ErmakovAA.Sprint3.Task6.V8.Lib;
namespace Tyuiu.ErmakovAA.Sprint3.Task6.V8
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

            int startValue = 18;
            int stopValue = 28;
           

            Console.WriteLine("Старт шага первой суммы ряда = " + startValue);
            Console.WriteLine("Конец шага первой суммы ряда = " + stopValue);
            
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("SUM  = " + ds.GetSumTheDivisors(startValue,stopValue));

            Console.ReadKey();
        }
    }
}
