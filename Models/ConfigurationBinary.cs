using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class ConfigurationBinary
    {
        public Guid BinaryId { get; set; }
        public string BinaryName { get; set; }
        public byte[] Binary { get; set; }
        public string BinaryMimeType { get; set; }
        public string BinaryAssosiation { get; set; }
        public string BinaryOriginalFileName { get; set; }
        public string BinaryConfigurationType { get; set; }
    }
}
