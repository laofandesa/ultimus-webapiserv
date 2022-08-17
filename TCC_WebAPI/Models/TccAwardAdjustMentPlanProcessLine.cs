using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAwardAdjustMentPlanProcessLine
    {
        public int Id { get; set; }
        public string UserLoginName { get; set; }
        public string AwardType { get; set; }
        public string AwardTypeCode { get; set; }
        public string AwardName { get; set; }
        public string AwardNameCode { get; set; }
        public string AwardComposed { get; set; }
        public string AwardComposedCode { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string Dept { get; set; }
        public string DeptCode { get; set; }
        public decimal? AwardAdjustMoneyYear { get; set; }
        public decimal? AwardAdjustMoneyQuarter { get; set; }
        public decimal? AwardAdjustMoneyYearSendOut { get; set; }
    }
}
