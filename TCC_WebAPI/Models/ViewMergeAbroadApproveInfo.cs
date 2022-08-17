using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewMergeAbroadApproveInfo
    {
        public int Id { get; set; }
        public string MainFormNumber { get; set; }
        public string FormNumber { get; set; }
        public string ProcessName { get; set; }
        public string AbroadType { get; set; }
        public int? Incident { get; set; }
        public int ApproveId { get; set; }
        public string ApproveUserLoginName { get; set; }
        public string ApproveUserName { get; set; }
        public int? ApproveResultCode { get; set; }
        public string ApproveResult { get; set; }
        public string ApproveRemark { get; set; }
        public string StepName { get; set; }
        public int? StepId { get; set; }
        public DateTime? ApproveDate { get; set; }
    }
}
