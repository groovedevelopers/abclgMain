using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class EmployeeContractFile
    {
        public Guid EmployeeContractFileId { get; set; }
        public Guid EmployeeContractId { get; set; }
        public string Type { get; set; }
        public string MimeType { get; set; }
        public string ContractName { get; set; }
        public string OriginalFileName { get; set; }
        public string ContractFileDescription { get; set; }
        public byte[] FileBinary { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual EmployeeContract EmployeeContract { get; set; }
    }
}
