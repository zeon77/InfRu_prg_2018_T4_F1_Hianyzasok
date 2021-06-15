using System;

namespace Hianyzasok
{
    class Hianyzas
    {
        public string Név { get; set; }
        public string Osztály { get; set; }
        public int ElsőNap { get; set; }
        public int UtolsóNap { get; set; }
        public int MulasztottÓrák { get; set; }

        public Hianyzas(string sor)
        {
            string[] tmp = sor.Split(';');
            Név = tmp[0];
            Osztály = tmp[1];
            ElsőNap = int.Parse(tmp[2]);
            UtolsóNap = int.Parse(tmp[3]);
            MulasztottÓrák = int.Parse(tmp[4]);
        }
    }
}
