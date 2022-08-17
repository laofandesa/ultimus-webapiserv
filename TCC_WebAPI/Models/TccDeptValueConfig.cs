using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccDeptValueConfig
    {
        public int ConfId { get; set; }
        public string ValueDept { get; set; }
        public int? DeptType { get; set; }
        public int? OrderId { get; set; }
    }
}
