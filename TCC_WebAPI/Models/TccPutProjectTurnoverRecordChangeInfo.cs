using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPutProjectTurnoverRecordChangeInfo
    {
        public int Id { get; set; }
        public string CardholdName { get; set; }
        public string CardholdLogin { get; set; }
        public string PayCheque { get; set; }
        public string CardCurrency { get; set; }
        public decimal? Quota { get; set; }
        public decimal? MoneyYb { get; set; }
        public string FormNumber { get; set; }
        public decimal? QuotaChange { get; set; }
        public decimal? FinanceQuota { get; set; }
        public int? IsEnabled { get; set; }
        public DateTime? EnabledDate { get; set; }
        public DateTime? EnabledEndDate { get; set; }
    }
}
