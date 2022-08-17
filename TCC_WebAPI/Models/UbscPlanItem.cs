using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class UbscPlanItem
    {
        public Guid UbscPlanItemsOid { get; set; }
        public string PlanItemContent { get; set; }
        public string Remark { get; set; }
        public string Xh { get; set; }
        public string ResponPerson { get; set; }
        public string RelevantDepartments { get; set; }
        public string SourceConten { get; set; }
        public string SourceOids { get; set; }
        public string AnnualStatus { get; set; }
        public string ReferencePlanItemContent { get; set; }
        public int? PichangeState { get; set; }
        public int? OrderNo { get; set; }
        public string ResponPersonOid { get; set; }
        public string RelevantDepartmentsOid { get; set; }
        public string AssistPerson { get; set; }
        public string AssistPersonOid { get; set; }
        public string AssistDepartment { get; set; }
        public string AssistDepartmentOid { get; set; }
        public string FormationPerson { get; set; }
        public string FormationPersonOid { get; set; }
        public DateTime? PlanBeginTime { get; set; }
        public DateTime? PlanEndTime { get; set; }
        public DateTime? TrueBeginTime { get; set; }
        public DateTime? TrueEndTime { get; set; }
        public string PlanItemsType { get; set; }
        public int? WeightType { get; set; }
        public string PlanFromType { get; set; }
        public double? Complete { get; set; }
        public string IcompletionStatus { get; set; }
        public string LevelCode { get; set; }
        public double? TnormalHours { get; set; }
        public double? TovertimeHours { get; set; }
        public string Type { get; set; }
        public string FirstPeopleOid { get; set; }
        public string FirstPeople { get; set; }
        public int? ApprovalStatus { get; set; }
        public int? AssistCheckNum { get; set; }
        public string MleaderCheck { get; set; }
        public Guid? UbscWorkPlanInfoFk { get; set; }
        public Guid? UbscWorkPlanDepartmentFk { get; set; }
        public Guid? UcmlContactFk { get; set; }
        public Guid? UbscPlanItemsFk { get; set; }
        public Guid? WorkPlanModeTypeFk { get; set; }
        public Guid? WorkPlanModeListFk { get; set; }
        public Guid? UbscSmIndicatorsFk { get; set; }
        public Guid? UbscSmTargetFk { get; set; }
        public Guid? UbscSmThemeLibraryFk { get; set; }
        public Guid? UbscSmDimensionsFk { get; set; }
        public Guid? ProjectItemsFk { get; set; }
        public Guid? ProjectFk { get; set; }
    }
}
