using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccExpenseClaimSubsidyLinesTemp
    {
        public int Id { get; set; }
        public string RequestLoginName { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string PersonLogin { get; set; }
        public string PersonRealName { get; set; }
        public string PersonDeptCode { get; set; }
        public string PersonDeptName { get; set; }
        public string PersonPost { get; set; }
        public int? Days { get; set; }
        public decimal? Allowance { get; set; }
        public decimal? Subsidies { get; set; }
        public decimal? SubsidyFood { get; set; }
        public decimal? SubsidySundries { get; set; }
        public decimal? SubsidyLocale { get; set; }
        public decimal? SubsidySpecial { get; set; }
        public decimal? SubsidyTravel { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string StartLocation { get; set; }
        public string UserIdentity { get; set; }
        public int? ExtendedDays { get; set; }
        public decimal? Extendedsubsidies { get; set; }
    }
}
