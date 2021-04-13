using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class EmployeeFile
    {
        public Guid EmployeeFileId { get; set; }
        public Guid EmployeeId { get; set; }
        public string Type { get; set; }
        public string MimeType { get; set; }
        public string OriginalFileName { get; set; }
        public byte[] FileBinary { get; set; }
        public DateTime? ModificationDate { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
