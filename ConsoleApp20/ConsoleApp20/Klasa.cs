using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    public interface IWypisywanie
    {
        void Wypisz();
    }

    public class KlasaA : IWypisywanie
    {
        private string Tekst { get; set; }

        public KlasaA(string tekst)
        {
            Tekst = tekst;
        }

        public void Wypisz()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Tekst.ToUpper());
            Console.ResetColor();
        }

        public void ZmienNaWielkieLitery()
        {
            Tekst = Tekst.ToUpper();
        }
    }

}
