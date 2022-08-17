using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewFinanceInvoicesInfo
    {
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string FormNumber { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string OwnerCode { get; set; }
        public string OwnerName { get; set; }
        public decimal? RenInvoicesAmount { get; set; }
    }
}
