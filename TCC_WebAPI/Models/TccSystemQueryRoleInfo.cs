using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSystemQueryRoleInfo
    {
        public int Id { get; set; }
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDeptId { get; set; }
        public string RoleDeptName { get; set; }
        public int StepInfoFk { get; set; }
    }
}
