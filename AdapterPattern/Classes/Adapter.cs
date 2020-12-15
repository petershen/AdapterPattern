using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Classes
{
    public class Adapter : DocumentStorage
    {
        private AmazonS3Storage _s3Storage = new AmazonS3Storage();

        public override Document AddDocument(string documentPath)
        {
            return _s3Storage.AddFile(documentPath);
        }

        public override Document GetDocument(string documentName)
        {
            return _s3Storage.GetFile(documentName);
        }

        public override IEnumerable<Document> ListDocuments()
        {
            return _s3Storage.ListFiles();
        }

        public override void DeleteDocument(string documentName)
        {
            _s3Storage.DeleteFile(documentName);
        }
    }
}
