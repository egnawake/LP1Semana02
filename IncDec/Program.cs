using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 2;
            
            Console.WriteLine("Suffix");
            Console.WriteLine($"a = {a}; b = {b}");
            Console.WriteLine($"(a++) + b = {a++ + b}");
            Console.WriteLine($"a = {a}; b = {b}");
            Console.WriteLine("");

            Console.WriteLine("Prefix");
            Console.WriteLine($"a = {a}; b = {b}");
            Console.WriteLine($"a + (--b) = {a + --b}");
            Console.WriteLine($"a = {a}; b = {b}");
        }
    }
}
