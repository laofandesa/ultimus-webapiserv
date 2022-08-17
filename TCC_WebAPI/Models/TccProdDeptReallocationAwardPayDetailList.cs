using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProdDeptReallocationAwardPayDetailList
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? IncidentFk { get; set; }
        public string AssignFromUser { get; set; }
        public string AssignFromUserIdentity { get; set; }
        public string AssignFromUserRealName { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string FormNumber { get; set; }
        public string DeptName { get; set; }
        public string DeptCode { get; set; }
        public string PersonRealName { get; set; }
        public string PersonLoginName { get; set; }
        public string UserIdentity { get; set; }
        public decimal? WorkEffeAward { get; set; }
        public decimal? HoursCheck { get; set; }
        public decimal? RealWorkAward { get; set; }
        public decimal? AwayDays { get; set; }
        public decimal? AwayDaysAward { get; set; }
        public decimal? Amount { get; set; }
        public int? Status { get; set; }
        public DateTime? ReceiverDate { get; set; }
    }
}
