using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTaxRateMappingYearIncome
    {
        public int Id { get; set; }
        public decimal? TaxPoint { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? QuickDeduction { get; set; }
    }
}
