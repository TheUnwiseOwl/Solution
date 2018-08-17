using System;

namespace ConsoleBasics
{
     class FormattingMethods
    {
        public static void FormatToCurrency()
        {
            string number = Console.ReadLine();
            Console.WriteLine($"Currency: {Double.Parse(number):c}");
        }

        public static void FormatToDecimal()
        {
            string number = Console.ReadLine();
            Console.WriteLine($"Decimal: {int.Parse(number):d10}");
        }

        public static void FormatToExponential()
        {
            string number = Console.ReadLine();
            Console.WriteLine($"Exponential: {Double.Parse(number):e}");
        }

        public static void FormatToFixedPoint()
        {
            string number = Console.ReadLine();
            Console.WriteLine($"Fixed-point: {Double.Parse(number):f3}");
        }

        public static void FormatToGeneral()
        {
            string number = Console.ReadLine();
            Console.WriteLine($"General: {Double.Parse(number):g}");
        }

        public static void FormatToNumber()
        {
            string number = Console.ReadLine();
            Console.WriteLine($"Number: {Double.Parse(number):n}");
        }

        public static void FormatToPercent()
        {
            string number = Console.ReadLine();
            Console.WriteLine($"Percent: {Double.Parse(number):p}");
        }

        public static void FormatToRoundTrip()
        {
            string number = Console.ReadLine();
            Console.WriteLine($"Round-trip: {Double.Parse(number):r}");
        }

        public static void FormatToHexadecimal()
        {
            string number = Console.ReadLine();
            Console.WriteLine($"Hexadecimal: {Int64.Parse(number):x}");
        }
    }
}