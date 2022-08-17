using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaymentProcessFlowInfo
    {
        public int Id { get; set; }
        public int? FlowId { get; set; }
        public int? FelationFlowId { get; set; }
    }
}
