using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPostForTransportSubsidy
    {
        public int Id { get; set; }
        public string PersonOrPost { get; set; }
        public int? Flag { get; set; }
    }
}
