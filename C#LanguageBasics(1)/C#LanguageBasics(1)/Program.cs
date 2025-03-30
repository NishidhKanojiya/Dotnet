using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Swap first and last character of a string");
            Console.WriteLine("2. Sum of digits of an integer");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter a string: ");
                    string inputString = Console.ReadLine();
                    Console.WriteLine("Modified string: " + SwapFirstLast(inputString));
                    break;

                case 2:
                    Console.Write("Enter an integer: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Sum of digits: " + SumOfDigits(num));
                    break;

                case 3:
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static string SwapFirstLast(string str)
    {
        if (str.Length < 2)
            return str;

        char[] charArray = str.ToCharArray();
        char temp = charArray[0];
        charArray[0] = charArray[charArray.Length-1];
        charArray[charArray.Length - 1] = temp;

        return new string(charArray);
    }

    static int SumOfDigits(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
}
