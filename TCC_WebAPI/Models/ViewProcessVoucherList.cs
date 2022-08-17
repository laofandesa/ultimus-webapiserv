using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewProcessVoucherList
    {
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string VoucherCode { get; set; }
        public string FormNumber { get; set; }
    }
}
