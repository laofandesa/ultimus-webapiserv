using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccLetterOfCreditCounterFee
    {
        public int Id { get; set; }
        public int? Hdid { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ContractCode { get; set; }
        public string Contractname { get; set; }
        public string RequestRealName { get; set; }
        public string Locid { get; set; }
        public decimal? Poundage { get; set; }
        public decimal? PoundageRmb { get; set; }
        public DateTime? Timeofpayment { get; set; }
        public string Currency { get; set; }
        public string Parities { get; set; }
        public decimal? Lcamt { get; set; }
        public int? Isjq { get; set; }
        public int? Source { get; set; }
    }
}
