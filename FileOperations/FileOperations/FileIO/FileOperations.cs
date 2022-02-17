using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
    internal class FileOperations
    {
        // File exists or not
        public static bool IsFileExists(string path)
        {

            if (File.Exists(path))
            {
                Console.WriteLine("File exists");
                return true;
            }
            else
            {
                Console.WriteLine("File not exists");
                return false;
            }
        }
        public static void ReadLineByLine(string path)
        {
            if (!IsFileExists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
        }
        public static void ReadAtOnce(string path)
        {
            if (IsFileExists(path))
            {
                string line = File.ReadAllText(path);
                Console.WriteLine(line);
            }

        }
        public static void CopyFileContent(string path)
        {
            string desti = @"G:\shabana\FileOperations\FileOperations\FileOperations\FileIO\CopiedFile.txt";
            if (IsFileExists(path))
            {
                File.Copy(path, desti);
            }
        }
        public static void DeleteFile()
        {
            string desti = @"G:\shabana\FileOperations\FileOperations\FileOperations\FileIO\CopiedFile.txt";
            if (IsFileExists(desti))
            {
                File.Delete(desti);
            }
        }
    }
}
           
               