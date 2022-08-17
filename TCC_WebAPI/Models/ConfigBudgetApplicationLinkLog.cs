using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigBudgetApplicationLinkLog
    {
        public int Id { get; set; }
        public string Gid { get; set; }
        public int ApplicationCode { get; set; }
        public string ApplicationName { get; set; }
        public string Item2 { get; set; }
        public string Item3 { get; set; }
        public int? IsControl { get; set; }
        public int? IsRunningCost { get; set; }
        public int? IsMerge { get; set; }
        public int? MergeGroup { get; set; }
        public string MergeGroupName { get; set; }
        public int Flag { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
