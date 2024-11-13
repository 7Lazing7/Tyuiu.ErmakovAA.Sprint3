using Tyuiu.ErmakovAA.Sprint3.Task4.V19.Lib;
namespace Tyuiu.ErmakovAA.Sprint3.Task4.V19
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

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Произведение ряда = " + ds.Calculate(startValue, stopValue));

            Console.ReadKey();
        }
    }
}

