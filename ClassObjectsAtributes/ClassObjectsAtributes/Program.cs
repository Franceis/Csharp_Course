using System;
using System.Globalization;

namespace ClassObjectsAtributes {
    class Program {
        static void Main(string[] args) {
            //TheRectangle();
            //TheFunctionary();
            //StudentGrades();
        }

        static void TheRectangle() {
            Rectangle r = new Rectangle();

            Console.WriteLine("Enter the width and height of the rectangle:");
            Console.Write("Width of the rectangle: ");
            r.Width = double.Parse(Console.ReadLine());
            Console.Write("Height of the rectangle: ");
            r.Height = double.Parse(Console.ReadLine());

            Console.WriteLine("Area: " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimeter: " + r.Perimeter().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
        static void TheFunctionary() {
            Functionary f = new Functionary();

            Console.Write("Name: ");
            f.Name = Console.ReadLine();
            Console.Write("Gross Salary: ");
            f.GrossSalary = double.Parse(Console.ReadLine());
            Console.Write("Impost: ");
            f.Impost = double.Parse(Console.ReadLine());

            Console.WriteLine("Functionary: " + f);
            Console.WriteLine();
            Console.Write("Enter the percentage to increase salary: ");
            f.IncreaseSalary(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("New data: " + f);
        }
        static void StudentGrades() {
            Student s = new Student();
            
            Console.Write("Student Name: ");
            s.Name = Console.ReadLine();
            Console.WriteLine("Enter the student's three grades:");
            s.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            s.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            s.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Final Grade: " + s.FinalGrade().ToString("F2", CultureInfo.InvariantCulture));
            if(s.FinalGrade() > 60) {
                Console.WriteLine("Approved!");
            }
            else {
                Console.WriteLine("Disapproved!");
                Console.WriteLine(60 - (s.FinalGrade()) + " points left");
            }
        }
    }
}
