using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class AppEntityAttributeValue
    {
        public Guid AppEntityAttributeValueId { get; set; }
        public Guid AppEntitiyAttributeDefinitionId { get; set; }
        public Guid AssociatedEntityValueForId { get; set; }
        public string AttributeValue { get; set; }
        public byte[] AttributeBinary { get; set; }
        public bool IsActive { get; set; }
        public DateTime ModificationDate { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual AppEntityAttributeDefinition AppEntitiyAttributeDefinition { get; set; }
    }
}
