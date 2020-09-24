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
        static List<Termék> termekek = new List<Termék>();
        static void BeolvasRaktar()
        {
            StreamReader raktar = new StreamReader("raktar.csv");
            while (!raktar.EndOfStream)
            {
                /* sor[0] -> Kód
                 * sor[1] -> Név
                 * sor[2] -> Ár
                 * sor[3] -> Darabszám
                 */

                string[] sor = raktar.ReadLine().Split(';');
                termekek.Add(new Termék(sor[0], sor[1], int.Parse(sor[2]), int.Parse(sor[3])));
            }
            raktar.Close();
        }
        static void Main(string[] args)
        {
            //Termék t = new Termék("P01","Póló XXL",1500,10);
            //Console.WriteLine($"{t.Kod} - {t.Nev} - {t.Ar} - {t.DB}");

            BeolvasRaktar();

            foreach (var t in termekek)
            {
                Console.WriteLine(t.Nev);
            }
        Console.ReadKey();
            }
        }
    }
