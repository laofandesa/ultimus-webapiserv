using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccInjuryIdentity
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string FormNumber { get; set; }
        public string AgentName { get; set; }
        public string AgentLoginUser { get; set; }
        public string AgentDeptName { get; set; }
        public string InjuryName { get; set; }
        public string InjuryDept { get; set; }
        public string InjuryDeptNo { get; set; }
        public string Position { get; set; }
        public string TypeId { get; set; }
        public string TypeName { get; set; }
        public int? Sex { get; set; }
        public int? Age { get; set; }
        public DateTime? EnterWorkDate { get; set; }
        public DateTime? WorkDate { get; set; }
        public string InjuryType { get; set; }
        public string InjuryGrade { get; set; }
        public string InjuryPhone { get; set; }
        public string InjuryDomicile { get; set; }
        public string InjuryUserKey { get; set; }
        public string ContractUser { get; set; }
        public string InjuryAddress { get; set; }
        public string PostNumber { get; set; }
        public DateTime? HappenTime { get; set; }
        public string HappenPlace { get; set; }
        public string HappenContent { get; set; }
        public string HappenDecription { get; set; }
        public DateTime? DiagnoseTime { get; set; }
        public string DiagnosePlace { get; set; }
        public decimal? CostFare { get; set; }
        public int? InjuryUserType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? RequestDate { get; set; }
        public int? Flag { get; set; }
        public int? IsSubmit { get; set; }
    }
}
