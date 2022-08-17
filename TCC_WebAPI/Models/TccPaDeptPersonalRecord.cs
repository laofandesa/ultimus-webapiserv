using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaDeptPersonalRecord
    {
        public long Id { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyName { get; set; }
        public string ApplyDeptNo { get; set; }
        public string ApplyDept { get; set; }
        public string ApplyYear { get; set; }
        public string PostName { get; set; }
        public string PostChangeDate { get; set; }
        public string ProcessStatus { get; set; }
        public string FileIds { get; set; }
        public string PaPoint { get; set; }
        public string PaResult { get; set; }
        public string PaAdviceResult { get; set; }
        public string PaConfirmResult { get; set; }
        public string WorkPerformancePoint { get; set; }
        public string OthersEvaluatePoint { get; set; }
        public string OthersPaPointZdx { get; set; }
        public string OthersPaPointXysj { get; set; }
        public string OthersPaPointJjwtsj { get; set; }
        public string OthersPaPointXxfksj { get; set; }
        public string OthersPaPointFwzl { get; set; }
        public string AbilityEvaluatePoint { get; set; }
        public string AbilityEvaluatePointGtlj { get; set; }
        public string AbilityEvaluatePointJhzx { get; set; }
        public string AbilityEvaluatePointJnjq { get; set; }
        public string AbilityEvaluatePointXxcx { get; set; }
        public int? PainfoFk { get; set; }
    }
}
