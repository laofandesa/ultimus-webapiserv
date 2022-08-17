using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTheForthAwardHistroy
    {
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public string UserName { get; set; }
        public string Dept { get; set; }
        public decimal? AwardMoney { get; set; }
        public decimal? IncomTaxPable { get; set; }
        public decimal? PersonalTax { get; set; }
        public int? Status { get; set; }
        public int? Year { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public decimal? ShiFaJiangJin { get; set; }
        public decimal? ShiYongShuiLv { get; set; }
        public int? Month { get; set; }
        public string DeptCode { get; set; }
        public string Editor { get; set; }
        public string NewSalaryVest { get; set; }
        public decimal? JieZhuanShengYuE { get; set; }
        public int? EffectType { get; set; }
        public int? PersonStatus { get; set; }
        public string XinZiGuiShu { get; set; }
        public decimal? LeftMoney { get; set; }
    }
}
