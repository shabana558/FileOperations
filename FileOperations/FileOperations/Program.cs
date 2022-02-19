using FileOperations.BinaryDataFormat;
using FileOperations.CsvFileOperations;
using FileOperations.JsonDataFormat;
using FileOperations.Xml;
using System;
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
            Console.WriteLine("Enter 2: To Read all lines in file by using ReadAllLines method");
            Console.WriteLine("Enter 3: To Read all lines in file by using ReadAtOnce method");
            Console.WriteLine("Enter 4: To CopyFileContent ");
            Console.WriteLine("Enter 5: To Deletefile ");
            Console.WriteLine("Enter 6: To Read the file using StreamReader ");
            Console.WriteLine("Enter 7: To write data into the file using StreamWriter ");
            Console.WriteLine("Enter 8: To write data into the file using BinarySerailaize");
            Console.WriteLine("Enter 9: To write data into the file using BinaryDeserialize");
            Console.WriteLine("Enter 10: To write data into the file using Jsonserialize");
            Console.WriteLine("Enter 11: To write data into the file using JsonDeserialize");
            Console.WriteLine("Enter 12: To write data into the file using Xmlserialize");
            Console.WriteLine("Enter 13: To write data into the file using XmlDeserialize");
            Console.WriteLine("Enter 14: To write data into the file using CsvSerialize");
            Console.WriteLine("Enter 15: To write data into the file using CsvDeserialize");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    FileOperations.IsFileExists(path);
                    break;
                case 2:
                    FileOperations.ReadLineByLine(path);
                    break;
                case 3:
                    FileOperations.ReadAtOnce(path);
                    break;
                case 4:
                    FileOperations.CopyFileContent(path);
                    break;
                case 5:
                    FileOperations.DeleteFile();
                    break;
                case 6:
                    FileOperations.ReadDataUsingStreamReader(path);
                    break;
                case 7:
                    FileOperations.WriteDataIntoFileUsingStreamWriter(path);
                    break;
                case 8:
                   BinaryIODataOperations.BinarySerialize();
                    break;
                case 9:
                    BinaryIODataOperations.BinaryDeSerialize();
                    break;
                case 10:
                    //string JsonFilePath = @"G:\shabana\FileOperations\FileOperations\FileOperations\JsonDataFormat\JsonIODataOperations.json";
                    JsonIODataOperations.JsonSerialize();
                    break;

                case 11:
                  //  string JsonFilePath = @"G:\shabana\FileOperations\FileOperations\FileOperations\JsonDataFormat\JsonIODataOperations.json";
                    JsonIODataOperations.JsonDeSerialize();
                    break;
                case 12:
                    XmlFileOperations.XmlSerialize();
                    break;
                case 13:
                    XmlFileOperations.XmlDeserialize();
                    break;
                case 14:
                    CsvDataOperations.CsvSerialize();
                    break;
                case 15:
                    CsvDataOperations.CsvDeSerialize();
                    break;
                default:
                    Console.WriteLine("Enter a valid option!!!");
                    break;


            }

        }
        
    }
}
