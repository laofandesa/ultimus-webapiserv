using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaymentProcessMultipleOtherBuy
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string ContractCode { get; set; }
        public string ContractCodeP { get; set; }
        public int? Dgpid { get; set; }
    }
}
