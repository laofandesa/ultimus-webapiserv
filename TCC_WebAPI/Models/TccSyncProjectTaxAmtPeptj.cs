using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSyncProjectTaxAmtPeptj
    {
        public long Id { get; set; }
        public string ProjectCode { get; set; }
        public decimal? TaxAmount { get; set; }
    }
}
