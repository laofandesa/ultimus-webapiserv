using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccExpenseClaimConfigSetting
    {
        public int Id { get; set; }
        public string RealName { get; set; }
        public string LoginName { get; set; }
        public string UserIdentity { get; set; }
        public string DeptName { get; set; }
        public string DeptCode { get; set; }
        public decimal? Allowance { get; set; }
        public string Remark { get; set; }
    }
}
