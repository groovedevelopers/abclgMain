using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class ProductImage
    {
        public Guid ProductImageId { get; set; }
        public Guid ProductId { get; set; }
        public string ProductImageName { get; set; }
        public string ProductImageMime { get; set; }
        public string ProductImageOriginalName { get; set; }
        public byte[] ProductImageBlob { get; set; }
        public string ProductImageDescription { get; set; }
        public string ProductImageType { get; set; }

        public virtual Product Product { get; set; }
    }
}
