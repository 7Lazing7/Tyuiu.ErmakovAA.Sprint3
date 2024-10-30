using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ErmakovAA.Sprint3.Task1.V19.Lib
{
    public class DataService : ISprint3Task1V19
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            {
                double multiplySeries = 1;
                while (startValue <= stopValue)
                {
                    multiplySeries = multiplySeries * ((Math.Cos(value)) + ((double) startValue / 4));
                    startValue++;
                }
                return Math.Round(multiplySeries,3);
            }
        }
    }
}
    
       
      
