using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaymentProcessMultipleCreditLetterInfo
    {
        public int Id { get; set; }
        public int Pid { get; set; }
        public decimal PaymentAmount { get; set; }
        public string CreditLetterCode { get; set; }
        public decimal CreditLetterAmount { get; set; }
        public decimal CreditLetterSurplus { get; set; }
    }
}
