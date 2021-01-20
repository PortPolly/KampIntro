using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class sepetManager
    {
        //naming convention
        public void Ekle(Urun urun)
        {

            Console.WriteLine("Sepete eklendi : "+urun.Adi);

        }

        public void Ekle2(Urun urun)
        {

            Console.WriteLine("Ürünün adı : "+urun.Adi);

        }
    }
}
