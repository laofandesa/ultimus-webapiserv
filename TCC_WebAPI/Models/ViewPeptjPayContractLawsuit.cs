using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewPeptjPayContractLawsuit
    {
        public string LawsuitDSid { get; set; }
        public string LawsuitSid { get; set; }
        public string ContractCode { get; set; }
        public DateTime? ConfirmDate { get; set; }
    }
}
