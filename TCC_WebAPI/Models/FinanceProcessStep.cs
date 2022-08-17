using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class FinanceProcessStep
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public string StepName { get; set; }
        public int? StepId { get; set; }
        public bool FnFlag { get; set; }
    }
}
