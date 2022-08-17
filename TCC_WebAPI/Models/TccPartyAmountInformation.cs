using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPartyAmountInformation
    {
        public int Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string BankNo { get; set; }
        public string UserName { get; set; }
        public decimal? Amount { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public string ZhiBu { get; set; }
        public string Remark { get; set; }
        public string Remarks { get; set; }
        public string Summary { get; set; }
        public string BusinessDate { get; set; }
        public string BusinessTime { get; set; }
        public string ZhiBuCode { get; set; }
    }
}
