using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccExpenseClaimSpecialDetail
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string RequestLoginName { get; set; }
        public string ApplyPerson { get; set; }
        public string UserIdentity { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public decimal? Amount { get; set; }
    }
}
