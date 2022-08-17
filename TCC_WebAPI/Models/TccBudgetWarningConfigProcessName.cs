using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetWarningConfigProcessName
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public string StepLabel { get; set; }
        public string Flag { get; set; }
    }
}
