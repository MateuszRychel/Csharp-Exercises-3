using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var liczby = Enumerable.Range(1, 20);

        var grupy = liczby
            .GroupBy(n => n % 2 == 0 ? "Parzyste" : "Nieparzyste");

        foreach (var grupa in grupy)
        {
            Console.WriteLine($"{grupa.Key}: {grupa.Count()} liczb");
        }
    }
}
