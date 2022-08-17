using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccGuaranteeLetterFnVouch
    {
        public string FnGrtLtVchId { get; set; }
        public string HdId { get; set; }
        public string FnVchCreateUser { get; set; }
        public string FnVchCheckUser { get; set; }
        public string FnVchCashier { get; set; }
        public string FnVchCode { get; set; }
        public int VoucherId { get; set; }
        public int Attachment { get; set; }
        public decimal FnGrtLtGuaAmt { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerType { get; set; }
        public string CustomerName { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string DrawSubjectCode { get; set; }
        public string DrawBankCode { get; set; }
        public string DrawBankName { get; set; }
        public string PaySubjectCode { get; set; }
        public string PayBankCode { get; set; }
        public string PayBankName { get; set; }
        public string FormNumber { get; set; }
        public DateTime? RequestDate { get; set; }
    }
}
