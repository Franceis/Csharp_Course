using System;
using System.Globalization;

namespace StaticClass {
    class Program {
        static void Main(string[] args) {
            //SphereValues();
            TheConverter();
        }

        static void SphereValues() {
            Console.Write("Enter the radius values: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Circumference: " + Sphere.Circumference(radius).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + Sphere.Volume(radius).ToString("F2", CultureInfo.InvariantCulture));
        }

        static void TheConverter() {
            Console.Write("What is the dollar exchange rate? ");
            double dollarRate = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("How many dollars will you buy? ");
            double dollars = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Amount to be paid in R$: " + CurrencyConverter.Converter(dollars, dollarRate)
                .ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
