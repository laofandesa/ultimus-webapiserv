using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPayrollProcess
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public int? ProcessStatus { get; set; }
        public string ApplyUserRealName { get; set; }
        public string ApplyUserLoginName { get; set; }
        public string ApplyUserIidentityId { get; set; }
        public string ApplyDeptName { get; set; }
        public string ApplyDeptCode { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string XinZiFafangDiName { get; set; }
        public string XinZiFaFangDiCode { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
    }
}
