using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportPaymentProcessMultipleDepartmentCode
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string PaymentAmount { get; set; }
        public int? Flag { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
    }
}
