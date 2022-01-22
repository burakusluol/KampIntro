using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_engin
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] { "Yazılım geliştirme kursu", "Programcı kursu","C#","Python" };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            

            Console.WriteLine("For bitti !!!");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            string[] arabalar = new string[] {"Mercedes","BMW","Audi","Ford","Kıa","Porsche" };

            for (int i = 0; i < arabalar.Length; i++)
            {
                Console.WriteLine(arabalar[i]);
            }
            Console.WriteLine("For bitti !!!");

            foreach (string araba in arabalar)
            {
                Console.WriteLine(araba);
            }

            Console.ReadLine();
        }
    }
}
