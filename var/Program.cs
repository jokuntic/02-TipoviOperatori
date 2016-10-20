
namespace CSharp.TipoviOperatori
{
    struct S
    {
        public int a;
        public double b;
        //u strukturi nije moguće inicijalizirati članove
    }

    class Program
    {
        static void Main(string[] args)
        {
            var i0 = 5;
            var d0 = 3.5;
            // i0 = d0; //nije moguća implicitna konverzija double u int

            int i1 = 5;
            double d1 = 3.5;

            var s = new S();
        }
    }
}
