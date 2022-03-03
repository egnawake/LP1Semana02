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
            Console.WriteLine("");

            Console.WriteLine($"float +Infinity: {float.PositiveInfinity}");
            Console.WriteLine($"float -Infinity: {float.NegativeInfinity}");
            Console.WriteLine($"float NaN: {float.NaN}");
            Console.WriteLine($"double +Infinity: {double.PositiveInfinity}");
            Console.WriteLine($"double -Infinity: {double.NegativeInfinity}");
            Console.WriteLine($"double NaN: {double.NaN}");
            Console.WriteLine("");

            short maxShort = short.MaxValue;
            Console.WriteLine($"short overflow: {maxShort} + 1 = {(short) (maxShort + 1)}");

            Console.WriteLine("float overflow (infinity): {0} * 2 = {1}",
                float.MaxValue,
                float.MaxValue * 2);

            Console.WriteLine("double overflow (unchanged): {0} + 1 = {1}",
                double.MaxValue,
                double.MaxValue + 1);

            float f1, f2;
            f1 = f2 = 100.0f;
            Console.WriteLine("float underflow:");
            Console.WriteLine($"  {f1} == {f2} = {f1 == f2}");
            Console.WriteLine($"  {f1} == {f2} + 0.000001 = {f1 == (f2 + 0.000001f)}");
        }
    }
}
