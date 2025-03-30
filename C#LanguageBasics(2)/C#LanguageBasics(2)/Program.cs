using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Check if a number is Palindrome (Recursion)");
            Console.WriteLine("2. Check if a number is Palindrome (Without Recursion)");
            Console.WriteLine("3. Calculate Square Root (Handle Negative Numbers)");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter a number: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(IsPalindromeRecursive(num1.ToString(), 0, num1.ToString().Length - 1) ? "Palindrome" : "Not a Palindrome");
                    break;

                case 2:
                    Console.Write("Enter a number: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(IsPalindromeNonRecursive(num2) ? "Palindrome" : "Not a Palindrome");
                    break;

                case 3:
                    Console.Write("Enter a number: ");
                    try
                    {
                        double num3 = Convert.ToDouble(Console.ReadLine());
                        if (num3 < 0)
                            throw new ArgumentException("Cannot calculate square root of a negative number.");
                        Console.WriteLine("Square root: " + Math.Sqrt(num3));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static bool IsPalindromeRecursive(string str, int left, int right)
    {
        if (left >= right)
            return true;
        if (str[left] != str[right])
            return false;
        return IsPalindromeRecursive(str, left + 1, right - 1);
    }

    static bool IsPalindromeNonRecursive(int num)
    {
        int original = num, reversed = 0;
        while (num > 0)
        {
            reversed = reversed * 10 + num % 10;
            num /= 10;
        }
        return original == reversed;
    }
}
