using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccMileStoneAwardSendPlanDetail
    {
        public int Id { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectMajor { get; set; }
        public string SendMonth { get; set; }
        public decimal? SendAwardAmount { get; set; }
        public string ApplyDate { get; set; }
        public int? IncidentNoFk { get; set; }
    }
}
