using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class ProductCartView
    {
        public Guid CompanyId { get; set; }
        public Guid ProductGroupId { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid Expr1 { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public Guid ProductConfigurationId { get; set; }
        public Guid Expr2 { get; set; }
        public decimal? GrossPrice { get; set; }
        public decimal? NetPrice { get; set; }
        public decimal? Vat { get; set; }
        public decimal CompanyNetParticipation { get; set; }
        public string Currency { get; set; }
        public int? DefaultDurationDays { get; set; }
        public int? NoOfPersonsAllowed { get; set; }
        public bool IsCustomProduct { get; set; }
        public byte[] ProductImageBlob { get; set; }
        public Guid? ProductImageId { get; set; }
        public string PartnerName { get; set; }
        public string PartnerDescription { get; set; }
        public string PartnerLogoUrl { get; set; }
        public string PartnerPageUrl { get; set; }
        public string PartnerInfoPageUrl { get; set; }
        public bool IsActive { get; set; }
    }
}
