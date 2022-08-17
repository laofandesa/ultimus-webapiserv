using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigApprovedRole
    {
        public int Id { get; set; }
        public int? StepId { get; set; }
        public string StepName { get; set; }
        public string RoleId { get; set; }
        public string DeptId { get; set; }
    }
}
