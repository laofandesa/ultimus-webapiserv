using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccGuaranteeLetterFinanceOpenDetail
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
        public decimal FnGrtLtGuaAmt { get; set; }
        public DateTime? FnGrtLtEdDt { get; set; }
        public string FnGrtLtReceiptor { get; set; }
        public DateTime? FnGrtLtReceiveDt { get; set; }
        public string FnOpenBankCode { get; set; }
        public string FnPayBankName { get; set; }
        public string FnPayBankAcct { get; set; }
        public string FnPayBankSubjectCode { get; set; }
        public int Attachment { get; set; }
        public string FnGrtLtRange { get; set; }
        public decimal FnGrtLtParities { get; set; }
        public int? IsHanding { get; set; }
        public decimal? HandingAmount { get; set; }
        public string HandingBankSubjectCode { get; set; }
        public string HandingBankSubjectName { get; set; }
        public int? HandingVoucherid { get; set; }
        public string HandingVoucherCode { get; set; }
        public string HandingCreateUser { get; set; }
        public string HandingCheckUser { get; set; }
    }
}
