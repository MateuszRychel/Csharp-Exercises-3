using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, double> studenci = new Dictionary<string, double>
        {
            { "Jan", 4.5 },
            { "Artur", 3.8 },
            { "Paweł", 5.0 },
            { "Marcin", 4.2 },
            { "Marek", 3.9 }
        };
      
        var wynik = studenci
            .Where(s => s.Value > 4.0)
            .Select(s => s.Key)
            .OrderBy(name => name);

        Console.WriteLine("Studenci z oceną powyżej 4.0:");
        foreach (var imie in wynik)
        {
            Console.WriteLine(imie);
        }
    }
}
