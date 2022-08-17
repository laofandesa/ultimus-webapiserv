using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccMainMonthPaymentRecord
    {
        public int Id { get; set; }
        public string VchrtypeCode { get; set; }
        public int? AcctYear { get; set; }
        public int? AcctPeriod { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UnitCode { get; set; }
        public string AcctBookCode { get; set; }
        public string CreateUser { get; set; }
        public string CheckUser { get; set; }
        public DateTime? CheckDate { get; set; }
        public string CashUser { get; set; }
        public DateTime? CashDate { get; set; }
        public int? Attachment { get; set; }
        public string Memo { get; set; }
        public int? ResponseFlag { get; set; }
        public string ResponseMessage { get; set; }
        public string Vchrid { get; set; }
        public string Vchrtype { get; set; }
        public int? Vchrnum { get; set; }
        public int? RecordType { get; set; }
        public string NewVest { get; set; }
        public string VoucherCode { get; set; }
    }
}
