using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class CompanyEmployeeProductsHistory
    {
        public Guid EmployeeProductHistoryId { get; set; }
        public Guid EmployeeProductId { get; set; }
        public Guid ProductConfigurationId { get; set; }
        public Guid EmployeeId { get; set; }
        public string EmployeeProductDecsription { get; set; }
        public bool DocumentAcceptance { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? OldEndDate { get; set; }
        public string ProductStatusText { get; set; }
        public bool IsInChangeState { get; set; }
        public decimal? CustomNetPrice { get; set; }
        public decimal? CustomGrossPrice { get; set; }
        public decimal? Rating { get; set; }
        public bool? IsCustom { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset? CreationDate { get; set; }
        public DateTimeOffset? ModificationDate { get; set; }
        public string Action { get; set; }
        public DateTimeOffset InsertDate { get; set; }
    }
}
