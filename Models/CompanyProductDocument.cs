using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class CompanyProductDocument
    {
        public Guid CompanyProductDocumentId { get; set; }
        public Guid ProductConfigurationId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentDescription { get; set; }
        public string DocumentText { get; set; }
        public byte[] DocumentBlob { get; set; }
        public string DocumentType { get; set; }
        public string DocumentMimeType { get; set; }
        public string DocumentTitleOriginal { get; set; }

        public virtual CompanyProductConfiguration ProductConfiguration { get; set; }
    }
}
