using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaymentProcessMultipleLetterOfCredit
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public int? LetterType { get; set; }
        public string LetterTypeName { get; set; }
        public string Beneficiary { get; set; }
        public string IssuingBank { get; set; }
        public string Currency { get; set; }
        public decimal? LetterAmount { get; set; }
        public string LetterCode { get; set; }
        public DateTime? OpeningDate { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? LetterExchange { get; set; }
        public decimal? LetterRmb { get; set; }
        public int? CalculateMode { get; set; }
    }
}
