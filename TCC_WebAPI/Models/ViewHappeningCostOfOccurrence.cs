using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewHappeningCostOfOccurrence
    {
        public string ProName { get; set; }
        public int? Incident { get; set; }
        public decimal? AmountIng { get; set; }
    }
}
