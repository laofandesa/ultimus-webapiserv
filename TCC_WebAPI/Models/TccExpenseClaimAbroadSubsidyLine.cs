using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccExpenseClaimAbroadSubsidyLine
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string RequestLoginName { get; set; }
        public string PersonLogin { get; set; }
        public string PersonRealName { get; set; }
        public int? PersonPost { get; set; }
        public string PersonDeptCode { get; set; }
        public string PersonDeptName { get; set; }
        public string UserIdentity { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Days { get; set; }
        public int? AbroadDays { get; set; }
        public string AccountCurrencyValue { get; set; }
        public decimal? Amount { get; set; }
        public decimal? KamountTax { get; set; }
        public decimal? KamountBx { get; set; }
        public decimal? Money { get; set; }
        public decimal? Zsmoney { get; set; }
        public decimal? MoneyRmb { get; set; }
        public string PassportNo { get; set; }
        public string CountMonth { get; set; }
    }
}
