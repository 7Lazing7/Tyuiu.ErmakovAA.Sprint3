namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 6;
            int c = 7;
            int d = 8;
            int i = 1;

            do
            {
                a++;
                b = a + c;
                c = b - a;
                d = (a - c) - i;
                i++;
            } while (i < 4);
               Console.WriteLine(d);
        }

    }
}
