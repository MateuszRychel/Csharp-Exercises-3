using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string tekst = "Ala ma kota, a kot ma Ale. Ale Ala nie ma psa.";

        var slowa = tekst
            .ToLower()
            .Split(new[] { ' ', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

        HashSet<string> unikalneSlowa = new HashSet<string>(slowa);

        var posortowane = unikalneSlowa.OrderBy(s => s);

        Console.WriteLine("Unikalne słowa w kolejności alfabetycznej:");
        foreach (var slowo in posortowane)
        {
            Console.WriteLine(slowo);
        }
    }
}
