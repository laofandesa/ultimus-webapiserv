using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportExpenseClaimWjryLine
    {
        public int Id { get; set; }
        public string RequestLoginName { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string Credential { get; set; }
        public string PersonRealName { get; set; }
        public int? CredentialType { get; set; }
        public string CredentialTypeName { get; set; }
        public string CredentialName { get; set; }
        public int? PayCurrency { get; set; }
        public string PayCurrencyName { get; set; }
        public string Money { get; set; }
        public decimal? Rate { get; set; }
        public string MoneyRmb { get; set; }
        public string ReceiveAccount { get; set; }
        public string ReceiveBankName { get; set; }
    }
}
