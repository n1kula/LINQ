using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\windows";
            ShowFilesWithoutLinq(path);
            ShowFilesWithLinq(path);
        }

        private static void ShowFilesWithLinq(string path)
        {
            var query = new DirectoryInfo(path).GetFiles().OrderByDescending(file => file.Length).Take(5);

            foreach (var file in query)
            {
                Console.WriteLine($"{file.Name} : {file.Length}");
            }
        }

        private static void ShowFilesWithoutLinq(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] files = dir.GetFiles();
            Array.Sort(files, new FileInfoComparer());
            foreach (FileInfo file in files)
            {
                Console.WriteLine($"{file.Name} : {file.Length}");
            }
        }

        public class FileInfoComparer : IComparer<FileInfo>
        {
            public int Compare(FileInfo x, FileInfo y)
            {
                return x.Length.CompareTo(y.Length);
            }
        }
    }
}
