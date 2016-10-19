using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeričkaPromocija
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 3;
            Console.WriteLine("{0}",(x/y).GetType());
            double d = 3.345;
            Console.WriteLine("{0}", (x + d).GetType());
            Console.ReadKey();
        }
    }
}
