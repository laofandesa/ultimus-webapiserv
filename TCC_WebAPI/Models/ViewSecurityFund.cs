using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewSecurityFund
    {
        public string IdentityId { get; set; }
        public DateTime? DispenseDate { get; set; }
        public decimal? SocialSecurityAmount { get; set; }
        public decimal? ProvidentfundAmount { get; set; }
        public decimal EntAnnuityAmount { get; set; }
    }
}
