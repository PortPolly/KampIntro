using System;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı","Java","Programlamaya Başlangıç İçin Temel Kurs","Python","Javascript","Html","C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }



            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
