using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class EmployeeInvoiceFile
    {
        public Guid EmployeeInvoiceFileId { get; set; }
        public Guid EmployeeInvoiceId { get; set; }
        public string OriginalFileName { get; set; }
        public string MimeType { get; set; }
        public byte[] FileBinary { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual EmployeeInvoice EmployeeInvoice { get; set; }
    }
}
