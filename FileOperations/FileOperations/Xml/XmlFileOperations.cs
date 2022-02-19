using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileOperations.Xml
{
    public class XmlFileOperations
    {
        private static Stream stream;

        public static void XmlSerialize()
        {
            string xmlFilePath = @"G:\shabana\FileOperations\FileOperations\FileOperations\Xml\XmlFileOperations.Xml";
            List<student> students = new List<student>()
            {
                new student(){FName="shabana",LName="shaik",Address="Hyderabad",Zipcode= 500013 },
                new student(){FName="AmeerBasha",LName="shaik",Address="porumamilla",Zipcode= 516193 }
            };
            FileStream stream = new FileStream(xmlFilePath, FileMode.OpenOrCreate);
            XmlSerializer xml = new XmlSerializer(typeof(student));
            foreach (student stu in students)
            {
                xml.Serialize(stream, stu);
            }
        }
            public static void XmlDeserialize()
            {
            string xmlFilePath = @"G:\shabana\FileOperations\FileOperations\FileOperations\Xml\XmlFileOperations.Xml";
            List<student> students = new List<student>()
            {
                new student(){FName="shabana",LName="shaik",Address="Hyderabad",Zipcode= 500013 },
                new student(){FName="AmeerBasha",LName="shaik",Address="porumamilla",Zipcode= 516193 }
            };
            XmlSerializer xml = new XmlSerializer(typeof(student));
            student res=(student)xml.Deserialize(stream);
            Console.WriteLine(res);
            }
        public class student
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
    
