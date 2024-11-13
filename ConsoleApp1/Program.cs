namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int sum = 0;
            int x;
            for ( x = 2; x <= 6 ; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        if (d < 3) 
                        {
                            sum++;
                        }
                       
                       
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
