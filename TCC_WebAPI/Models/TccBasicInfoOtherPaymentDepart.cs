using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBasicInfoOtherPaymentDepart
    {
        public int Id { get; set; }
        public int? Value { get; set; }
        public string DeptCode { get; set; }
        public int? IsDelete { get; set; }
        public int? Location { get; set; }
        public string Role { get; set; }
    }
}
