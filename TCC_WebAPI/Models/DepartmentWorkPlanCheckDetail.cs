using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class DepartmentWorkPlanCheckDetail
    {
        public Guid DepartmentWorkPlanCheckDetailOid { get; set; }
        public DateTime? SysCreated { get; set; }
        public DateTime? SysLastUpd { get; set; }
        public bool? SysDeleted { get; set; }
        public double? Complete { get; set; }
        public double? TnormalHours { get; set; }
        public double? TovertimeHours { get; set; }
        public string Execution { get; set; }
        public Guid? SysCreatedBy { get; set; }
        public Guid? SysReplacement { get; set; }
        public Guid? SysPostn { get; set; }
        public Guid? SysDivision { get; set; }
        public Guid? SysOrg { get; set; }
        public Guid? SysLastUpdBy { get; set; }
        public Guid? DepartmentWorkPlanCheckFk { get; set; }
        public Guid? UbscPlanItemsFk { get; set; }
    }
}
