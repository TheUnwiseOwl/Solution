using System;

namespace ConsoleBasics
{
    public class StandardNumericFormats
    {

        static void Main(string[] args)
        {
            Flow();
        }

        public static void Flow()
        {
            Console.WriteLine("Choose format option for the fucking number:");
            Console.WriteLine("[1] for Currency");
            Console.WriteLine("[2] for Decimal");
            Console.WriteLine("[3] for Exponential");
            Console.WriteLine("[4] for Fixed-point");
            Console.WriteLine("[5] for General");
            Console.WriteLine("[6] for Number");
            Console.WriteLine("[7] for Percent");
            Console.WriteLine("[8] for Round-trip");
            Console.WriteLine("[9] for Hexadecimal");
            string choice = Console.ReadLine();
            Console.WriteLine("Enter the number to be formatted");


            switch (choice)
            {
                case "1":
                    FormatToCurrency();
                    Flow();
                    break;

                case "2":
                    FormatToDecimal();
                    Flow();
                    break;

                case "3":
                    FormatToExponential();
                    Flow();
                    break;

                case "4":
                    FormatToFixedPoint();
                    Flow();
                    break;

                case "5":
                    FormatToGeneral();
                    Flow();
                    break;

                case "6":
                    FormatToNumber();
                    Flow();
                    break;

                case "7":
                    FormatToPercent();
                    Flow();
                    break;

                case "8":
                    FormatToRoundTrip();
                    Flow();
                    break;

                case "9":
                    FormatToHexadecimal();
                    Flow();
                    break;

                case "4al":
                    break;

                default:
                    if ("input" != choice)
                    {
                        Console.WriteLine("Mnogo si tup are otnachalo ili napi6i '4al' i si begai");
                        Flow();
                    }
                    break;
            }

        }


        //Formatting Methods
        public static void FormatToCurrency()
        {
            string number = Console.ReadLine();
            Console.WriteLine($"Currency: {Double.Parse(number):c}");
        }

        public static void FormatToDecimal()
        {
            string number = Console.ReadLine();
            //int temp = int.Parse(number);
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