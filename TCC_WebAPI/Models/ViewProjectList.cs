using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewProjectList
    {
        public DateTime? ApplyDate { get; set; }
        public decimal? CurrentMoney { get; set; }
        public decimal? ProjectManagerApproveMoney { get; set; }
        public decimal DispensedAmount { get; set; }
        public string ProjectCode { get; set; }
        public int? IncidentNo { get; set; }
        public string AwardComposeCode { get; set; }
        public long? Rn { get; set; }
    }
}
