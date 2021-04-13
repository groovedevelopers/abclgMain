using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class EmployeeProductsView
    {
        public Guid EmployeeProductId { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid CompanyId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsInChangeState { get; set; }
        public string ProductStatusText { get; set; }
        public decimal? NetPrice { get; set; }
        public decimal? GrossPrice { get; set; }
        public string Currency { get; set; }
        public bool IsCustomProduct { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset? CreationDate { get; set; }
        public DateTimeOffset? ModificationDate { get; set; }
    }
}
