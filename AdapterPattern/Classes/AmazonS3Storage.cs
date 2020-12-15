using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Classes
{
    public class AmazonS3Storage
    {
        public void AddFile(string filePath)
        {
            Console.WriteLine($"Called AmazonS3Storage.AddDocument({filePath})");
        }

        public void ListFiles()
        {
            Console.WriteLine($"Called AmazonS3Storage.ListDocuments()");
        }

        public void GetFile(string fileName)
        {
            Console.WriteLine($"Called AmazonS3Storage.GetDocument({fileName})");
        }

        public void DeleteFile(string fileName)
        {
            Console.WriteLine($"Called AmazonS3Storage.DeleteDocument({fileName})");
        }
    }
}
