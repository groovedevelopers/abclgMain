using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class EmployeeInvoice
    {
        public EmployeeInvoice()
        {
            EmployeeInvoiceFiles = new HashSet<EmployeeInvoiceFile>();
        }

        public Guid EmployeeInvoiceId { get; set; }
        public Guid EmployeeId { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime DateIssued { get; set; }
        public DateTime PaymentDueDate { get; set; }
        public decimal TotalGross { get; set; }
        public decimal TotalNet { get; set; }
        public string Currency { get; set; }
        public string Description { get; set; }
        public string BankAccountNo { get; set; }
        public DateTime? PaymentDate { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual ICollection<EmployeeInvoiceFile> EmployeeInvoiceFiles { get; set; }
    }
}
