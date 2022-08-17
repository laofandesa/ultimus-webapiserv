using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSeparationCompletion
    {
        public int Id { get; set; }
        public string UserIdentityId { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
    }
}
