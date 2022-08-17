using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProdDeptReallocationAwardDespense
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public int? ProcessStatus { get; set; }
        public string ApplyUserName { get; set; }
        public string ApplyUserLoginName { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string ApplyDept { get; set; }
        public string ApplyDeptCode { get; set; }
        public string FormSerialNumber { get; set; }
        public decimal? AwardAmount { get; set; }
        public decimal? AwardAlreadyPay { get; set; }
        public decimal? AwardRemaining { get; set; }
        public decimal? CurrQreference { get; set; }
        public decimal? OvertimePrice { get; set; }
        public decimal? AwayDaysPrice { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
        public string Remark { get; set; }
    }
}
