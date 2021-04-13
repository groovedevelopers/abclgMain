﻿using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class Employee
    {
        public Employee()
        {
            CompanyEmployeeProducts = new HashSet<CompanyEmployeeProduct>();
            EmployeeContracts = new HashSet<EmployeeContract>();
            EmployeeFiles = new HashSet<EmployeeFile>();
            EmployeeInvoices = new HashSet<EmployeeInvoice>();
            EmployeePeople = new HashSet<EmployeePerson>();
        }

        public Guid EmployeeId { get; set; }
        public Guid CompanyId { get; set; }
        public string AspNetUserId { get; set; }
        public Guid? EmployeeGroupId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string SecondaryEmail { get; set; }
        public string ExternalId { get; set; }
        public string Departament { get; set; }
        public string Group { get; set; }
        public string SubGroup { get; set; }
        public string Pesel { get; set; }
        public DateTime? BirthDate { get; set; }
        public string CompanyName { get; set; }
        public string LegalForm { get; set; }
        public string VatId { get; set; }
        public string EmplCompanyId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string IdType { get; set; }
        public string IdNumber { get; set; }
        public string IdIssuedBy { get; set; }
        public DateTime? IdExpirationDate { get; set; }
        public string DrivingLicenceNo { get; set; }
        public string ProxyType { get; set; }
        public string ProxyName { get; set; }
        public string ProxySurname { get; set; }
        public bool IsInitialConfigurationSet { get; set; }
        public bool IsGdprAccepted { get; set; }
        public bool IsEinvoice { get; set; }
        public string Other { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime? ModificationDate { get; set; }
        public DateTime CreationDate { get; set; }
        public string Status { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Company Company { get; set; }
        public virtual EmployeeGroup EmployeeGroup { get; set; }
        public virtual ICollection<CompanyEmployeeProduct> CompanyEmployeeProducts { get; set; }
        public virtual ICollection<EmployeeContract> EmployeeContracts { get; set; }
        public virtual ICollection<EmployeeFile> EmployeeFiles { get; set; }
        public virtual ICollection<EmployeeInvoice> EmployeeInvoices { get; set; }
        public virtual ICollection<EmployeePerson> EmployeePeople { get; set; }
    }
}
