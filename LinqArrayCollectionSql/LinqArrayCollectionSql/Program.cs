using System.Collections.Generic;
using System.Linq;
using System;

using System;
using System.Linq;
using System.Collections.Generic;

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
}

class Program
{
    static void Main()
    {
        int choice;
        do
        {
            Console.Clear();
            Console.WriteLine("----- LINQ DEMO MENU -----");
            Console.WriteLine("1. LINQ to Array");
            Console.WriteLine("2. LINQ to Collection");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");

            bool isValid = int.TryParse(Console.ReadLine(), out choice);

            if (!isValid)
            {
                Console.WriteLine("Invalid input. Press any key to try again...");
                Console.ReadKey();
                continue;
            }

            switch (choice)
            {
                case 1:
                    LinqToArray();
                    break;

                case 2:
                    LinqToCollection();
                    break;

                case 0:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Press any key to try again...");
                    break;
            }

            if (choice != 0)
            {
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }

        } while (choice != 0);
    }

    static void LinqToArray()
    {
        int[] numbers = { 5, 12, 3, 21, 7, 15, 8, 2 };

        Console.WriteLine("\nOriginal Array:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        var filteredNumbers = from n in numbers
                              where n > 10
                              orderby n
                              select n;

        Console.WriteLine("\n\nNumbers greater than 10 (sorted):");
        foreach (var num in filteredNumbers)
        {
            Console.Write(num + " ");
        }
    }

    static void LinqToCollection()
    {
        List<Student> students = new List<Student>
        {
            new Student { ID = 1, Name = "Alice", Marks = 85 },
            new Student { ID = 2, Name = "Bob", Marks = 65 },
            new Student { ID = 3, Name = "Charlie", Marks = 92 },
            new Student { ID = 4, Name = "David", Marks = 70 },
            new Student { ID = 5, Name = "Eva", Marks = 78 }
        };

        var highScorers = from s in students
                          where s.Marks > 75
                          orderby s.Name
                          select s;

        Console.WriteLine("\nStudents with marks > 75:");
        foreach (var s in highScorers)
        {
            Console.WriteLine($"ID: {s.ID}, Name: {s.Name}, Marks: {s.Marks}");
        }
    }
}
