using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var dane = new List<(string Klasa, int Punkty)>
        {
            ("1A", 10),
            ("1B", 15),
            ("1A", 20),
            ("2A", 12),
            ("1B", 5),
            ("2A", 8),
            ("1A", 7)
        };

        var sumaPunktow = dane
            .GroupBy(d => d.Klasa)
            .Select(g => new
            {
                Klasa = g.Key,
                Suma = g.Sum(x => x.Punkty)
            });

        Console.WriteLine("Suma punktów w każdej klasie:");
        foreach (var grupa in sumaPunktow)
        {
            Console.WriteLine($"Klasa {grupa.Klasa}: {grupa.Suma} punktów");
        }
    }
}
