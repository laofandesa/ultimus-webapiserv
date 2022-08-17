using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class WorkPlanModeList
    {
        public Guid WorkPlanModeListOid { get; set; }
        public DateTime? SysCreated { get; set; }
        public DateTime? SysLastUpd { get; set; }
        public bool? SysDeleted { get; set; }
        public int? Weight { get; set; }
        public string ModeListName { get; set; }
        public Guid? SysCreatedBy { get; set; }
        public Guid? SysReplacement { get; set; }
        public Guid? SysPostn { get; set; }
        public Guid? SysDivision { get; set; }
        public Guid? SysOrg { get; set; }
        public Guid? SysLastUpdBy { get; set; }
        public Guid? WorkPlanModeTypeFk { get; set; }
    }
}
