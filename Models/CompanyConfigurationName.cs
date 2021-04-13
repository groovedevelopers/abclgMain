using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class CompanyConfigurationName
    {
        public CompanyConfigurationName()
        {
            CompanyConfigurationValues = new HashSet<CompanyConfigurationValue>();
        }

        public Guid CompanyConfigurationId { get; set; }
        public Guid CompanyId { get; set; }
        public string ConfigurationName { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<CompanyConfigurationValue> CompanyConfigurationValues { get; set; }
    }
}
