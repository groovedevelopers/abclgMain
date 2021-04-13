using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class EmployeeGroup
    {
        public EmployeeGroup()
        {
            CompanyProductConfigurations = new HashSet<CompanyProductConfiguration>();
            Employees = new HashSet<Employee>();
        }

        public Guid EmployeeGroupId { get; set; }
        public Guid? CompanyId { get; set; }
        public string GroupName { get; set; }
        public string GroupDescription { get; set; }
        public bool IsDefault { get; set; }
        public DateTimeOffset ModificationDate { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<CompanyProductConfiguration> CompanyProductConfigurations { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
