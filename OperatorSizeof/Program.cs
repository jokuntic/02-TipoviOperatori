using System;
using System.Runtime.InteropServices;

namespace CSharp.TipoviOperatori
{
    struct MojaStruktura
    {
        decimal a;
        double b;
    }

    struct MojaSloženaStruktura
    {
        public void IspišiSe()
        {
            Console.WriteLine(this.ToString());
        }

        decimal a;
        double b;
    }
    [StructLayout(LayoutKind.Sequential)]
    class MojaKlasa
    {
        public void IspišiSe()
        {
            Console.WriteLine(this.ToString());
        }

        decimal a;
        double b;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // ispisati duljinu tipa decimal
            int dec = sizeof(decimal);
            Console.WriteLine(dec);
            // ispisati duljinu tipa double
            int d = sizeof(double);
            Console.WriteLine(d);
            // ispisati duljinu tipa MojaStruktura
            int duljinaMS = System.Runtime.InteropServices.Marshal.SizeOf(typeof(MojaStruktura));
            Console.WriteLine(duljinaMS);
            // ispisati duljinu tipa MojaSloženaStruktura
            int duljinaMSS = System.Runtime.InteropServices.Marshal.SizeOf(typeof(MojaSloženaStruktura));
            Console.WriteLine(duljinaMSS);
            // ispisati duljinu tipa MojaKlasa
            int duljinaMK = System.Runtime.InteropServices.Marshal.SizeOf(typeof(MojaKlasa));
            Console.WriteLine(duljinaMK);
            Console.ReadKey();
        }
    }
}
