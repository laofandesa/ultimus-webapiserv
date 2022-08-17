using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccRiskMortgageDetail
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string RequestPerson { get; set; }
        public string RequestLogin { get; set; }
        public string RequestUserIdentity { get; set; }
        public string DutyCode { get; set; }
        public string DutyArea { get; set; }
        public string Person { get; set; }
        public string UserIdentity { get; set; }
        public decimal? Amount { get; set; }
        public decimal? PredictsafetyHours { get; set; }
        public int? Status { get; set; }
        public decimal? AlreadyAmount { get; set; }
        public decimal? RemissionAmount { get; set; }
        public decimal? BowlAmount { get; set; }
        public string Remark { get; set; }
        public int? Operate { get; set; }
        public decimal? AlbowlAmount { get; set; }
        public DateTime? AccountDate { get; set; }
    }
}
