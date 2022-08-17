using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class WorkPlanCheckList
    {
        public Guid WorkPlanCheckListOid { get; set; }
        public DateTime? SysCreated { get; set; }
        public DateTime? SysLastUpd { get; set; }
        public bool? SysDeleted { get; set; }
        public int? CheckNumber { get; set; }
        public double? CompleteNew { get; set; }
        public double? TnormalWorkTime { get; set; }
        public double? ToverWorkTime { get; set; }
        public string CheckPersonName { get; set; }
        public string CurrentSituation { get; set; }
        public string Remark { get; set; }
        public string PlanItemContent { get; set; }
        public string PlanBeginTime { get; set; }
        public string PlanEndTime { get; set; }
        public string Complete { get; set; }
        public string ModelListName { get; set; }
        public string ResponPerson { get; set; }
        public string TnormalHours { get; set; }
        public string TovertimeHours { get; set; }
        public string AnnualStatus { get; set; }
        public Guid? SysCreatedBy { get; set; }
        public Guid? SysReplacement { get; set; }
        public Guid? SysPostn { get; set; }
        public Guid? SysDivision { get; set; }
        public Guid? SysOrg { get; set; }
        public Guid? SysLastUpdBy { get; set; }
        public Guid? UbscPlanItemsFk { get; set; }
        public Guid? WorkPlanModeListFk { get; set; }
        public Guid? UcmlUserFk { get; set; }
    }
}
