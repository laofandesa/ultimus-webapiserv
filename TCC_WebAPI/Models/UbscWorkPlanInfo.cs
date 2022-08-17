using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class UbscWorkPlanInfo
    {
        public Guid UbscWorkPlanInfoOid { get; set; }
        public string PlanTitle { get; set; }
        public string PlanYear { get; set; }
        public string PlanNo { get; set; }
        public string PlanContent { get; set; }
        public string Status { get; set; }
        public DateTime? SysCreated { get; set; }
        public DateTime? SysLastUpd { get; set; }
        public bool? SysDeleted { get; set; }
        public string FormNo { get; set; }
        public string YearlyPlanStartTime { get; set; }
        public string YearlyPlanEndTime { get; set; }
        public int? BusinessState { get; set; }
        public bool? StartFlowFlag { get; set; }
        public int? InstanceId { get; set; }
        public string FlowId { get; set; }
        public int? CheckNum { get; set; }
        public Guid? UbscWorkPlanTypeFk { get; set; }
        public Guid? SysCreatedBy { get; set; }
        public Guid? SysReplacement { get; set; }
        public Guid? SysPostn { get; set; }
        public Guid? SysDivision { get; set; }
        public Guid? SysOrg { get; set; }
        public Guid? SysLastUpdBy { get; set; }
    }
}
