using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccJsgTest
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyName { get; set; }
        public string ApplyDeptNo { get; set; }
        public string ApplyDept { get; set; }
        public string ApplyRemark { get; set; }
    }
}
