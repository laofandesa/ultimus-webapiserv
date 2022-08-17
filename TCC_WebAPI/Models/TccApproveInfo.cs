using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccApproveInfo
    {
        public int Id { get; set; }
        public int? Incident { get; set; }
        public string ProcessName { get; set; }
        public string TccApproveName { get; set; }
        public string TccApproveResult { get; set; }
        public string TccRemark { get; set; }
        public DateTime TccApproveDate { get; set; }
        public string TccStepName { get; set; }
        public int? TccApproveState { get; set; }
        public int? TccStepId { get; set; }
        public string TccBigMoney { get; set; }
        public string TccSmallMoney { get; set; }
    }
}
