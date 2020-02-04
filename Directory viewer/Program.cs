using System;
using System.IO;

namespace Directory_viewer
{
    class Program
    {
        static void checkDirectory(DirectoryInfo directory, int counter)
        {
            for (int i = 0; i < counter; i++)
                Console.Write(" - ");
            Console.WriteLine(directory);
            DirectoryInfo[] list = directory.GetDirectories();
            foreach (DirectoryInfo dir in list)
                checkDirectory(dir, counter + 1);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            DirectoryInfo startDirectory = new DirectoryInfo(Environment.CurrentDirectory);
            checkDirectory(startDirectory, 0);
            Console.ReadKey();
        }
    }
}
