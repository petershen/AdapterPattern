using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Classes
{
    public class DocumentStorage
    {
        public virtual void AddDocument(string documentPath)
        {
            Console.WriteLine($"Called DocumentStorage.AddDocument({documentPath})");
        }

        public virtual void ListDocuments()
        {
            Console.WriteLine($"Called DocumentStorage.ListDocuments()");
        }

        public virtual void GetDocument(string documentName)
        {
            Console.WriteLine($"Called DocumentStorage.GetDocument({documentName})");
        }

        public virtual void DeleteDocument(string documentName)
        {
            Console.WriteLine($"Called DocumentStorage.DeleteDocument({documentName})");
        }
    }
}
