using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Classes
{
    public class DocumentStorage
    {
        public virtual Document AddDocument(string documentPath)
        {
            Document doc = new Document
            {
                Path = documentPath
            };
            Console.WriteLine($"Called DocumentStorage.AddDocument({doc.Path})");
            return doc;

        }

        public virtual IEnumerable<Document> ListDocuments()
        {
            Console.WriteLine($"Called DocumentStorage.ListDocuments()");
            return new List<Document>();
        }

        public virtual Document GetDocument(string documentName)
        {
            Document doc = new Document
            {
                Name = documentName
            };
            Console.WriteLine($"Called DocumentStorage.GetDocument({doc.Name})");
            return doc;
        }

        public virtual void DeleteDocument(string documentName)
        {
            Console.WriteLine($"Called DocumentStorage.DeleteDocument({documentName})");
        }
    }
}
