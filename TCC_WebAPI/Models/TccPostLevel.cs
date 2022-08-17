using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPostLevel
    {
        public string UserRealName { get; set; }
        public string UserIdentity { get; set; }
        public decimal? C1714 { get; set; }
        public string IsFanPin { get; set; }
    }
}
