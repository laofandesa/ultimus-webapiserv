using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccInvoicesReceivedDepartmentList
    {
        public int Id { get; set; }
        public int? Rid { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public int? Flag { get; set; }
        public string ApplicationCode { get; set; }
        public string ApplicationName { get; set; }
        public decimal? Amount { get; set; }
    }
}
