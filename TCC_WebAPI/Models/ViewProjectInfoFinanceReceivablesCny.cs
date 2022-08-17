using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewProjectInfoFinanceReceivablesCny
    {
        public string Proid { get; set; }
        public string ProjectName { get; set; }
        public double? Total { get; set; }
        public decimal? RamountCny { get; set; }
        public double? RperCny { get; set; }
    }
}
