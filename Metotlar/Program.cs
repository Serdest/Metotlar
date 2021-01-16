using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            product urun1 = new product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            product urun2 = new product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            product[] urunler = new product[] { urun1, urun2 };


            //type-safe -- tip güvenli

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("---------Metodlar----------");

            sepetmanager sepetManager = new sepetmanager();
            //encapsulation
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil armut",12);




        }
    }
}
