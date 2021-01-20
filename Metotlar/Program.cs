using System;
using System.Security.Cryptography.X509Certificates;

namespace Metotlar
{
    class Program
    {

        static void Main(string[] args)
        {

            Urun urun1= new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.Id = 1;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.Id = 2;
            Urun[] urunler = new Urun[]{urun1,urun2};

            foreach (Urun urun in urunler)

            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Id);
                Console.WriteLine("*********************");


            }

            Console.WriteLine("--------------Metotlar-------------");
            sepetManager sepetManager = new sepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2(urun1);
            

            



        }

        
    } 
}
