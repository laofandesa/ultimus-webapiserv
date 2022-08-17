using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSalaryManageProcess
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public int? ProcessStatus { get; set; }
        public string ApplyUserName { get; set; }
        public string ApplyUserLoginName { get; set; }
        public string ApplyUserDeptName { get; set; }
        public int? ApplyUserDeptId { get; set; }
        public int? PlanType { get; set; }
        public DateTime? ApplyDate { get; set; }
    }
}
