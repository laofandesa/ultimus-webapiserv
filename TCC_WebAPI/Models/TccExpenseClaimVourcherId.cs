using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccExpenseClaimVourcherId
    {
        public int Id { get; set; }
        public int? Incident { get; set; }
        public int? VourcherId { get; set; }
    }
}
