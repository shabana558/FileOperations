using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations.CsvFileOperations
{
    internal class CsvDataOperations
    {
        public static void CsvSerialize()
        {
            student s = new student() { FName = "Harika", LName = "kp", Address = "Amberpet", Zipcode = 500001 };
            string CsvFilePath = @"G:\shabana\FileOperations\FileOperations\FileOperations\CsvFileOperations\CsvDataOperations.Csv";
            List<student> students = new List<student>()
            {
                new student(){FName="shabana",LName="shaik",Address="Hyderabad",Zipcode= 500013 },
                new student(){FName="AmeerBasha",LName="shaik",Address="porumamilla",Zipcode= 516193 }
            };
            StreamWriter sw = new StreamWriter(CsvFilePath);
            // FileStream stream = new FileStream(CsvFilePath, FileMode.OpenOrCreate);
            CsvWriter cw = new CsvWriter(sw, CultureInfo.InvariantCulture);
            cw.WriteRecords<student>(students);
            sw.Flush();
            sw.Close();
        }
        public static void CsvDeSerialize()
        {

            //student s = new student() { FName = "Harika", LName = "kp", Address = "Amberpet", Zipcode = 500001 };
            string CsvFilePath = @"G:\shabana\FileOperations\FileOperations\FileOperations\CsvFileOperations\CsvDataOperations.Csv";

           // List<student> students = new List<student>();
            StreamReader sr = new StreamReader(CsvFilePath);
            // FileStream stream = new FileStream(CsvFilePath, FileMode.OpenOrCreate);
            CsvReader cw = new CsvReader(sr, CultureInfo.InvariantCulture);
            List<student> students = cw.GetRecords<student>().ToList();
            foreach(student student in students)
            {
                Console.WriteLine(student);
            }
           
        }
        class student
        {
            public string FName { get; set; }
            public string LName { get; set; }
            public string Address { get; set; }
            public int Zipcode { get; set; }

            public override string ToString()
            {
                return $"{FName} {LName} {Address}{Zipcode}";
            }
        }
   }
}
