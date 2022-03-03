using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            double height;
            double radius;
            string inp;

            Console.Write("Enter height: ");
            inp = Console.ReadLine();
            height = double.Parse(inp);

            Console.Write("Enter radius: ");
            inp = Console.ReadLine();
            radius = double.Parse(inp);

            double volume = pi * Math.Pow(radius, 2) * height;
            double area = 2 * pi * radius * (radius + height);

            Console.WriteLine($"Volume = {volume}");
            Console.WriteLine($"Area = {area}");
        }
    }
}
