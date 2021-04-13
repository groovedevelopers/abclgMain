using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class ProductDocument
    {
        public Guid ProductDocumentId { get; set; }
        public Guid ProductId { get; set; }
        public Guid CompanyId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentDescription { get; set; }
        public string DocumentText { get; set; }
        public byte[] DocumentBlob { get; set; }
        public string DocumentType { get; set; }
        public string DocumentMimeType { get; set; }
        public string DocumentTitleOriginal { get; set; }

        public virtual Company Company { get; set; }
        public virtual Product Product { get; set; }
    }
}
