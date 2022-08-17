using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSpecialSubsidyHeader
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestUserIdentity { get; set; }
        public string RequestUserPost { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public string RequestTelPhone { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? RequestFinishDate { get; set; }
        public string FormNumber { get; set; }
        public int? ApplyCategory { get; set; }
        public string ApplyCategoryName { get; set; }
        public string DeptCountry { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectCategory { get; set; }
        public string ProjectManager { get; set; }
        public string ProjectStatus { get; set; }
        public string ProjectAdress { get; set; }
        public DateTime? ProjectBeginDate { get; set; }
        public DateTime? ProjectEndDate { get; set; }
        public decimal? ApplyAmount { get; set; }
        public decimal? AuitAmount { get; set; }
        public decimal? ExsitAmount { get; set; }
        public string IsHighAltitudeName { get; set; }
        public int? IsHighAltitude { get; set; }
        public string IsTropicalRegionName { get; set; }
        public int? IsTropicalRegion { get; set; }
        public string PoliticalInstabilityRiskName { get; set; }
        public int? PoliticalInstabilityRisk { get; set; }
        public string TerrorismRiskName { get; set; }
        public int? TerrorismRisk { get; set; }
        public string GeographicalPosition { get; set; }
        public string MedicalAndHealthWork { get; set; }
    }
}
