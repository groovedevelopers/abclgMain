using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class Company
    {
        public Company()
        {
            CompanyConfigurationNames = new HashSet<CompanyConfigurationName>();
            CompanyProductConfigurations = new HashSet<CompanyProductConfiguration>();
            EmployeeGroups = new HashSet<EmployeeGroup>();
            Employees = new HashSet<Employee>();
            ProductDocuments = new HashSet<ProductDocument>();
            SurveyDefinitions = new HashSet<SurveyDefinition>();
        }

        public Guid CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set; }
        public string CompanyVatId { get; set; }
        public string CompanyCityName { get; set; }
        public string CompanyPostCode { get; set; }
        public string CompanyStreet { get; set; }
        public string CompanyHouseNo { get; set; }
        public string CompanyApartamentNo { get; set; }

        public virtual ICollection<CompanyConfigurationName> CompanyConfigurationNames { get; set; }
        public virtual ICollection<CompanyProductConfiguration> CompanyProductConfigurations { get; set; }
        public virtual ICollection<EmployeeGroup> EmployeeGroups { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<ProductDocument> ProductDocuments { get; set; }
        public virtual ICollection<SurveyDefinition> SurveyDefinitions { get; set; }
    }
}
