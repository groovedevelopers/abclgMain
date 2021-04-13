using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class ProductPartner
    {
        public ProductPartner()
        {
            Products = new HashSet<Product>();
        }

        public Guid PartnerId { get; set; }
        public string PartnerName { get; set; }
        public string PartnerDescription { get; set; }
        public string PartnerLogoUrl { get; set; }
        public string PartnerPageUrl { get; set; }
        public string PartnerInfoPageUrl { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
