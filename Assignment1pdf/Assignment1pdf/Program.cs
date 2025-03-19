using System;
using System.Collections.Generic;
using System.IO;

namespace BasicCSharpConcepts
{
    class Program
    {
        // 5. Basic Data Types
        private static List<string> tasks = new List<string>();
        private static string filePath = "tasks.txt";

        static void Main(string[] args)
        {
            // 6. Conditional Statements & 7. Conditional Statements
            LoadTasksFromFile();

            int choice;
            do
            {
                // 2. Loops (do-while)
                ShowMenu();
                choice = GetMenuChoice();

                switch (choice)
                {
                    case 1:
                        AddNewTask();
                        break;
                    case 2:
                        ViewAllTasks();
                        break;
                    case 3:
                        SaveTasksToFile();
                        break;
                    case 4:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            } while (choice != 4);
        }

        static void ShowMenu()
        {
            Console.WriteLine("\nTask Manager");
            Console.WriteLine("1. Add New Task");
            Console.WriteLine("2. View All Tasks");
            Console.WriteLine("3. Save Tasks to File");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
        }

        static int GetMenuChoice()
        {
            // 3. Type Conversion (explicit conversion)
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    return result;
                }
                Console.Write("Invalid input! Enter 1-4: ");
            }
        }

        static void AddNewTask()
        {
            Console.Write("Enter task name: ");
            string name = Console.ReadLine();

            Console.Write("Enter due date (yyyy-mm-dd): ");
            // 3. Type Conversion (string to DateTime)
            DateTime dueDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Is completed? (true/false): ");
            // 3. Type Conversion (string to bool)
            bool isCompleted = bool.Parse(Console.ReadLine());

            // 4. String Operations (string interpolation)
            tasks.Add($"Task: {name} | Due: {dueDate:yyyy-MM-dd} | Completed: {isCompleted}");
            Console.WriteLine("Task added successfully!");
        }

        static void ViewAllTasks()
        {
            // 1. Conditionals (if statement)
            if (tasks.Count == 0)
            {
                Console.WriteLine("\nNo tasks available!");
                return;
            }

            Console.WriteLine("\nAll Tasks:");
            // 2. Loops (for loop)
            for (int i = 0; i < tasks.Count; i++)
            {
                // 4. String Operations (string formatting)
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }

        static void SaveTasksToFile()
        {
            // 5. File Handling (writing to file)
            File.WriteAllLines(filePath, tasks);
            Console.WriteLine($"Tasks saved to {filePath}!");
        }

        static void LoadTasksFromFile()
        {
            // 5. File Handling (reading from file)
            // 1. Conditionals (if-else statement)
            if (File.Exists(filePath))
            {
                tasks = new List<string>(File.ReadAllLines(filePath));
                Console.WriteLine("Previous tasks loaded successfully!");
            }
            else
            {
                Console.WriteLine("No existing tasks file found.");
            }
        }
    }
}