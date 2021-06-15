using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace Hianyzasok
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.feladat
            List<Hianyzas> hianyzasok = new List<Hianyzas>();
            foreach (var sor in File.ReadAllLines(@"szeptember.csv", Encoding.Latin1).Skip(1))
                hianyzasok.Add(new Hianyzas(sor));

            //2. feladat
            Console.WriteLine("2. feladat:");
            Console.WriteLine($"\tÖsszes mulasztott órák száma: {hianyzasok.Sum(h => h.MulasztottÓrák)} óra.");

            //3. feladat
            Console.WriteLine("3. feladat:");
            Console.Write($"\tKérem adjon meg egy napot: ");
            int nap = int.Parse(Console.ReadLine());
            Console.Write($"\tTanuló neve: ");
            string név = Console.ReadLine();

            //4. feladat
            Console.WriteLine("4. feladat:");
            Console.WriteLine($"\t{(hianyzasok.Any(h => h.Név == név) ? "A tanuló hiányzott szeptemberben" : "A tanuló nem hiányzott szeptemberben")}");

            //5. feladat
            Console.WriteLine($"5. feladat: Hiányzók 2017.09.{nap:D2}-n:");
            var hiányzók = hianyzasok.Where(h => nap >= h.ElsőNap && nap <= h.UtolsóNap).ToList();
            if (hiányzók.Count == 0)
                Console.WriteLine($"\tNem volt hiányzó");
            else
                hiányzók.ForEach(h => Console.WriteLine($"\t{h.Név} ({h.Osztály})"));

        }
    }
}
