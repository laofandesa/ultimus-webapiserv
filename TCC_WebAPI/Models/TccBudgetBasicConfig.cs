using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetBasicConfig
    {
        public int Id { get; set; }
        public int? Value { get; set; }
        public string Name { get; set; }
        public int? RunningCost { get; set; }
        public int? IsEnabled { get; set; }
        public int? PayType { get; set; }
    }
}
