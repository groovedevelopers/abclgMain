using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class CompanyProductConfigurationDefinition
    {
        public CompanyProductConfigurationDefinition()
        {
            CompanyEmployeeProductsConfigurationValues = new HashSet<CompanyEmployeeProductsConfigurationValue>();
        }

        public Guid ProductConfigurationDefinitionId { get; set; }
        public Guid ProductConfigurationId { get; set; }
        public string ProductConfigurationName { get; set; }
        public string ProductConfigurationType { get; set; }

        public virtual CompanyProductConfiguration ProductConfiguration { get; set; }
        public virtual ICollection<CompanyEmployeeProductsConfigurationValue> CompanyEmployeeProductsConfigurationValues { get; set; }
    }
}
