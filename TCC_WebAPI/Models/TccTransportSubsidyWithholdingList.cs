using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTransportSubsidyWithholdingList
    {
        public int Id { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public string ApplyName { get; set; }
        public string ApplyUserKey { get; set; }
        public string ApplyDept { get; set; }
        public string ActualBeginDate { get; set; }
        public string ActualEndDate { get; set; }
        public int? ConsecutiveDaysOff { get; set; }
        public decimal? KkAmount { get; set; }
    }
}
