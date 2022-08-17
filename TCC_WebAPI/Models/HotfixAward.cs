using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class HotfixAward
    {
        public int Id { get; set; }
        public string UserIdentityId { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public decimal? FixMoney { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
