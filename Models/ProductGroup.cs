using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class ProductGroup
    {
        public ProductGroup()
        {
            Products = new HashSet<Product>();
        }

        public Guid ProductGroupId { get; set; }
        public string ProductGroupName { get; set; }
        public string Type { get; set; }
        public string FontAwsomeClass { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
