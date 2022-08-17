using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccWagePaymentReportMonthVoucher
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string Dept { get; set; }
        public string DeptCode { get; set; }
        public string IdentityId { get; set; }
        public string UserName { get; set; }
        public decimal? WagesShould { get; set; }
        public decimal? RealWages { get; set; }
        public decimal? FixWages { get; set; }
        public decimal? PostAllowance { get; set; }
        public decimal? ReservationWage { get; set; }
        public decimal? CompanyAllowance { get; set; }
        public decimal? SalaryIncrease { get; set; }
        public decimal? ZaiGangBuTie { get; set; }
        public decimal? JiXiaoGongZi { get; set; }
        public decimal? OtherAllowance { get; set; }
        public decimal? SpecialAllowance { get; set; }
        public decimal? Reissue { get; set; }
        public decimal? Leaves { get; set; }
        public decimal? SpecialDebit { get; set; }
        public decimal? Annuity { get; set; }
        public decimal? Insurance { get; set; }
        public decimal? ProvidentFund { get; set; }
        public string NewSalaryVestText { get; set; }
        public string NewSalaryVest { get; set; }
        public string NewSalaryVestOld { get; set; }
        public string Lister { get; set; }
        public string Checker { get; set; }
        public string Auditor { get; set; }
        public string Creatior { get; set; }
        public DateTime? CreateTime { get; set; }
        public string VoucherNumber { get; set; }
        public int? Flag { get; set; }
        public int? Type { get; set; }
    }
}
