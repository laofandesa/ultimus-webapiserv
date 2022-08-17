using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccRecDocReport
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string ReportPerson { get; set; }
        public string ReportLoginUser { get; set; }
        public string ReportDept { get; set; }
        public string ReportDeptNo { get; set; }
        public DateTime? ReportDate { get; set; }
        public string ReportDetail { get; set; }
        public string FileId { get; set; }
        public int? RecDocIncident { get; set; }
    }
}
