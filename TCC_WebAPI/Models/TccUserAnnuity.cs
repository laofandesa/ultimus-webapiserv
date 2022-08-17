using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccUserAnnuity
    {
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public string UserName { get; set; }
        public decimal? AnnuityBase { get; set; }
    }
}
