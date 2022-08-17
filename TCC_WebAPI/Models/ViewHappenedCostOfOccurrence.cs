using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewHappenedCostOfOccurrence
    {
        public int? Nd { get; set; }
        public string Deptcode { get; set; }
        public decimal? Amount { get; set; }
        public int Flag { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
    }
}
