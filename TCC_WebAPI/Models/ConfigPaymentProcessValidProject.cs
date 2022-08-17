using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigPaymentProcessValidProject
    {
        public int Id { get; set; }
        public string ProjectCode { get; set; }
        public int? PayCategory { get; set; }
        public int? IsEnable { get; set; }
    }
}
