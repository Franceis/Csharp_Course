using System;

namespace StaticClass {
    class Sphere {
        private static double _pi = 3.14;

        public static double Circumference(double radius) => 2 * _pi * radius;

        public static double Volume(double radius) => (4 * _pi * Math.Pow(radius, 3)) / 3;
    }
}
