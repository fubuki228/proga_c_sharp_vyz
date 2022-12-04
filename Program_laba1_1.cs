using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Short\tmin: {short.MinValue}\tmax: {short.MaxValue} {Environment.NewLine}" +
                              $"Unsigned Short\tmin: {ushort.MinValue}\tmax: {ushort.MaxValue} {Environment.NewLine}" +
                              $"Integer\tmin: {int.MinValue}\tmax: {int.MaxValue} {Environment.NewLine}" +
                              $"Unsigned integer\tmin: {uint.MinValue}\tmax: {uint.MaxValue} {Environment.NewLine}" +
                              $"Long\tmin: {long.MinValue}\tmax: {long.MaxValue} {Environment.NewLine}" +
                              $"Unsigned long\tmin: {ulong.MinValue}\tmax: {ulong.MaxValue} {Environment.NewLine}" +
                              $"Signed Byte\tmin: {sbyte.MinValue}\tmax: {sbyte.MaxValue} {Environment.NewLine}" +
                              $"Byte\tmin: {byte.MinValue}\tmax: {byte.MaxValue} {Environment.NewLine}" +
                              $"Float point\tmin: {float.MinValue}\tmax: {float.MaxValue} {Environment.NewLine}");
        }
    }
}
//Выведите на консоль минимальные и максимальные значения для предопределенных типов данных CTS.
