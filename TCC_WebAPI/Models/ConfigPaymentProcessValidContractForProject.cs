using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigPaymentProcessValidContractForProject
    {
        public int Id { get; set; }
        public string ProjectCode { get; set; }
        public string ContractCode { get; set; }
        public int? IsEnable { get; set; }
    }
}
