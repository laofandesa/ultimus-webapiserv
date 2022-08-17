using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBasicAward
    {
        public int Id { get; set; }
        public string AwardType { get; set; }
        public string AwardTypeCode { get; set; }
        public string AwardName { get; set; }
        public string AwardNameCode { get; set; }
        public string Dept { get; set; }
        public string DeptCode { get; set; }
        public string AwardComposed { get; set; }
        public string AwardComposeCode { get; set; }
        public string Beneficiary { get; set; }
        public string BeneficiaryCode { get; set; }
        public int? AwardBelong { get; set; }
        public int? AwardDiy { get; set; }
    }
}
