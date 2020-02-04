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
            DirectoryInfo[] list = new DirectoryInfo[0];
            try
            {
                list = directory.GetDirectories();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                System.Environment.Exit(1);
            }
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
