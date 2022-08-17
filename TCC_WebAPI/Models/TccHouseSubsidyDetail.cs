using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccHouseSubsidyDetail
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string RequestLoginName { get; set; }
        public DateTime? BeginDate { get; set; }
        public string Location { get; set; }
        public string ApplyPerson { get; set; }
        public string ApplyUseridentity { get; set; }
        public decimal? Standard { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public decimal? Amount { get; set; }
        public decimal? SpecialAmount { get; set; }
        public decimal? AmountTotal { get; set; }
        public string Remark { get; set; }
        public int? Operate { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public string EducationLevel { get; set; }
        public string PayCategory { get; set; }
        public int? IsGrant { get; set; }
        public decimal? Ze { get; set; }
        public decimal? HasHappendAmount { get; set; }
        public decimal? RemainAmount { get; set; }
    }
}
