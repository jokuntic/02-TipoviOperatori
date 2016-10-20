using System;

namespace CSharp.TipoviOperatori
{
    class Osoba { }

    class Student : Osoba { }

    class Program
    {
        static void Main(string[] args)
        {
            Osoba janko = new Student();
            bool daliJeStudent = janko is Student;//true
            bool daliJeOsoba = janko is Osoba;// true

            Osoba osoba = new Osoba();
            bool isOsoba = osoba is Osoba;//true

            Console.ReadKey();
        }
    }
}
