using System;
using System.Globalization;

namespace BasicClass {
    class Program {
        static void Main(string[] args) {
            //OlderPerson();
            AverageSalary();
        }

        static void OlderPerson() {
            Person p1 = new Person();
            Person p2 = new Person();

            Console.WriteLine("First person data:");
            Console.Write("Name: ");
            p1.Name = Console.ReadLine();
            Console.Write("Age: ");
            p1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Second person data:");
            Console.Write("Name: ");
            p2.Name = Console.ReadLine();
            Console.Write("Age: ");
            p2.Age = int.Parse(Console.ReadLine());

            if (p1.Age > p2.Age) { Console.WriteLine("Older person: " + p1.Name); }
            else { Console.WriteLine("Older person: " + p2.Name); }
        }

        static void AverageSalary() {
            Functionary f1 = new Functionary();
            Functionary f2 = new Functionary();

            Console.WriteLine("First functionary data:");
            Console.Write("Name: ");
            f1.Name = Console.ReadLine();
            Console.Write("Salary: ");
            f1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Second functionary data:");
            Console.Write("Name: ");
            f2.Name = Console.ReadLine();
            Console.Write("Salary: ");
            f2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double average = (f1.Salary + f2.Salary) / 2;
            Console.WriteLine("Average salary: " + average.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
