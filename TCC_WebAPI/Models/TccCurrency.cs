using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccCurrency
    {
        public int Id { get; set; }
        public int? Code { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyAb { get; set; }
    }
}
