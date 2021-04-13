using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class AppConfigurationName
    {
        public AppConfigurationName()
        {
            AppConfigurationValues = new HashSet<AppConfigurationValue>();
        }

        public Guid ConfigurationId { get; set; }
        public string ConfigurationName { get; set; }

        public virtual ICollection<AppConfigurationValue> AppConfigurationValues { get; set; }
    }
}
