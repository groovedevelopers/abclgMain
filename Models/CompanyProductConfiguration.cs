using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class CompanyProductConfiguration
    {
        public CompanyProductConfiguration()
        {
            CompanyEmployeeProducts = new HashSet<CompanyEmployeeProduct>();
            CompanyProductConfigurationDefinitions = new HashSet<CompanyProductConfigurationDefinition>();
            CompanyProductDocuments = new HashSet<CompanyProductDocument>();
        }

        public Guid ProductConfigurationId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid ProductId { get; set; }
        public Guid? EmployeeGroupId { get; set; }
        public decimal? GrossPrice { get; set; }
        public decimal? NetPrice { get; set; }
        public decimal? Vat { get; set; }
        public string Currency { get; set; }
        public string CompanyProductName { get; set; }
        public string CompanyProductDescription { get; set; }
        public int? CompanyNoOfPersonsAllowed { get; set; }
        public int? DefaultDurationDays { get; set; }
        public bool? IsAllignToFullMonth { get; set; }
        public int? ClosureDayInMonth { get; set; }
        public int? TerminationPeriodDays { get; set; }
        public bool? IsProductDateToBeSetByAdmin { get; set; }
        public bool IsCustomProduct { get; set; }
        public bool IsUpgradeBlocked { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public DateTime CreationDate { get; set; }
        public decimal CompanyNetParticipation { get; set; }
        public decimal? EmployeeParticipationMinNet { get; set; }

        public virtual Company Company { get; set; }
        public virtual EmployeeGroup EmployeeGroup { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<CompanyEmployeeProduct> CompanyEmployeeProducts { get; set; }
        public virtual ICollection<CompanyProductConfigurationDefinition> CompanyProductConfigurationDefinitions { get; set; }
        public virtual ICollection<CompanyProductDocument> CompanyProductDocuments { get; set; }
    }
}
