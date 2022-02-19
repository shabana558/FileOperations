using FileOperations.BinaryDataFormat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileOperations
{
    internal class BinaryIODataOperations
    {
        public static void BinarySerialize()
        {
            string binaryFilePath = @"G:\shabana\FileOperations\FileOperations\FileOperations\BinaryDataFormat\BinaryData.DAT";
            Contact contact = new Contact() { FName = "shabana", LName = "Shaik", Address = "Hyderabad", Zipcode = 5000013 };
            Filestream stream = new Filestream(binaryFilePath, FileMode.Create);
            BinaryFormatter binary = new BinaryFormatter();
          //  binary.Serialize(stream, contact);
        }

        public static void BinaryDeSerialize()
        {
            string binaryFilePath = @"G:\shabana\FileOperations\FileOperations\FileOperations\BinaryDataFormat\BinaryData.DAT";
            Contact contact = new Contact { FName = "shabana", LName = "Shaik", Address = "Hyderabad", Zipcode = 5000013 };
            Filestream stream = new Filestream(binaryFilePath, FileMode.Open);
            BinaryFormatter binary=new BinaryFormatter();
           // Contact Contact = (Contact)binary.Deserialize(stream);
            Console.WriteLine(contact);


        }
    }
    [Serializable]
    class Contact
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