using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPrintApplyCost
    {
        public int Id { get; set; }
        public string FormNumber { get; set; }
        public string FyCost { get; set; }
        public string SmCost { get; set; }
        public string StCost { get; set; }
        public string DyCost { get; set; }
        public string ZdCost { get; set; }
        public string LpCost { get; set; }
        public string PhCost { get; set; }
        public string CadCost { get; set; }
        public string ZhCos { get; set; }
        public string DzQtCost { get; set; }
        public string HtQtCost { get; set; }
        public string TotalCost { get; set; }
        public int? ServiceStatus { get; set; }
    }
}
