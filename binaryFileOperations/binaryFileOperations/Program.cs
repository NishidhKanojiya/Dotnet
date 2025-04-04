using System;
using System.IO;

class Program
{
    static void Main()
    {
        string fileName = "data.bin";

        // --- Writing to a binary file ---
        using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
        {
            writer.Write("Hello, this is a binary file.");
            writer.Write(123);   // An integer
            writer.Write(45.67); // A double
        }
        if (File.Exists(fileName))
            Console.WriteLine($"'{fileName}' created successfully at: {Path.GetFullPath(fileName)}");

        Console.WriteLine("Data written to binary file successfully.");

        // --- Reading from a binary file ---
        using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
        {
            string str = reader.ReadString();
            int num = reader.ReadInt32();
            double d = reader.ReadDouble();

            Console.WriteLine("\nData read from binary file:");
            Console.WriteLine($"String: {str}");
            Console.WriteLine($"Integer: {num}");
            Console.WriteLine($"Double: {d}");
        }

        Console.ReadLine(); // Keep console open
    }
}
