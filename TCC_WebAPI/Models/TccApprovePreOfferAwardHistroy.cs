using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccApprovePreOfferAwardHistroy
    {
        public int Id { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectManager { get; set; }
        public string ProjectManagerIdentityId { get; set; }
        public decimal? ActrualWork { get; set; }
        public decimal? AdjustmentFactor { get; set; }
        public decimal? PreOfferAward { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public string ProjectManagerLoginname { get; set; }
        public int? Status { get; set; }
    }
}
