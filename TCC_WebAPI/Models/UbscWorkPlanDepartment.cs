using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class UbscWorkPlanDepartment
    {
        public Guid UbscWorkPlanDepartmentOid { get; set; }
        public int? Xh { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string InputTime { get; set; }
        public string InputPerson { get; set; }
        public string PostOids { get; set; }
        public string PostNames { get; set; }
        public string LastVerityPersonOid { get; set; }
        public string UpdatePerson { get; set; }
        public string UpdateTime { get; set; }
        public string CompilePersonId { get; set; }
        public string CompilePersonName { get; set; }
        public string AuditorsPersonName { get; set; }
        public string ResponPersons { get; set; }
        public string State { get; set; }
        public int? ChangeState { get; set; }
        public int? BusinessState { get; set; }
        public bool? StartFlowFlag { get; set; }
        public int? InstanceId { get; set; }
        public string FlowId { get; set; }
        public string Type { get; set; }
        public DateTime? PlanBeginTime { get; set; }
        public DateTime? PlanEndTime { get; set; }
        public string InputPersonOid { get; set; }
        public string EditPerson { get; set; }
        public string EditPersonId { get; set; }
        public string BelongDpt { get; set; }
        public string BelongDptId { get; set; }
        public string EditTime { get; set; }
        public string TaskId { get; set; }
        public string FormNo { get; set; }
        public Guid? UcmlOrganizeFk { get; set; }
        public Guid? UbscWorkPlanInfoFk { get; set; }
        public Guid? VerityPostOid { get; set; }
        public Guid? UcmlUserFk { get; set; }
    }
}
