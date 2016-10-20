using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pretvorba
{
    class Osoba
    {
        public string DajSvojOib()
        {
            return "1234567890";
        }
    }

    class Student : Osoba
    {
        public int PoložiIspit(string predmet)
        {
            return 5;
        }
    }

    class Radnik : Osoba
    {
        public bool Napravi(string proizvod)
        {
            return false;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            // dodati sve moguće pozive metoda za student
            student.DajSvojOib();
            student.PoložiIspit("C#");

            Osoba osobaS = student;
            // dodati sve moguće pozive metoda za osobaS
            osobaS.DajSvojOib();


            Student sos = (Student)osobaS;
            // dodati sve moguće pozive metoda za sos
            sos.DajSvojOib();
            sos.PoložiIspit("Matematika");

            Osoba osobaR = new Radnik();
            // dodati sve moguće pozive metoda za osobaR
            osobaR.DajSvojOib();

            Student sor = (Student)osobaR; //baca exception kod pretvorbe
            // dodati sve moguće pozive metoda za sor
            sor.DajSvojOib();
            sor.PoložiIspit("SPA");

        }
    }
}
