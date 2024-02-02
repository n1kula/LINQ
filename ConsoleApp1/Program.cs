using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\windows";
            ShowFilesWithoutLinq(path);
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
