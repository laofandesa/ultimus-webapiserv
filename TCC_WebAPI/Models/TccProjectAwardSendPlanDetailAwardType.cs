using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProjectAwardSendPlanDetailAwardType
    {
        public int Id { get; set; }
        public int? ProcessIncidentNoFk { get; set; }
        public string ProjectCode { get; set; }
        public string SubAwardName { get; set; }
        public string SubAwardCode { get; set; }
        public decimal? SubAwardPercentage { get; set; }
        public decimal? SubAwardAmount { get; set; }
        public decimal? ProjectAwardAmount { get; set; }
        public string ApplyDate { get; set; }
    }
}
