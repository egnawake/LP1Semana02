using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            float height;
            float radius;
            string inp;

            Console.Write("Enter height: ");
            inp = Console.ReadLine();
            height = float.Parse(inp);

            Console.Write("Enter radius: ");
            inp = Console.ReadLine();
            radius = float.Parse(inp);

            Console.WriteLine($"Height = {height}");
            Console.WriteLine($"Radius = {radius}");
        }
    }
}
