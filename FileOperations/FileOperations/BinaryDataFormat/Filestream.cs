using System.IO;

namespace FileOperations.BinaryDataFormat
{
    internal class Filestream
    {
        private string binaryFilePath;
        private FileMode openOrCreate;

        public Filestream(string binaryFilePath, FileMode openOrCreate)
        {
            this.binaryFilePath = binaryFilePath;
            this.openOrCreate = openOrCreate;
        }
    }
}