using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccStandardforTelephoneSubsidy
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string PersonOrPost { get; set; }
        public string UserIdentity { get; set; }
        public decimal? Standard { get; set; }
        public int? Flag { get; set; }
    }
}
