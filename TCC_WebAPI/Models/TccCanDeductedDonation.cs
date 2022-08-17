using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccCanDeductedDonation
    {
        public int Id { get; set; }
        public string Identityid { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public decimal? Money { get; set; }
    }
}
