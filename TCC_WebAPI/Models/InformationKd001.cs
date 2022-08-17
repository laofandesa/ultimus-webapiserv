using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class InformationKd001
    {
        public int Id { get; set; }
        public double? Nfare { get; set; }
        public string FromCode { get; set; }
        public string Arrivecode { get; set; }
    }
}
