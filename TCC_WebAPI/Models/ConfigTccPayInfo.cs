using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigTccPayInfo
    {
        public int Id { get; set; }
        public string PayTable { get; set; }
        public string IbanCode { get; set; }
        public string Abacode { get; set; }
        public string SwichCode { get; set; }
        public string PaymentBankAccount { get; set; }
        public string PaymentLineNumbers { get; set; }
        public string PaymentBankName { get; set; }
        public string PaymentBankAddress { get; set; }
        public string PaymentReceivingCompanyAddress { get; set; }
        public string PaymentReceivingCompanyCode { get; set; }
        public string PaymentReceivingCompanyName { get; set; }
    }
}
