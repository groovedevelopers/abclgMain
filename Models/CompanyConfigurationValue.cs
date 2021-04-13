using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class CompanyConfigurationValue
    {
        public Guid CompanyConfigurationValueId { get; set; }
        public Guid CompanyConfigurationId { get; set; }
        public string ConfigurationValue { get; set; }

        public virtual CompanyConfigurationName CompanyConfiguration { get; set; }
    }
}
