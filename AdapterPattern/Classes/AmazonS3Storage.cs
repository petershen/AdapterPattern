using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Classes
{
    public class AmazonS3Storage
    {
        public FileObject AddFile(string filePath)
        {
            FileObject file = new FileObject
            {
                Path = filePath
            };
            Console.WriteLine($"Called AmazonS3Storage.AddDocument({filePath})");
            return file;
        }

        public IEnumerable<FileObject> ListFiles()
        {
            Console.WriteLine($"Called AmazonS3Storage.ListDocuments()");
            return new List<FileObject>();
        }

        public FileObject GetFile(string fileName)
        {
            FileObject file = new FileObject
            {
                Name = fileName
            };
            Console.WriteLine($"Called AmazonS3Storage.GetDocument({fileName})");
            return file;
        }

        public void DeleteFile(string fileName)
        {
            Console.WriteLine($"Called AmazonS3Storage.DeleteDocument({fileName})");
        }
    }
}
