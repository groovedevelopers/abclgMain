using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class CompanyEmployeeProductsConfigurationValue
    {
        public Guid EmployeeProductConfigurationValuesId { get; set; }
        public Guid ProductConfigurationDefinitionId { get; set; }
        public Guid EmployeeProductId { get; set; }
        public string Value { get; set; }
        public byte[] ValueBlob { get; set; }

        public virtual CompanyEmployeeProduct EmployeeProduct { get; set; }
        public virtual CompanyProductConfigurationDefinition ProductConfigurationDefinition { get; set; }
    }
}
