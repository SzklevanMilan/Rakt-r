using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Raktár
{
    class Program
    {
        static void Main(string[] args)
        {
            Termék t = new Termék("P01","Póló XXL",1500,10);
            Console.WriteLine($"{t.Kod} - {t.Nev} - {t.Ar} - {t.DB}");
            Console.ReadKey();
        }
    }
}
