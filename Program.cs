using System;

namespace Leet
{
    class Program
    {
        static void Main(string[] args)
        {
            String frase, leet;
            Console.WriteLine("Hackers usavam leet antes de virar modinha");
            Console.WriteLine("Texto a ser traduzido");
            frase = Console.ReadLine();
            leet = frase.Replace("a", "4").Replace("A", "4").Replace("e", "3").Replace("E", "3").Replace("i", "1").Replace("I", "1").Replace("l", "1").Replace("L", "1").Replace("O", "0").Replace("o", "0").Replace("t", "7").Replace("T", "7").Replace("s", "5").Replace("S", "5");

            Console.WriteLine($"Texto leet: {leet}"); 


        }

    }
}
