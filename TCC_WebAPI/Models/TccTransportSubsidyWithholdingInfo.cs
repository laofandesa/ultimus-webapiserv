using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTransportSubsidyWithholdingInfo
    {
        public int Id { get; set; }
        public string ApplyName { get; set; }
        public string ApplyUserKey { get; set; }
        public decimal? KkAmount { get; set; }
        public decimal? YkAmount { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
