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
            
        }
    }
}
