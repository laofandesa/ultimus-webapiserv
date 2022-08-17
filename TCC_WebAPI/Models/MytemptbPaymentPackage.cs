using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class MytemptbPaymentPackage
    {
        public long? Num { get; set; }
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public decimal? ShiFaGongZi { get; set; }
        public decimal RealWages { get; set; }
        public string NewSalaryVest { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public decimal? Fuli { get; set; }
    }
}
