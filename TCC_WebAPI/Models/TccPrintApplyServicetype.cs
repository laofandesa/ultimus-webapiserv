using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPrintApplyServicetype
    {
        public int Id { get; set; }
        public string ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceType { get; set; }
        public string ServiceClass { get; set; }
    }
}
