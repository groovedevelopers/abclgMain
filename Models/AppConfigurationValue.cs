using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class AppConfigurationValue
    {
        public Guid ConfiugrationValueId { get; set; }
        public Guid ConfigurationId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Language { get; set; }

        public virtual AppConfigurationName Configuration { get; set; }
    }
}
