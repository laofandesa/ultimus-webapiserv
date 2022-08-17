using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccApproveMoneyHistroy
    {
        public int Id { get; set; }
        public int? IncidentNo { get; set; }
        public string ProcessName { get; set; }
        public decimal? ApproveMoney { get; set; }
        public string ApproverUserLoginName { get; set; }
        public string ApproverName { get; set; }
        public decimal? ApproveAdjustMoney { get; set; }
        public decimal? ApproveProjectStatus { get; set; }
        public int? StepId { get; set; }
    }
}
