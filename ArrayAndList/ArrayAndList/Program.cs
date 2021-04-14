using System;
using System.Globalization;
using System.Collections.Generic;

namespace ArrayAndList {
    class Program {
        static void Main(string[] args) {
            //RentRooms();
            EmplyeeRegister();
        }

        //Array
        static void RentRooms() {
            Room[] rooms = new Room[10];

            Console.Write("How many rooms will be rented? ");
            int willBeRented = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= willBeRented; i++) {
                Console.WriteLine("Rent #" + i);

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int rentRoom = int.Parse(Console.ReadLine());
                if(rooms[rentRoom] == null) {
                    rooms[rentRoom] = new Room(name, email);
                }

                Console.WriteLine();
            }

            Console.WriteLine("Occuped rooms:");
            for(int i = 0; i <= rooms.Length; i++) {
                if(rooms[i] != null) {
                    Console.WriteLine(i + ": " + rooms[i]);
                }
            }
        }

        //List
        static void EmplyeeRegister() {
            Console.Write("How many employees will be registered: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for(int i = 1; i <= n; i++) {
                Console.WriteLine($"Employee #{i}");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int findId = int.Parse(Console.ReadLine());
            Employee e = list.Find(x => x.Id == findId);
            if (e != null) {
                Console.Write("Enter the percentage: ");
                e.IncreaseSalary(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }
            else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach(Employee obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
