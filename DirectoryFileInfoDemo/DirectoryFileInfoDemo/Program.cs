using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter the directory path: ");
        string path = Console.ReadLine();

        DirectoryInfo dirInfo = new DirectoryInfo(path);

        // Check if directory exists
        if (dirInfo.Exists)
        {
            Console.WriteLine($"\nDirectory: {dirInfo.FullName}");
            Console.WriteLine($"Created on: {dirInfo.CreationTime}");
            Console.WriteLine($"Last accessed: {dirInfo.LastAccessTime}");
            Console.WriteLine($"Last modified: {dirInfo.LastWriteTime}\n");

            // List all files in the directory
            FileInfo[] files = dirInfo.GetFiles();
            Console.WriteLine("Files:");
            foreach (FileInfo file in files)
            {
                Console.WriteLine($"- {file.Name} | Size: {file.Length} bytes | Created: {file.CreationTime}");
            }

            // List all subdirectories
            DirectoryInfo[] subDirs = dirInfo.GetDirectories();
            Console.WriteLine("\nSubdirectories:");
            foreach (DirectoryInfo subDir in subDirs)
            {
                Console.WriteLine($"- {subDir.Name} | Created: {subDir.CreationTime}");
            }
        }
        else
        {
            Console.WriteLine("Directory does not exist.");
        }

        Console.ReadLine(); // Pause the console
    }
}
