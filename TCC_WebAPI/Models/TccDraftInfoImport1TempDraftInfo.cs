using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccDraftInfoImport1TempDraftInfo
    {
        public int Id { get; set; }
        public int? Diiid { get; set; }
        public string DraftCode { get; set; }
        public decimal? DraftAmount { get; set; }
        public string DraftAmountChineseNumeral { get; set; }
        public DateTime? DrawerDate { get; set; }
        public DateTime? DueDate { get; set; }
        public int? DueDay { get; set; }
        public string DrawerName { get; set; }
        public string DrawerAccounts { get; set; }
        public string PayingBankName { get; set; }
        public string PayingBankNumber { get; set; }
        public string PayingBankAddress { get; set; }
        public string Currency { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string PayeeName { get; set; }
        public string PayeeAccounts { get; set; }
        public string PayeeBank { get; set; }
        public string RecourseType { get; set; }
    }
}
