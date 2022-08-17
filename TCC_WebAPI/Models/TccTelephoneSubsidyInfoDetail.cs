using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTelephoneSubsidyInfoDetail
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string RequestLoginName { get; set; }
        public string ApplyPerson { get; set; }
        public string ApplyUseridentity { get; set; }
        public decimal? Standard { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public decimal? YearStandard { get; set; }
        public decimal? HasHappenedSubsidy { get; set; }
        public decimal? RemainSubsidy { get; set; }
        public decimal? Amount { get; set; }
    }
}
