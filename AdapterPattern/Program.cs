using AdapterPattern.Classes;
using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentStorage docStorage = new Adapter();

            docStorage.AddDocument(@"C:\myTestDocuments\myDoc1.pdf");
            docStorage.GetDocument("myDoc1.pdf");
            docStorage.ListDocuments();
            docStorage.DeleteDocument("myDoc1.pdf");

            Console.ReadKey();
        }
    }
}
