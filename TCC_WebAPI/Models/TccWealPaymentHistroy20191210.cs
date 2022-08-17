using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccWealPaymentHistroy20191210
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public string ApplyUserLoginName { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string UserLoginName { get; set; }
        public string UserRealName { get; set; }
        public string UserIdentity { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? WealFlag { get; set; }
        public string IsFanPin { get; set; }
        public int? IsGrant { get; set; }
        public int? Status { get; set; }
        public int? SendedMonth { get; set; }
        public int? SendedYear { get; set; }
    }
}
