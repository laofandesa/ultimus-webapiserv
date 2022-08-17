using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccManagementAwardsDetail
    {
        public int Id { get; set; }
        public string ApplyName { get; set; }
        public string ProcessName { get; set; }
        public int Incident { get; set; }
        public string AwardCategory { get; set; }
        public string DeptName { get; set; }
        public string DeptNo { get; set; }
        public string PreviousYearContractAmount { get; set; }
        public string PreviousYearDrafted { get; set; }
        public string CurrentYearContractAmount { get; set; }
        public string CurrentYearDrafted { get; set; }
        public string TatalCheckBonus { get; set; }
        public string ManagementPersonnelBonus { get; set; }
        public string OperatingPersonnelBonus { get; set; }
        public string Subsidy { get; set; }
        public decimal? OuterUnitAllocatedAward { get; set; }
        public decimal? OuterUnitSubsidyAward { get; set; }
    }
}
