using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewPeptjPayContractLawsuitWithStatus
    {
        public Guid LawsuitDSid { get; set; }
        public Guid LawsuitSid { get; set; }
        public string ContractCode { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public int? PaymentStatus { get; set; }
    }
}
