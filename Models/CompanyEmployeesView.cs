using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class CompanyEmployeesView
    {
        public Guid CompanyId { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid? EmployeeProductId { get; set; }
        public string GroupName { get; set; }
        public string GroupDescription { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ExternalId { get; set; }
        public string ProductGroupName { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string SecondaryEmail { get; set; }
        public string Departament { get; set; }
        public string Group { get; set; }
        public string SubGroup { get; set; }
        public string Pesel { get; set; }
        public decimal? NetPrice { get; set; }
        public decimal? GrossPrice { get; set; }
        public decimal? Vat { get; set; }
        public decimal? CompanyNetParticipation { get; set; }
        public string Currency { get; set; }
        public bool? IsCustomProduct { get; set; }
        public string Status { get; set; }
    }
}
