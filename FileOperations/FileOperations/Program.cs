﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File IO Operations");
            string path = @"G:\shabana\FileOperations\FileOperations\FileOperations\FileIO\Sample.txt";
            Console.WriteLine("Enter 1: To check whether the file exists or not");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    FileOperations.IsFileExists(path);

                    break;

            }
        }
    }
}
