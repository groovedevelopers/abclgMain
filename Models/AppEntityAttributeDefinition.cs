using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class AppEntityAttributeDefinition
    {
        public AppEntityAttributeDefinition()
        {
            AppEntityAttributeValues = new HashSet<AppEntityAttributeValue>();
        }

        public Guid AppEntitiyAttributeDefinitionId { get; set; }
        public Guid CompanyId { get; set; }
        public string DefinitionName { get; set; }
        public string DefinitionType { get; set; }
        public string AssociatedEntity { get; set; }
        public Guid? AssociatedEntityId { get; set; }
        public bool Required { get; set; }
        public string ValidationExpression { get; set; }
        public int? OrderX { get; set; }
        public int? OrderY { get; set; }
        public bool IsActive { get; set; }
        public DateTime ModificationDate { get; set; }
        public DateTime CreationDate { get; set; }
        public string DefinitionDescription { get; set; }

        public virtual ICollection<AppEntityAttributeValue> AppEntityAttributeValues { get; set; }
    }
}
