using System;
using System.IO;
namespace FileIO
{
    class Program
    {
        public static void FileExists()
        {
            String path = @"C:\Users\kkancha\Downloads\Sample.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }

        public static void ReadAllLines()
        {
            String path= @"C:\Users\kkancha\Downloads\Sample.txt";
            String[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

        }

        public static void ReadAllText()
        {
            String path= @"C:\Users\kkancha\Downloads\Sample.txt";

            String lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
        }
        public static void FileCopy()
        {
            String path= @"C:\Users\kkancha\Downloads\Sample.txt";
            String copyPath = @"C:\Users\kkancha\Downloads\SampleNew.txt";
            File.Copy(path, copyPath);
        }
        static void Main(string[] args)
        {
            FileExists();
            Console.WriteLine("_____________");
            ReadAllLines();
            Console.WriteLine("_____________");
            ReadAllText();
            FileCopy();
        }
    }
}
