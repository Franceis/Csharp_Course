using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClass {
    class CurrencyConverter {
        private static double IoF = 6.0;

        public static double Converter(double dollars, double dollarRate) {
            dollars *= (IoF + 100) / 100;
            return dollars * dollarRate;
        }
    }
}
