using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetProcessWageBasicDatum
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Flag { get; set; }
        public int? IsDelete { get; set; }
    }
}
