using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetInfoContractInfoBasicVerification
    {
        public int Id { get; set; }
        public int? Flag { get; set; }
        public string ColumnName { get; set; }
        public int? VerifyFlag { get; set; }
        public decimal? VerifyValue { get; set; }
        public string VerifyColumn { get; set; }
    }
}
