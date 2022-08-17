using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccLetterOfCreditCounterFeeMain
    {
        public int Id { get; set; }
        public int? Voucherid { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string RequestRealName { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestUserIdentity { get; set; }
        public string RequestDeptcode { get; set; }
        public string RequestDeptname { get; set; }
        public DateTime? RequestDtae { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? PaymentMethod { get; set; }
        public string PaymentType { get; set; }
        public string PaymentVatcurrency { get; set; }
        public string PaymentVatcurrencyShow { get; set; }
        public string PayBankName { get; set; }
        public string PayBankNumbers { get; set; }
        public string PayBankSubjectCode { get; set; }
        public string JoneslanglasallNumber { get; set; }
        public int? ProcessStatus { get; set; }
        public string FormNumber { get; set; }
        public int? Attachment { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
        public string RequestFormNumber { get; set; }
        public DateTime? RequestDate { get; set; }
        public string CheckUserName { get; set; }
    }
}
