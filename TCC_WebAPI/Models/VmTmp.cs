using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class VmTmp
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public string AwardComposed { get; set; }
        public string AwardComposeCode { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ApplyUserName { get; set; }
        public decimal ProjectAward { get; set; }
        public decimal PaymentyMoney { get; set; }
        public decimal? CurrentMoney { get; set; }
        public decimal? ApproveMoney { get; set; }
        public decimal? Yffed { get; set; }
        public string StatusA { get; set; }
        public string StatusB { get; set; }
        public string StatusC { get; set; }
        public string StatusD { get; set; }
        public string TotalState { get; set; }
    }
}
