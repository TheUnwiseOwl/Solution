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

            switch (choice)
            {
                case "1":
                    FormatToCurrency();
                    break;

                case "2":
                    FormatToDecimal();
                    break;

                case "3":
                    FormatToExponential();
                    break;

                case "4":
                    FormatToFixedPoint();
                    break;

                case "5":
                    FormatToGeneral();
                    break;

                case "6":
                    FormatToNumber();
                    break;

                case "7":
                    FormatToPercent();
                    break;

                case "8":
                    FormatToRoundTrip();
                    break;

                case "9":
                    FormatToHexadecimal();
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
            Console.WriteLine("Enter the number to be formatted");
            string number = Console.ReadLine();
            Console.WriteLine("Currency: {0:c}", Double.Parse(number));
        }

        public static void FormatToDecimal()
        {
            Console.WriteLine("Enter the number to be formatted");
            string number = Console.ReadLine();
            int temp = int.Parse(number);
            Console.WriteLine("Decimal: {0:d10}", temp);
        }

        public static void FormatToExponential()
        {
            Console.WriteLine("Enter the number to be formatted");
            string number = Console.ReadLine();
            Double.Parse(number);
            Console.WriteLine("Exponential: {0:e}", number);
        }

        public static void FormatToFixedPoint()
        {
            Console.WriteLine("Enter the number to be formatted");
            string number = Console.ReadLine();
            Double.Parse(number);
            Console.WriteLine("Fixed-point: {0:f3}", number);
        }

        public static void FormatToGeneral()
        {
            Console.WriteLine("Enter the number to be formatted");
            string number = Console.ReadLine();
            Double.Parse(number);
            Console.WriteLine("General: {0:g}", number);
        }

        public static void FormatToNumber()
        {
            Console.WriteLine("Enter the number to be formatted");
            string number = Console.ReadLine();
            Double.Parse(number);
            Console.WriteLine("Number: {0:n}", number);
        }

        public static void FormatToPercent()
        {
            Console.WriteLine("Enter the number to be formatted");
            string number = Console.ReadLine();
            Double.Parse(number);
            Console.WriteLine("Percent: {0:p}", number);
        }

        public static void FormatToRoundTrip()
        {
            Console.WriteLine("Enter the number to be formatted");
            string number = Console.ReadLine();
            Double.Parse(number);
            Console.WriteLine("Round-trip: {0:r}", number);
        }

        public static void FormatToHexadecimal()
        {
            Console.WriteLine("Enter the number to be formatted");
            string number = Console.ReadLine();
            Double.Parse(number);
            Console.WriteLine("Hexadecimal: {0:x}", number);
        }
    }
}