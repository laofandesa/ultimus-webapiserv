using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewBalanceBasic
    {
        public string ProjectCode { get; set; }
        public decimal? Amounting { get; set; }
        public decimal? Amounted { get; set; }
    }
}
