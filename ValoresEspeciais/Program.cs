using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"byte:\t{byte.MinValue} - {byte.MaxValue}");
            Console.WriteLine($"sbyte:\t{sbyte.MinValue} - {sbyte.MaxValue}");
            Console.WriteLine($"short:\t{short.MinValue} - {short.MaxValue}");
            Console.WriteLine($"ushort:\t{ushort.MinValue} - {ushort.MaxValue}");
            Console.WriteLine($"int:\t{int.MinValue} - {int.MaxValue}");
            Console.WriteLine($"uint:\t{uint.MinValue} - {uint.MaxValue}");
            Console.WriteLine($"long:\t{long.MinValue} - {long.MaxValue}");
            Console.WriteLine($"ulong:\t{ulong.MinValue} - {ulong.MaxValue}");
            Console.WriteLine($"float:\t{float.MinValue} - {float.MaxValue}");
            Console.WriteLine($"double:\t{double.MinValue} - {double.MaxValue}");
        }
    }
}
