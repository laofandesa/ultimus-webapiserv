using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class UbscWorkPlanInfoEmpower
    {
        public Guid UbscWorkPlanInfoEmpowerOid { get; set; }
        public string EmpowerName { get; set; }
        public Guid? UbscWorkPlanDepartmentFk { get; set; }
        public Guid? UcmlUserFk { get; set; }
        public Guid? UbscWorkPlanInfoFk { get; set; }
    }
}
