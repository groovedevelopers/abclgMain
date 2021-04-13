using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class RegistrationAudit
    {
        public Guid RegistrationId { get; set; }
        public string AspNetUserId { get; set; }
        public string UserName { get; set; }
        public Guid? CompanyId { get; set; }
        public string Role { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }
        public string RegistrationStatus { get; set; }
        public string RemoteIp { get; set; }
        public string RemoteHost { get; set; }
        public string UserAgent { get; set; }
        public string Data { get; set; }
    }
}
