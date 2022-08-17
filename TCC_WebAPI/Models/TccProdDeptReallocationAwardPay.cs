using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProdDeptReallocationAwardPay
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentFk { get; set; }
        public int? IncidentNo { get; set; }
        public int? ProcessStatus { get; set; }
        public string ApplyUserName { get; set; }
        public string ApplyUserLoginName { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string ApplyDept { get; set; }
        public string ApplyDeptCode { get; set; }
        public string FormSerialNumber { get; set; }
        public decimal? TotalAwardAmount { get; set; }
        public decimal? AllocatedPrizeAmount { get; set; }
        public decimal? RemainingPrizeAmount { get; set; }
        public decimal? WorkEffeAward { get; set; }
        public decimal? RealWorkAward { get; set; }
        public decimal? AwayDaysAward { get; set; }
    }
}
