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
            foreach (var sor in File.ReadAllLines(@"szeptember.csv", Encoding.Default).Skip(1))
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
        }
    }
}
