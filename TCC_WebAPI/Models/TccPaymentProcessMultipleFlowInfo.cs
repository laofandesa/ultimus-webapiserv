using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaymentProcessMultipleFlowInfo
    {
        public int Id { get; set; }
        public int? FlowId { get; set; }
        public int? RelationFlowId { get; set; }
    }
}
