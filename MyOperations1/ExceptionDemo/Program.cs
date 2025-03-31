// Program.cs
using MyOperations1;
using MyOperations1;
using System;

class Program
{
    static void Main(string[] args)
    {
        Operations ops = new Operations();
        int[] sampleArray = { 1, 2, 3,4,5,6,7,8,9,0,3,4,5,6,7,9,4,3,2,1,3,4,5,7,8,9 };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Exception Handling Demo");
            Console.WriteLine("1. Divide Numbers");
            Console.WriteLine("2. Access Array Element");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice (1-3): ");

            string choice = Console.ReadLine();

            try
            {
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter first number: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        int result = ops.DivideNumbers(num1, num2);
                        Console.WriteLine($"Result: {result}");
                        break;

                    case "2":
                        Console.Write("Enter index: ");
                        int index = Convert.ToInt32(Console.ReadLine());
                        int value = ops.GetArrayElement(sampleArray, index);
                        Console.WriteLine($"Value at index {index}: {value}");
                        break;

                    case "3":
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine("\nCustom Exception Occurred:");
                Console.WriteLine($"Error Code: {ex.ErrorCode}");
                Console.WriteLine($"Error Message: {ex.ErrorMessage}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nUnexpected error: " + ex.Message);
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}