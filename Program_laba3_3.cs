using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_3
{
    class Currency
    {
        public float value;
    }
    class CurrencyUSD : Currency
    {
        public static float EtU;
        public static float RtU;

        public static implicit operator CurrencyUSD(CurrencyRUB x)
        {
            return new CurrencyUSD { value = RtU * x.value };
        }
        public static implicit operator CurrencyUSD(CurrencyEUR x)
        {
            return new CurrencyUSD { value = EtU * x.value };
        }
    }
    class CurrencyEUR : Currency
    {
        public static float RtE;
        public static float UtE;

        public static implicit operator CurrencyEUR(CurrencyRUB x)
        {
            return new CurrencyEUR { value = RtE * x.value };
        }
        public static implicit operator CurrencyEUR(CurrencyUSD x)
        {
            return new CurrencyEUR { value = UtE * x.value };
        }
    }
    class CurrencyRUB : Currency
    {
        public static float EtR;
        public static float UtR;

        public static implicit operator CurrencyRUB(CurrencyEUR x)
        {
            return new CurrencyRUB { value = EtR * x.value };
        }
        public static implicit operator CurrencyRUB(CurrencyUSD x)
        {
            return new CurrencyRUB { value = UtR * x.value };
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 USD = ? RUB");
            var UtR = float.Parse(Console.ReadLine());
            CurrencyRUB.UtR = UtR;
            CurrencyUSD.RtU = 1 / UtR;

            Console.WriteLine("1 EUR = ? RUB");
            var EtR = float.Parse(Console.ReadLine());
            CurrencyRUB.EtR = EtR;
            CurrencyEUR.RtE = 1 / EtR;

            CurrencyEUR.UtE = UtR / EtR;
            CurrencyUSD.EtU = EtR / UtR;

            Console.WriteLine("Enter Amount and USD/EUR/RUB");
            var input = Console.ReadLine().Split(' ');
            switch (input[1])
            {
                case "USD":
                    var usd = new CurrencyUSD();
                    usd.value = float.Parse(input[0]);
                    Console.WriteLine($"In RUB: {((CurrencyRUB)usd).value}");
                    Console.WriteLine($"in EUR: {((CurrencyEUR)usd).value}");
                    break;
                case "EUR":
                    var eur = new CurrencyEUR();
                    eur.value = float.Parse(input[0]);
                    Console.WriteLine($"In RUB: {((CurrencyRUB)eur).value}");
                    Console.WriteLine($"In USD: {((CurrencyUSD)eur).value}");
                    break;
                case "RUB":
                    var rub = new CurrencyRUB();
                    rub.value = float.Parse(input[0]);
                    Console.WriteLine($"In EUR: {((CurrencyEUR)rub).value}");
                    Console.WriteLine($"In USD: {((CurrencyUSD)rub).value}");
                    break;
                default:
                    break;
            }
            Console.Read();
        }
    }
}
