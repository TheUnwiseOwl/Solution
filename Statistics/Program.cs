using System;

namespace ConsoleBasics
{
    class StandardNumericFormats
    {
        static void Main(string[] args)
        {
            Flow();
            void Flow()
            {
                FormattingMethods invoke = new FormattingMethods();
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

                        FormattingMethods.FormatToCurrency();
                        Flow();
                        break;

                    case "2":
                        FormattingMethods.FormatToDecimal();
                        Flow();
                        break;

                    case "3":
                        FormattingMethods.FormatToExponential();
                        Flow();
                        break;

                    case "4":
                        FormattingMethods.FormatToFixedPoint();
                        Flow();
                        break;

                    case "5":
                        FormattingMethods.FormatToGeneral();
                        Flow();
                        break;

                    case "6":
                        FormattingMethods.FormatToNumber();
                        Flow();
                        break;

                    case "7":
                        FormattingMethods.FormatToPercent();
                        Flow();
                        break;

                    case "8":
                        FormattingMethods.FormatToRoundTrip();
                        Flow();
                        break;

                    case "9":
                        FormattingMethods.FormatToHexadecimal();
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
        }
    }
}