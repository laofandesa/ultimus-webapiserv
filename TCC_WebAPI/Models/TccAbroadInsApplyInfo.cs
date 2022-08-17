using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAbroadInsApplyInfo
    {
        public int Id { get; set; }
        public string FormNumber { get; set; }
        public int? ApplyYear { get; set; }
        public int? ApplyMonth { get; set; }
        public string AboradFormNumber { get; set; }
        public string CompName { get; set; }
        public string CompId { get; set; }
        public string DeptName { get; set; }
        public string Name { get; set; }
        public string UserKey { get; set; }
        public string BornDate { get; set; }
        public string ToCountry { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string VisaType { get; set; }
        public string InsStatus { get; set; }
        public string InsCategory { get; set; }
        public DateTime? InsStartDate { get; set; }
        public DateTime? InsEndDate { get; set; }
        public int? InsDays { get; set; }
        public decimal? InsFare { get; set; }
        public string OtherRemark { get; set; }
    }
}
