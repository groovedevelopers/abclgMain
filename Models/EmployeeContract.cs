using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class EmployeeContract
    {
        public EmployeeContract()
        {
            EmployeeContractFiles = new HashSet<EmployeeContractFile>();
        }

        public Guid EmployeeContractId { get; set; }
        public Guid EmployeeId { get; set; }
        public string ContractNumber { get; set; }
        public string ContractName { get; set; }
        public string ContractDescription { get; set; }
        public DateTime SignedDate { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Status { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual ICollection<EmployeeContractFile> EmployeeContractFiles { get; set; }
    }
}
