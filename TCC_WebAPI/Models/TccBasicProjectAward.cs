using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBasicProjectAward
    {
        public int Id { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public decimal? ProjectAward { get; set; }
        public decimal? PaymentyMoney { get; set; }
        public decimal? Balances { get; set; }
        public decimal? InitProjectAwardMoney { get; set; }
    }
}
