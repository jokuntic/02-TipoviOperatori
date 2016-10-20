using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            double? nulabilniDuplić = null;
            Console.WriteLine(nulabilniDuplić);

            // double običniDuplic = null; nije moguće postaviti na null

            Nullable<double> generički_nulabilni=null;
            Console.WriteLine(generički_nulabilni);
            Console.ReadKey();
        }
    }
}
