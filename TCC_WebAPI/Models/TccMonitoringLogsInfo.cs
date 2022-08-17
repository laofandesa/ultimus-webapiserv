using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccMonitoringLogsInfo
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ErrorNumber { get; set; }
        public string ErrorMessage { get; set; }
        public int? ErrorState { get; set; }
        public int? ErrorSeverity { get; set; }
    }
}
