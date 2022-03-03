using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            float pi = (float) Math.PI;
            float height;
            float radius;
            string inp;

            Console.Write("Enter height: ");
            inp = Console.ReadLine();
            height = float.Parse(inp);

            Console.Write("Enter radius: ");
            inp = Console.ReadLine();
            radius = float.Parse(inp);

            float volume = pi * radius * radius * height;
            float area = 2 * pi * radius * (radius + height);

            Console.WriteLine($"Volume = {volume}");
            Console.WriteLine($"Area = {area}");
        }
    }
}
