using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProdDeptRelcAwardDespDetl
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public int? ProcessStatus { get; set; }
        public string ApplyUserName { get; set; }
        public string ApplyUserLoginName { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string ApplyDept { get; set; }
        public string ApplyDeptCode { get; set; }
        public string FormSerialNumber { get; set; }
        public decimal? AwarRelcAmount { get; set; }
        public int? PersonNum { get; set; }
        public decimal? WorkEffeAward { get; set; }
        public decimal? WorkOverTime { get; set; }
        public decimal? RealWorkAward { get; set; }
        public int? AwayDays { get; set; }
        public decimal? AwayDaysAward { get; set; }
        public string Remark { get; set; }
    }
}
