using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccExpenseClaimAbroadConsolidated
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string FormNumber { get; set; }
        public string PaymentType { get; set; }
        public string ProjectCode { get; set; }
        public string Currency { get; set; }
        public decimal? Jsmoney { get; set; }
        public decimal? Money { get; set; }
        public decimal? MoneyRmb { get; set; }
    }
}
