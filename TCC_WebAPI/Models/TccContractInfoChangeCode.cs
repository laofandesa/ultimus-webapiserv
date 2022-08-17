using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccContractInfoChangeCode
    {
        public int Id { get; set; }
        public string OldContractCode { get; set; }
        public string NewContractCode { get; set; }
    }
}
