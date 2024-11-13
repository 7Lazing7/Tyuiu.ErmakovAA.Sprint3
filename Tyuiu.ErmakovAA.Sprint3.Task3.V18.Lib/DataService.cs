using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ErmakovAA.Sprint3.Task3.V18.Lib
{
    public class DataService : ISprint3Task3V18
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            string res  = value;
            foreach (char c in res )
            {
                if (Char.IsDigit (c))
                {
                   res = res.Replace(c,item);
                }

            }
            return res;
        }
    }
}
