using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccLetterOfCreditPaymentHistory
    {
        public int Id { get; set; }
        public int? Fid { get; set; }
        public int? Pid { get; set; }
        public string PayLccode { get; set; }
        public DateTime? PayCreateDate { get; set; }
        public decimal? PayAmount { get; set; }
        public decimal? PayExchange { get; set; }
        public decimal? PayRmb { get; set; }
    }
}
