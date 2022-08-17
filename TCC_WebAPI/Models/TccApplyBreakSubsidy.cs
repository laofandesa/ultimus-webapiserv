using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccApplyBreakSubsidy
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string FormNumber { get; set; }
        public DateTime? RequestDate { get; set; }
        public int? MYear { get; set; }
        public int? MMonth { get; set; }
        public string RequestUserName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public string RequestTelPhone { get; set; }
        public string ClaimsDepartmentName { get; set; }
        public string ClaimsDepartmentCode { get; set; }
        public string AdressLocation { get; set; }
        public decimal? MoneyActual { get; set; }
    }
}
