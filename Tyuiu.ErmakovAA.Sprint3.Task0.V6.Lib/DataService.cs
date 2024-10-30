using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ErmakovAA.Sprint3.Task0.V6.Lib
{
    public class DataService : ISprint3Task0V6
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double MultiplySeries = 0 ;
            int i;

            for (i = startValue; i <= stopValue; i++)
            {
                MultiplySeries +=  (1 / Math.Pow((Math.Cos(5) + 1), 2));
                
            }
            return Math.Round(MultiplySeries,3);
           
        }
    }
}
