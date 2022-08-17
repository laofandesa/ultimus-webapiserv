using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class UbscWorkPlanVerifyDetail
    {
        public Guid UbscWorkPlanVerifyDetailsOid { get; set; }
        public string Status { get; set; }
        public string VerifyOpinion { get; set; }
        public DateTime? SysCreated { get; set; }
        public DateTime? SysLastUpd { get; set; }
        public bool? SysDeleted { get; set; }
        public Guid? UbscWorkPlanInfoFk { get; set; }
        public Guid? UbscWorkPlanDepartmentFk { get; set; }
        public Guid? SysCreatedBy { get; set; }
        public Guid? SysReplacement { get; set; }
        public Guid? SysPostn { get; set; }
        public Guid? SysDivision { get; set; }
        public Guid? SysOrg { get; set; }
        public Guid? SysLastUpdBy { get; set; }
    }
}
