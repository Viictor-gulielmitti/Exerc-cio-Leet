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
            leet = frase.Replace("a", "4").Replace("e", "3").Replace("s", "5").Replace("s", "5").Replace("a", "4").Replace("a", "4").Replace("i", "1").Replace("e", "3").Replace("e", "3").Replace("t", "7").Replace("a", "4").Replace("t", "7").Replace("e", "3").Replace("s", "5").Replace("e", "3").Replace("I", "1").Replace("a", "4").Replace("o", "0").Replace("i", "1").Replace("a", "4");
            Console.WriteLine($"Texto leet: {leet}"); 


        }

    }
}
