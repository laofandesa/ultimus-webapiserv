using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetAwardAdjustMentPlan
    {
        public int Id { get; set; }
        public string AwardType { get; set; }
        public string AwardName { get; set; }
        public string DeptCode { get; set; }
        public string Dept { get; set; }
        public string AwardComposed { get; set; }
        public decimal? AwardAdjustMoney { get; set; }
        public string AwardTypeCode { get; set; }
        public string AwardNameCode { get; set; }
        public string AwardComposedCode { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public string Editor { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Year { get; set; }
        public decimal? AwardAdjustMoneyQ1 { get; set; }
        public decimal? AwardAdjustMoneyQ2 { get; set; }
        public decimal? AwardAdjustMoneyQ3 { get; set; }
        public decimal? AwardAdjustMoneyQ4 { get; set; }
        public decimal? AwardAdjustMoneyFromProcess { get; set; }
    }
}
