using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ErmakovAA.Sprint3.Task4.V19.Lib
{
    public class DataService : ISprint3Task4V19
    {
            public double Calculate(int startValue, int stopValue)
            {
                double res = 1;
                for (int i = startValue; i <= stopValue; i++)
                {
                    if (i == 0) break;
                    res *= (i / (Math.Cos(i) + i)) + 0.5;
                }
                return Math.Round(res, 3);

            }
    }
}

