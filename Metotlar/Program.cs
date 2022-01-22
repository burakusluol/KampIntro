using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Fiyat = 10;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 20;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun urun3 = new Urun();
            urun3.Id = 3;
            urun3.Adi = "Armut";
            urun3.Fiyat = 5;
            urun3.Aciklama = "Tatlı armut";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("*************");
            }

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);
            Console.Read();
        }
    }
}
