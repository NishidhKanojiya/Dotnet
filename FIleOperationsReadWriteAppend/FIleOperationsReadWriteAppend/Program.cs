using System;
using System.IO;

namespace FileOperationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nishidh:");
            Console.WriteLine($"Current directory: {Environment.CurrentDirectory}");
            bool isRunning = true;
            

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Text File Operations Menu");
                Console.WriteLine("1. Read File");
                Console.WriteLine("2. Write to File");
                Console.WriteLine("3. Append to File");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");

                switch (Console.ReadLine())
                {
                    case "1":
                        ReadFile();
                        break;
                    case "2":
                        WriteFile();
                        break;
                    case "3":
                        AppendFile();
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }

                if (isRunning)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        static void ReadFile()
        {
            try
            {
                Console.Write("\nEnter file path: ");
                string path = Console.ReadLine();

                if (File.Exists(path))
                {
                    string content = File.ReadAllText(path);
                    Console.WriteLine("\nFile Content:");
                    Console.WriteLine(content);
                }
                else
                {
                    Console.WriteLine("File does not exist!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
        }

        static void WriteFile()
        {
            try
            {
                Console.Write("\nEnter file path: ");
                string path = Console.ReadLine();

                Console.WriteLine("Enter text to write (press Ctrl+Z then Enter to finish):");
                string content = Console.In.ReadToEnd();

                File.WriteAllText(path, content);
                Console.WriteLine("File written successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }

        static void AppendFile()
        {
            try
            {
                Console.Write("\nEnter file path: ");
                string path = Console.ReadLine();

                Console.Write("Enter text to append: ");
                string content = Console.ReadLine();

                File.AppendAllText(path, content + Environment.NewLine);
                Console.WriteLine("Content appended successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error appending to file: {ex.Message}");
            }
        }
    }
}