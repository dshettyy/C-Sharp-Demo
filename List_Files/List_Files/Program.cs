using System;
using System.IO;

namespace ListFilesInDirectory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the directory path: ");
            string dirPath = Console.ReadLine();

            if (Directory.Exists(dirPath))
            {
                string[] files = Directory.GetFiles(dirPath);

                Console.WriteLine($"\nFiles in directory: {dirPath}\n");

                if (files.Length == 0)
                {
                    Console.WriteLine("No files found.");
                }
                else
                {
                    foreach (string file in files)
                    {
                        Console.WriteLine(Path.GetFileName(file));
                    }
                }
            }
            else
            {
                Console.WriteLine("Directory does not exist.");
            }
        }
    }
}
