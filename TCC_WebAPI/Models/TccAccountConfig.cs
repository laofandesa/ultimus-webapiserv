using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAccountConfig
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCode { get; set; }
        public string AccountCode { get; set; }
        public string AccountHead { get; set; }
        public string PreFixSupperid { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectCategory { get; set; }
        public int? Flag { get; set; }
    }
}
