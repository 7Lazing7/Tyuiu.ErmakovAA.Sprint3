using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ErmakovAA.Sprint3.Task7.V5.Lib
{
    public class DataService : ISprint3Task7V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray; // объявляем пустой массив
            int len = (stopValue - startValue) + 1; // Вычисляем длину массива 
            valueArray = new double[len]; // Создаем массив с указанной длиной
            double y; 
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = ((2 * Math.Sin(x)) / (3 * x + 1.2)) + Math.Cos(x) - 7 * x * 2;
                y = Math.Round(y, 2); // Округляем значение до 2 знаков после запятой 
                valueArray[count] = y; // Присваеваем значение в массив с индексом count
                count++;
            }
            return valueArray;
           
        
        }
    }
}
