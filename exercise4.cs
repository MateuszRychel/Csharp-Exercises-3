using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string zdanie = "Ala ma kota a kot ma Ale";

        var slowa = zdanie
            .ToLower()
            .Split(new[] { ' ', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

        var najczestsze = slowa
            .GroupBy(s => s)
            .OrderByDescending(g => g.Count())
            .First();

        // Wynik
        Console.WriteLine($"Najczęściej występujące słowo: \"{najczestsze.Key}\" ({najczestsze.Count()} razy)");
    }
}
