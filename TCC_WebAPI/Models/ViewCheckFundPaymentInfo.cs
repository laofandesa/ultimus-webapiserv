using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewCheckFundPaymentInfo
    {
        public string RequestFormNumber { get; set; }
        public int? Incident { get; set; }
        public int Flag { get; set; }
    }
}
