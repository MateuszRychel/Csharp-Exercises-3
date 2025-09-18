using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> temperatury = new List<int> { 15, 20, 22, 18, 15, 30, 25 };

        int min = temperatury.Min();
        int max = temperatury.Max();

        var ekstremalneTemperatury = temperatury
            .Where(t => t == min || t == max);

        Console.WriteLine($"Minimalna temperatura: {min}");
        Console.WriteLine($"Maksymalna temperatura: {max}");
        Console.WriteLine("Temperatury równe min lub max:");
        foreach (var t in ekstremalneTemperatury)
        {
            Console.WriteLine(t);
        }
    }
}
