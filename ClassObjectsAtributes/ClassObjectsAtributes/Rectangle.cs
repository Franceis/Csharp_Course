using System;

namespace ClassObjectsAtributes {
    class Rectangle {
        public double Width { private get; set; }
        public double Height { private get; set; }

        public double Area() {
            return Width * Height;
        }

        public double Perimeter() {
            return (Width + Height) * 2;
        }

        public double Diagonal() {
            return Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
        }
    }
}
