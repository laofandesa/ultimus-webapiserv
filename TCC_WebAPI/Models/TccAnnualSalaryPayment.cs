using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAnnualSalaryPayment
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public int? ProcessStatus { get; set; }
        public string ApplyUserName { get; set; }
        public string ApplyUserLoginName { get; set; }
        public string ApplyUserIdentityId { get; set; }
        public string ApplyDept { get; set; }
        public string ApplyDeptCode { get; set; }
        public string PayrollCityCode { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string SendDate { get; set; }
    }
}
