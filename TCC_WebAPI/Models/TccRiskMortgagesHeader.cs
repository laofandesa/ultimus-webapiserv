using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccRiskMortgagesHeader
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestUserIdentity { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public string FormNumber { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
        public DateTime? DirectorApproveDate { get; set; }
        public int? Operate { get; set; }
    }
}
