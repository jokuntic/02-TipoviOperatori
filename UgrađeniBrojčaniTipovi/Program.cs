using System;

namespace CSharp.UgrađeniBrojčaniTipovi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            int x = int.MaxValue;
            Console.WriteLine(x+1);
            int y = int.MinValue;
            Console.WriteLine(y - 1);
            Console.WriteLine("{0} - {1}", double.MinValue, double.MaxValue);
            Console.WriteLine(3.5 / 0);
            Console.WriteLine(-3.5 / 0);
            double d = 0;
            Console.WriteLine(d / 0);



            Console.ReadKey();
        }
    }
}
