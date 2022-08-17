using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAwardAssign2DeptAssign
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string AwardCategory { get; set; }
        public string AssignFromDept { get; set; }
        public string AssignFromDeptName { get; set; }
        public string AssignFromUser { get; set; }
        public string AssignFromUserIdentity { get; set; }
        public string AssignFromUserRealName { get; set; }
        public string PersonLoginName { get; set; }
        public string UserIdentity { get; set; }
        public string PersonRealName { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public decimal? Amount { get; set; }
        public decimal? HoursCheck { get; set; }
        public decimal? HoursDone { get; set; }
        public decimal? HoursActual { get; set; }
        public decimal? Adjustment { get; set; }
        public decimal? AmountCurrentQ { get; set; }
        public string CanAssign { get; set; }
        public DateTime? ReceiverDate { get; set; }
        public string IsFanPin { get; set; }
        public decimal? AnnualProjectAmount { get; set; }
        public decimal? AnnualAdjustmentAmount { get; set; }
        public decimal? AnnualHoursDone { get; set; }
        public decimal? AnnualHoursActual { get; set; }
        public decimal? CanDoAdjustment { get; set; }
        public decimal? CountMoneyAvg { get; set; }
    }
}
