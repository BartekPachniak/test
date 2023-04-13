using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{

    class Szkola : IWypisywanie, IComparable<Szkola>
    {
        public string Nazwa { get; set; }
        public string Adres { get; set; }
        public int IloscUczniow { get; set; }

        public int DlugoscSkładowych()
        {
            return Math.Max(Nazwa.Length, Adres.Length);
        }

        public int CompareTo(Szkola other)
        {
            return this.IloscUczniow.CompareTo(other.IloscUczniow);
        }

        public void Wypisz()
        {
            int dlugosc = DlugoscSkładowych();
            Console.WriteLine(new string('-', dlugosc + 4));
            Console.WriteLine("|" + Nazwa.PadRight(dlugosc) + "|");
            Console.WriteLine("|" + Adres.PadRight(dlugosc) + "|");
            Console.WriteLine(new string('-', dlugosc + 4));
        }
    }
}
