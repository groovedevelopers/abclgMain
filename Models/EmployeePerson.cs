using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class EmployeePerson
    {
        public EmployeePerson()
        {
            EmployeePerssonProductAssignations = new HashSet<EmployeePerssonProductAssignation>();
        }

        public Guid EmpPersonId { get; set; }
        public Guid EmployeeId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pesel { get; set; }
        public DateTime? BirthDate { get; set; }
        public string CorelationType { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ContactAddress { get; set; }
        public string ContactPostCode { get; set; }
        public string ContactCity { get; set; }
        public string ContactCountry { get; set; }
        public string PhoneNumber { get; set; }
        public string SecondPhoneNumber { get; set; }
        public string Email { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual ICollection<EmployeePerssonProductAssignation> EmployeePerssonProductAssignations { get; set; }
    }
}
