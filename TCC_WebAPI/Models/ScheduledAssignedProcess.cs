using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ScheduledAssignedProcess
    {
        public string ProcessName { get; set; }
        public string ProcessCode { get; set; }
        public bool? IsActiveByDepartment { get; set; }
        public bool? IsActiveByProject { get; set; }
        public bool? IsDel { get; set; }
    }
}
