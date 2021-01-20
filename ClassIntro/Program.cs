using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "Ozan Bıçakçı";
            kurs1.IzlenmeOrani = 86;
            kurs1.KursAdi = "C#";
            Console.WriteLine(kurs1.KursAdi);
            Console.WriteLine(kurs1.Egitmen);
            Console.WriteLine(kurs1.IzlenmeOrani);
            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Ozan Bıçakçı";
            kurs2.IzlenmeOrani = 100;
            kurs2.KursAdi = "Java";
            Console.WriteLine(kurs2.KursAdi);
            Console.WriteLine(kurs2.Egitmen);
            Console.WriteLine(kurs2.IzlenmeOrani);
            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "Ozan Bıçakçı";
            kurs3.IzlenmeOrani = 94;
            kurs3.KursAdi = "Python";
            Console.WriteLine(kurs3.KursAdi);
            Console.WriteLine(kurs3.Egitmen);
            Console.WriteLine(kurs3.IzlenmeOrani);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
                Console.WriteLine(kurs.Egitmen);
                Console.WriteLine(kurs.IzlenmeOrani);
            }
        }
    }


    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
