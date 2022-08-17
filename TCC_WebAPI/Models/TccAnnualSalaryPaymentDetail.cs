using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAnnualSalaryPaymentDetail
    {
        public int Id { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public string UserIdentityId { get; set; }
        public string UserName { get; set; }
        public decimal? WagesShould { get; set; }
        public decimal? WagePersonalTax { get; set; }
        public decimal? RealWage { get; set; }
        public string Summary { get; set; }
        public string Dept { get; set; }
        public string DeptCode { get; set; }
    }
}
