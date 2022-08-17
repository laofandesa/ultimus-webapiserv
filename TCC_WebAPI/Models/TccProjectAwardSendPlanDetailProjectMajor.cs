using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProjectAwardSendPlanDetailProjectMajor
    {
        public int Id { get; set; }
        public int? ProcessIncidentNoFk { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectMajorName { get; set; }
        public string ProjectMajorCode { get; set; }
        public decimal? ProjectMajorAwardPercentage { get; set; }
        public decimal? ProjectMajorAwardAmount { get; set; }
        public decimal? MilestoneAwardAmount { get; set; }
        public string ApplyDate { get; set; }
        public int? CanSend { get; set; }
    }
}
