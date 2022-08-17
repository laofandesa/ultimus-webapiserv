using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class WorkPlanSituation
    {
        public Guid WorkPlanSituationOid { get; set; }
        public DateTime? SysCreated { get; set; }
        public DateTime? SysLastUpd { get; set; }
        public bool? SysDeleted { get; set; }
        public DateTime? TrueBeginTime { get; set; }
        public DateTime? TrueEndTime { get; set; }
        public string Remark { get; set; }
        public string Attachment { get; set; }
        public string Status { get; set; }
        public double? NormalWorkTime { get; set; }
        public double? OverWorkTime { get; set; }
        public string WorkType { get; set; }
        public string Leadership { get; set; }
        public int? Complete { get; set; }
        public string FillType { get; set; }
        public string Quarter { get; set; }
        public Guid? SysCreatedBy { get; set; }
        public Guid? SysReplacement { get; set; }
        public Guid? SysPostn { get; set; }
        public Guid? SysDivision { get; set; }
        public Guid? SysOrg { get; set; }
        public Guid? SysLastUpdBy { get; set; }
        public Guid? UbscPlanItemsFk { get; set; }
    }
}
