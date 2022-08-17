using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class UbscWorkPlanSource
    {
        public Guid UbscWorkPlanSourcesOid { get; set; }
        public Guid? WorkPlanSourcesFk { get; set; }
        public string FileUrl { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public DateTime? SysCreated { get; set; }
        public DateTime? SysLastUpd { get; set; }
        public bool? SysDeleted { get; set; }
        public Guid? SysCreatedBy { get; set; }
        public Guid? SysReplacement { get; set; }
        public Guid? SysPostn { get; set; }
        public Guid? SysDivision { get; set; }
        public Guid? SysOrg { get; set; }
        public Guid? SysLastUpdBy { get; set; }
    }
}
