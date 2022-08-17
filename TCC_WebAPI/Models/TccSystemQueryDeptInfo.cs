using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSystemQueryDeptInfo
    {
        public int Id { get; set; }
        public string DeptId { get; set; }
        public string DeptName { get; set; }
        public int? StepInfoFk { get; set; }
    }
}
