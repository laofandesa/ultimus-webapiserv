using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewProjectAwardTree
    {
        public string NodeId { get; set; }
        public string Role { get; set; }
        public string Professional { get; set; }
        public string AwardReceiver { get; set; }
        public string AwardDesc { get; set; }
        public decimal? PaymentMoney { get; set; }
        public string ReceiverType { get; set; }
        public string ParentId { get; set; }
        public string AssignStatus { get; set; }
        public string State { get; set; }
    }
}
