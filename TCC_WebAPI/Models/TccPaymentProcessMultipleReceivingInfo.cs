using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaymentProcessMultipleReceivingInfo
    {
        public int Id { get; set; }
        public string PaymentReceivingCompanyCode { get; set; }
        public string PaymentReceivingCompanyName { get; set; }
        public string PaymentReceivingCompanyAddress { get; set; }
        public string PaymentBankAccount { get; set; }
        public string PaymentBankName { get; set; }
        public string PaymentLineNumbers { get; set; }
        public string PaymentBankAddress { get; set; }
        public string PaymentSwiftCode { get; set; }
        public string PaymentIbanCode { get; set; }
        public string PaymentAbacode { get; set; }
        public string OperateRealName { get; set; }
        public string OperateLoginName { get; set; }
        public string OperateSfzh { get; set; }
        public DateTime? OperateTime { get; set; }
        public int? Ppid { get; set; }
        public string SignCode { get; set; }
        public string SignName { get; set; }
    }
}
