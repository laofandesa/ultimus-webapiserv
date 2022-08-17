using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccApplyBreakSubsidyConfig
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public string DeptNo { get; set; }
        public string ContractType { get; set; }
        public string Name { get; set; }
        public string UserKey { get; set; }
        public string CardNo { get; set; }
    }
}
