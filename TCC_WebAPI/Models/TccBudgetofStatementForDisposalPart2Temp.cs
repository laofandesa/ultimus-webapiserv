using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetofStatementForDisposalPart2Temp
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string Type { get; set; }
        public string SerialNum { get; set; }
        public string AssetName { get; set; }
        public string AssetLocation { get; set; }
        public string Number { get; set; }
        public string OwnerofCertificate { get; set; }
        public string ActualUsers { get; set; }
        public DateTime? InvestmentTime { get; set; }
        public decimal? OriginalBookValue { get; set; }
        public decimal? AccumulatedAmount { get; set; }
        public decimal? LastBookValue { get; set; }
        public int? DisposalMethodCode { get; set; }
        public string DisposalMethodName { get; set; }
        public string DocumentNum { get; set; }
        public int? AssetStatusCode { get; set; }
        public string AssetStatusName { get; set; }
        public string Remark { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string MakeUnit { get; set; }
    }
}
