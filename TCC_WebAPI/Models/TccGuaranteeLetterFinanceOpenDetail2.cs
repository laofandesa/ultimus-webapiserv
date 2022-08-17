using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccGuaranteeLetterFinanceOpenDetail2
    {
        public string FnDetailId { get; set; }
        public string HdId { get; set; }
        public string FnGrtLtType { get; set; }
        public string FnGrtLtCode { get; set; }
        public int FnOpenType { get; set; }
        public DateTime FnGrtLtStDt { get; set; }
        public string FnGrtLtCurrency { get; set; }
        public decimal FnGrtLtAmt { get; set; }
        public decimal FnGrtLtRmbAmt { get; set; }
        public string FnOpenEnt { get; set; }
        public string FnGrtLtBen { get; set; }
        public string FnOpenBank { get; set; }
        public DateTime? FnGrtLtEdDt { get; set; }
        public string FnOpenBankCode { get; set; }
        public string FnGrtLtRange { get; set; }
        public decimal FnGrtLtParities { get; set; }
    }
}
