using System;
using System.Globalization;

namespace ClassObjectsAtributes {
    class Functionary {
        public string Name { get; set; }
        public double GrossSalary { get; set; }
        public double Impost { get; set; }

        public double LiquidSalary() {
            return GrossSalary - Impost;
        }

        public void IncreaseSalary(double percentage) {
            GrossSalary *= ((100 + percentage) / 100);
        }

        public override string ToString() {
            return Name
                + ", $ "
                + LiquidSalary().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
