using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewRiskMortgageInfo
    {
        public int Id { get; set; }
        public string ApplyRealName { get; set; }
        public string ApplyLoginName { get; set; }
        public string ApplyUserIdentity { get; set; }
        public string DutyCode { get; set; }
        public string DutyArea { get; set; }
        public string Person { get; set; }
        public string UserIdentity { get; set; }
        public decimal? Amount { get; set; }
        public decimal? PredictsafetyHours { get; set; }
        public decimal? AlreadyAmount { get; set; }
        public decimal? RemissionAmount { get; set; }
        public decimal? BowlAmount { get; set; }
        public decimal? AlbowlAmount { get; set; }
        public int? Operate { get; set; }
        public int Flag { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public DateTime? TradeDate { get; set; }
        public string Manage { get; set; }
        public decimal? Balance { get; set; }
        public DateTime? AccountDate { get; set; }
    }
}
