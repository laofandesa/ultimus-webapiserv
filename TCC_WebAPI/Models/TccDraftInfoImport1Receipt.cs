using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccDraftInfoImport1Receipt
    {
        public int Id { get; set; }
        public int? Fid { get; set; }
        public string FFormNumber { get; set; }
        public int? FId1 { get; set; }
        public decimal? FAmount { get; set; }
        public decimal? FDraftAmount { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
    }
}
