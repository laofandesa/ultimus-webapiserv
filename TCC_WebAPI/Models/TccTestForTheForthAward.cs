using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTestForTheForthAward
    {
        public int Id { get; set; }
        public string UserIdentityId { get; set; }
        public decimal? AwardMoney { get; set; }
        public DateTime? ArchiveDate { get; set; }
        public string AwardComposedCode { get; set; }
    }
}
