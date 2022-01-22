using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Sql";
            kurs2.Egitmen = "Yunus Çelik";
            kurs2.IzlenmeOrani = 88;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Angular";
            kurs3.Egitmen = "Engin Demiroğ";
            kurs3.IzlenmeOrani = 88;

            Arabalar arabalar1 = new Arabalar();
            arabalar1.Markalar = "Mercedes";
            arabalar1.UretimYeri = "Almanya";
            arabalar1.Yili = 2020;

            Arabalar arabalar2 = new Arabalar();
            arabalar2.Markalar = "BMW";
            arabalar2.UretimYeri = "Almanya";
            arabalar2.Yili = 2021;

            //Console.WriteLine(kurs1.KursAdi+" "+kurs1.Egitmen+" "+kurs1.IzlenmeOrani);
            //Console.WriteLine(kurs2.KursAdi + " " + kurs2.Egitmen + " " + kurs2.IzlenmeOrani);
            //Console.WriteLine(kurs3.KursAdi + " " + kurs3.Egitmen + " " + kurs3.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" "+kurs.Egitmen);
            }
            Console.WriteLine("*****************");
            Arabalar[] arabalar = new Arabalar[] { arabalar1, arabalar2 };
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba.Markalar+" "+araba.UretimYeri+" "+araba.Yili);
            }

            Kullanici kullanici1 = new Kullanici();
            kullanici1.Adi = "Burak";
            kullanici1.Soyadi = "Usluol";
            kullanici1.Tc = "11222333";
            kullanici1.Sehir = "İstanbul";

            Kullanici kullanici2 = new Kullanici();
            kullanici2.Adi = "Hasan";
            kullanici2.Soyadi = "Usluol";
            kullanici2.Tc = "13522333";
            kullanici2.Sehir = "Gaziantep";

            Kullanici kullanici3 = new Kullanici();
            kullanici3.Adi = "Volkan";
            kullanici3.Soyadi = "Usluol";
            kullanici3.Tc = "11678533";
            kullanici3.Sehir = "Konya";

            Kullanici[] kullaniciler = new Kullanici[] { kullanici1, kullanici2, kullanici3 };
            foreach (var kullanici in kullaniciler)
            {
                Console.WriteLine(kullanici.Adi+" "+kullanici.Soyadi);
            }


            Console.ReadLine();

        }

        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }
        }

        class Arabalar
        {
            public string Markalar { get; set; }
            public int Yili { get; set; }
            public string UretimYeri{ get; set; }
        }
        class Kullanici
        {
            public string Adi { get; set; }
            public string Soyadi { get; set; }
            public string Tc { get; set; }
            public string Sehir { get; set; }


        }
    }
}
