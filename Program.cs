using System;
using System.Collections.Generic;
using System.Linq;
using NIOP33;

class Program
{
    static void Main(string[] args)
    {
        List<Osoba> osobe = new List<Osoba>
        {
            new Osoba { Ime = "Marija", Godina = 35 },
            new Osoba { Ime = "Josip", Godina = 40 },
            new Osoba { Ime = "Mojsije", Godina = 80 }
        };

        Console.WriteLine("Odaberite kriterijum za pretragu:");
        Console.WriteLine("1. Ime");
        Console.WriteLine("2. Godina");
        int odabir = int.Parse(Console.ReadLine());

        Console.WriteLine("Unesi vrijednost za pretragu:");
        string unosKorisnika = Console.ReadLine();

        var rezultat = new List<Osoba>();

        if (odabir == 1)
        {
            rezultat = osobe.Where(o => o.Ime.Contains(unosKorisnika)).ToList();
        }
        else if (odabir == 2)
        {
            rezultat = osobe.Where(o => o.Godina.ToString().Contains(unosKorisnika)).ToList();
        }
        else
        {
            Console.WriteLine("Nevažeći odabir.");
            return;
        }

        if (rezultat.Count == 0)
        {
            Console.WriteLine("Nema osobe s unesenom vrijednošću.");
        }
        else
        {
            Console.WriteLine("Rezultat pretrage:");
            rezultat.ForEach(o => Console.WriteLine($"Ime: {o.Ime}, Godina: {o.Godina}"));
        }
    }
}
