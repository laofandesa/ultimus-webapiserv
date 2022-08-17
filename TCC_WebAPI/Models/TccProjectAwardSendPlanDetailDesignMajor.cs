using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProjectAwardSendPlanDetailDesignMajor
    {
        public int Id { get; set; }
        public int? ProcessIncidentNoFk { get; set; }
        public string ProjectCode { get; set; }
        public string DesignMajorName { get; set; }
        public string DesignMajorCode { get; set; }
        public decimal? DesignMajorAwardAmount { get; set; }
        public decimal? MajorDesignPercentage { get; set; }
        public decimal? MajorProjectPercentage { get; set; }
        public string DesignMajorDeptName { get; set; }
        public string DesignMajorDeptCode { get; set; }
        public decimal? DesignDeptAwardAmount { get; set; }
        public decimal? DeptDesignPercentage { get; set; }
        public decimal? DeptProjectPercentage { get; set; }
        public string ApplyDate { get; set; }
        public int? CanSend { get; set; }
    }
}
