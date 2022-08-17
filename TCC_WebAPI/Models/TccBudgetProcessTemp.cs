using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetProcessTemp
    {
        public int Id { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public string Year { get; set; }
        public string BatchNumber { get; set; }
        public int? IsDelete { get; set; }
        public int? BdgType { get; set; }
        public int? AuditType { get; set; }
        public int? LevelFlag { get; set; }
    }
}
