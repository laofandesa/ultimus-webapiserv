using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAwardAssign2DeptLine
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string RequestLoginName { get; set; }
        public string AwardCategory { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string DeptManagerLoginName { get; set; }
        public string DeptManagerIdentity { get; set; }
        public string DeptManagerRealName { get; set; }
        public decimal? Adjustment { get; set; }
        public decimal? Amount { get; set; }
        public decimal? HoursSubcontractors { get; set; }
        public decimal? HoursCanDo { get; set; }
        public decimal? HoursCheck { get; set; }
        public decimal? HoursDone { get; set; }
        public decimal? HoursActual { get; set; }
        public decimal? AmountQuarterAvg { get; set; }
        public string BasicWorkName { get; set; }
        public string Professional { get; set; }
        public decimal? AwardAmountAdj { get; set; }
        public string AwardsContentSummary { get; set; }
        public string WorkSubcontractors { get; set; }
        public string CanAssign { get; set; }
        public DateTime? ReceiverDate { get; set; }
        public int? AssignStatus { get; set; }
        public DateTime? AssignDate { get; set; }
        public int? ProductionPersonCount { get; set; }
        public decimal? CanDoPersonCount { get; set; }
        public decimal? CanDoPersonProportion { get; set; }
        public decimal? CanDoPersonAvg { get; set; }
        public decimal? ProductionPersonAvg { get; set; }
        public decimal? CanDoPersonYearAvg { get; set; }
        public decimal? CanDoPersonProAvg { get; set; }
        public string CountRow { get; set; }
        public decimal? CountMoneyAvg { get; set; }
        public decimal? CountMoneyTotal { get; set; }
    }
}
