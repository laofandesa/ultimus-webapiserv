using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewHrpAllCurrentUser
    {
        public string UserIdentityId { get; set; }
        public string UserName { get; set; }
        public string DeptCode { get; set; }
        public string NewSalaryVest { get; set; }
        public string CompanyFlag { get; set; }
        public string HrpPersonStatus { get; set; }
        public string WagePaymentFlag { get; set; }
        public int? MyPersonStatus { get; set; }
        public string TableStatus { get; set; }
        public long? Rindex { get; set; }
        public string DeptName { get; set; }
    }
}
