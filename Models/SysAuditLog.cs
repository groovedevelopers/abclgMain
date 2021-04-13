using System;
using System.Collections.Generic;

#nullable disable

namespace projectredux.Models
{
    public partial class SysAuditLog
    {
        public Guid AuditLogId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Level { get; set; }
        public string Logger { get; set; }
        public string Message { get; set; }
        public string Userid { get; set; }
        public string SessionId { get; set; }
        public string CallSite { get; set; }
        public string Exception { get; set; }
        public string Stacktrace { get; set; }
    }
}
