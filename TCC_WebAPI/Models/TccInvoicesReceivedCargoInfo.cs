using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccInvoicesReceivedCargoInfo
    {
        public int Id { get; set; }
        public string Requestor { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public DateTime? DeclareDate { get; set; }
        public string CustomsCode { get; set; }
        public string CdCode { get; set; }
        public DateTime? ExportDate { get; set; }
        public decimal? MoneyTotal { get; set; }
        public string MoneyType { get; set; }
        public decimal? MoneyRate { get; set; }
        public decimal? MoneyCny { get; set; }
        public int? ItemSid { get; set; }
        public string ItemName { get; set; }
        public decimal? Num { get; set; }
        public string Unit { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? ZhRmb { get; set; }
        public decimal? ExportRebateRate { get; set; }
        public decimal? TotalPriceCnyChanged { get; set; }
    }
}
