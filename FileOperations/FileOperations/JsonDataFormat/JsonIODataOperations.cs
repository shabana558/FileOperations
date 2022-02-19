using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations.JsonDataFormat
{
    internal class JsonIODataOperations
    {
        public static void JsonSerialize()
        {
            string JsonFilePath = @"G:\shabana\FileOperations\FileOperations\FileOperations\FileIO\jsconfig1.json";
            List<student> students = new List<student>()
            {
                new student(){FName="shabana",LName="shaik",Address="Hyderabad",Zipcode= 500013 },
                new student(){FName="AmeerBasha",LName="shaik",Address="porumamilla",Zipcode= 516193 }
            };
            //FileStream stream=new FileStream(jsonFilePath,Filemode,OpenorCreate);
            string res = JsonConvert.SerializeObject(students);
            File.WriteAllText(JsonFilePath, res);
        }
        public static void JsonDeSerialize()
        {
            string JsonFilePath = @"G:\shabana\FileOperations\FileOperations\FileOperations\FileIO\jsconfig1.json";
            string jsonData = File.ReadAllText(JsonFilePath);
            List<student> list = JsonConvert.DeserializeObject < List<student>>(jsonData);
            foreach (student st in list)
            {
                Console.WriteLine(st);
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
