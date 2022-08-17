using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewGrtLtChangeInfo
    {
        public string HdId { get; set; }
        public string IsSueForPayStr { get; set; }
        public decimal? ClaimAmt { get; set; }
        public string IsSueStr { get; set; }
        public string IsDelayStr { get; set; }
        public DateTime? DelayEdDt { get; set; }
        public string OrigIsSetBackStr { get; set; }
    }
}
