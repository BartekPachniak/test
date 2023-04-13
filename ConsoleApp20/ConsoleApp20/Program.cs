using ConsoleApp20;

internal class Program
{
    private static void Main(string[] args)
    {
        KlasaA obiektA = new KlasaA("Zespół Szkół Technicznych im. Tadeusza Kościuszki");
        obiektA.Wypisz(); 
        obiektA.ZmienNaWielkieLitery();
        List<Szkola> szkoly = new List<Szkola>
        {
          new Szkola { Nazwa = "Szkoła Podstawowa nr 1", Adres = "ul. Szyszkowa 1, Radom", IloscUczniow = 300 },
          new Szkola { Nazwa = "Liceum Ogólnokształcące nr 2", Adres = "ul. Żurawia 12, Radom", IloscUczniow = 450 },
          new Szkola { Nazwa = "Liceum Ogólnokształcące nr 3", Adres = "ul. Szkolna 7, Radom", IloscUczniow = 600 },
          new Szkola { Nazwa = "Zespół Szkół Technicznych nr 4", Adres = "ul. Limanowskiego 26, Radom", IloscUczniow = 700 },
          new Szkola { Nazwa = "Szkoła Podstawowa nr 5", Adres = "ul. Ogrodowa 2, Radom", IloscUczniow = 400 }
        };

        Console.WriteLine("Szkoly przed sortowaniem:");
        foreach (var szkola in szkoly)
        {
            szkola.Wypisz();
        }

        szkoly.Sort();
        Console.WriteLine("Szkoly po sortowaniu:");
        foreach (var szkola in szkoly)
        {
            szkola.Wypisz();
        }
    }
}