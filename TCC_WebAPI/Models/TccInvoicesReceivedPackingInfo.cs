using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccInvoicesReceivedPackingInfo
    {
        public int Id { get; set; }
        public string Requestor { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string ContCode { get; set; }
        public string MoneyType { get; set; }
        public decimal? Hthl { get; set; }
        public int? ContSid { get; set; }
        public string IdentCode { get; set; }
        public string GroupCode { get; set; }
        public string GroupShortDesc { get; set; }
        public string PartCode { get; set; }
        public string PartShortDesc { get; set; }
        public string PartName { get; set; }
        public string Unit { get; set; }
        public int? Qty { get; set; }
        public int? SyQty { get; set; }
        public int? BcQty { get; set; }
        public decimal? Amount { get; set; }
        public string ScName { get; set; }
        public string ScCode { get; set; }
        public string BillCode { get; set; }
        public string HBillCode { get; set; }
        public decimal? Money { get; set; }
        public decimal? MoneyRmb { get; set; }
    }
}
