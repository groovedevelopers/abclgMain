using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class CompanyProductsView
    {
        public string EmployeeGroupName { get; set; }
        public string ProductGroupName { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int? NoOfPersonsAllowed { get; set; }
        public decimal? GrossPrice { get; set; }
        public decimal? NetPrice { get; set; }
        public decimal? Vat { get; set; }
        public string Currency { get; set; }
        public int? DefaultDurationDays { get; set; }
        public bool IsAllignToFullMonth { get; set; }
        public int? ClosureDayInMonth { get; set; }
        public int? TerminationPeriodDays { get; set; }
        public bool IsCustomProduct { get; set; }
        public bool IsUpgradeBlocked { get; set; }
        public DateTime? ModificationDate { get; set; }
        public Guid CompanyId { get; set; }
    }
}
