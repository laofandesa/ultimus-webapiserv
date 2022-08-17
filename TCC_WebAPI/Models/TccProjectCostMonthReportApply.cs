using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProjectCostMonthReportApply
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyName { get; set; }
        public string ApplyPhone { get; set; }
        public string ApplyDeptNo { get; set; }
        public string ApplyDept { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string ProjectNo { get; set; }
        public string ProjectName { get; set; }
        public string FormNumber { get; set; }
        public string ReportMonth { get; set; }
        public string ReportContent { get; set; }
        public string ReportContentEdoc { get; set; }
        public int? OrderNum { get; set; }
    }
}
