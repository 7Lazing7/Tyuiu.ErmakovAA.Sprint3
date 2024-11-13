using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ErmakovAA.Sprint3.Task2.V18.Lib
{
    public class DataService : ISprint3Task2V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multiplySeries = 1;

            do
            {
                multiplySeries = multiplySeries * (Math.Cos(value) + (Math.Pow(((double)startValue / 8), 3)));
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(multiplySeries, 3);
        }
    }
}



