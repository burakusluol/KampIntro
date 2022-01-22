using System;

namespace Mateamatik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(3, 4);
            dortIslem.Topla(10, 14);
               
        }
    }
}
