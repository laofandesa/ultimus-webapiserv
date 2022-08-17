using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccDraftInfoImportDraftInfo
    {
        public int Id { get; set; }
        public int? Diiid { get; set; }
        public string DraftCode { get; set; }
        public decimal? DraftAmount { get; set; }
        public string DraftAmountChineseNumeral { get; set; }
    }
}
