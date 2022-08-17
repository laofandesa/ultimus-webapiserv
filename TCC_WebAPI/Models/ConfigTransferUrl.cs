using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigTransferUrl
    {
        public int Id { get; set; }
        public int? BusinessNameId { get; set; }
        public string BusinessName { get; set; }
        public int? ProcessNameId { get; set; }
        public string ProcessName { get; set; }
        public string TccUrl { get; set; }
        public string TccDomain { get; set; }
        public string Caption { get; set; }
    }
}
