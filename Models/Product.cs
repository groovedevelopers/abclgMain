using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class Product
    {
        public Product()
        {
            CompanyProductConfigurations = new HashSet<CompanyProductConfiguration>();
            ProductDocuments = new HashSet<ProductDocument>();
            ProductImages = new HashSet<ProductImage>();
        }

        public Guid ProductId { get; set; }
        public Guid ProductGroupId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int? NoOfPersonsAllowed { get; set; }
        public Guid? PartnerId { get; set; }

        public virtual ProductPartner Partner { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
        public virtual ICollection<CompanyProductConfiguration> CompanyProductConfigurations { get; set; }
        public virtual ICollection<ProductDocument> ProductDocuments { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
    }
}
