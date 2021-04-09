using System;
using System.Collections.Generic;
using System.Text;

namespace ClassObjectsAtributes {
    class Student {
        public string Name { get; set; }
        public double Nota1, Nota2, Nota3;

        public double FinalGrade() {
            return Nota1 + Nota2 + Nota3;
        }
    }
}
