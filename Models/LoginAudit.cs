using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class LoginAudit
    {
        public Guid LoginId { get; set; }
        public string AspNetUserId { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public DateTimeOffset LoginDate { get; set; }
        public string LoginStatus { get; set; }
        public string RemoteIp { get; set; }
        public string RemoteHost { get; set; }
        public string UserAgent { get; set; }
        public string Geolocalization { get; set; }
        public string Data { get; set; }
    }
}
