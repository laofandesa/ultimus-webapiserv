using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportExpenseClaimSubsidyLine
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string PersonRealName { get; set; }
        public string PersonDeptName { get; set; }
        public string PersonPost { get; set; }
        public int? Days { get; set; }
        public int? ExtendedDays { get; set; }
        public string Extendedsubsidies { get; set; }
        public string Allowance { get; set; }
        public string Subsidies { get; set; }
        public string SubsidyFood { get; set; }
        public string SubsidySundries { get; set; }
        public string SubsidyLocale { get; set; }
        public string SubsidySpecial { get; set; }
        public string SubsidyTravel { get; set; }
        public string BeginDate { get; set; }
        public string EndDate { get; set; }
        public string StartLocation { get; set; }
        public string UserIdentity { get; set; }
    }
}
