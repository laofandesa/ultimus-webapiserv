using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewExpenseClaimCashierConfirmDetail
    {
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string FormNumber { get; set; }
        public string RequestLoginName { get; set; }
        public decimal? MoneyActual { get; set; }
        public string RequestUserIdentity { get; set; }
        public string RequestRealName { get; set; }
        public string RequestIdNum { get; set; }
        public int? Agency { get; set; }
        public string TravelClaimCategory { get; set; }
        public int? Payee { get; set; }
        public string BusinessCardcode { get; set; }
        public string C012c { get; set; }
    }
}
