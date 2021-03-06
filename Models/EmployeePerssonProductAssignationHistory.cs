using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class EmployeePerssonProductAssignationHistory
    {
        public Guid EppaHistoryId { get; set; }
        public Guid EmpPersonId { get; set; }
        public Guid EmployeeProductId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? OldEndDate { get; set; }
        public string ProductStatusText { get; set; }
        public bool IsInChangeState { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset ModificationDate { get; set; }
        public string Action { get; set; }
        public DateTimeOffset InsertDate { get; set; }
    }
}
