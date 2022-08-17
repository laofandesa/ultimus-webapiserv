using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccUserDefinedApplicationForAwardDeleteRecord
    {
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public int? Id { get; set; }
        public int? AwardSendType { get; set; }
        public DateTime? ApplyDate { get; set; }
        public int? IsUsed { get; set; }
        public int? InToAwardpoolQuarter { get; set; }
        public int? InToAwardPoolYear { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public string ApplyUser { get; set; }
        public string ApplyUserLoginNane { get; set; }
        public string ApplyUserIdentityId { get; set; }
        public string Dept { get; set; }
        public string DeptCode { get; set; }
        public decimal? YuJiYingNaShuiSuoDeE { get; set; }
        public decimal? YuJiYingNaShui { get; set; }
        public decimal? DiXiaoJieZhuanE { get; set; }
        public decimal? WuXiaoJieZhuanE { get; set; }
        public decimal? BalanceMoney { get; set; }
        public decimal? AlreadyPay { get; set; }
        public decimal? AllYearMoney { get; set; }
        public decimal? CurrentMoney { get; set; }
        public decimal? NoeffctConvert { get; set; }
        public decimal? YuJiShiJiSuoDeE { get; set; }
        public int? IsOneTime { get; set; }
        public string FormNumber { get; set; }
        public decimal? KeShenLin { get; set; }
        public decimal? ShiYongShuilv { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public decimal? DefaultMoney { get; set; }
    }
}
