namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;
            int c = 3;
            int d = 5;
            int i = 1;
            while (i < 4)
            {
                b++;
                b -= a;
                c = b - a;
                d = (c + a) + i;
                i ++;
            }
            Console.WriteLine(d);
        }
    }
}
