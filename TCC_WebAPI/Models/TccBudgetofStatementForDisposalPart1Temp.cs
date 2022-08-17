using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetofStatementForDisposalPart1Temp
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string Type { get; set; }
        public string SerialNum { get; set; }
        public string DisposalofSubject { get; set; }
        public decimal? RegisteredAmount { get; set; }
        public string ShareholdingRatio { get; set; }
        public decimal? SubscribedCapitalAmount { get; set; }
        public decimal? PaidinCapitalAmount { get; set; }
        public DateTime? InvestmentTime { get; set; }
        public decimal? OriginalBookValue { get; set; }
        public decimal? ProvisionofImpairmentAmount { get; set; }
        public decimal LastBookValue { get; set; }
        public int? DisposalMethodCode { get; set; }
        public string DisposalMethodName { get; set; }
        public decimal? DisposalIncome { get; set; }
        public string DocumentNum { get; set; }
        public decimal? TheAuditedAssets { get; set; }
        public decimal? TotalProfit1 { get; set; }
        public decimal? TotalProfit2 { get; set; }
        public decimal? TotalProfit3 { get; set; }
        public decimal? AccumulatedDividendAmount { get; set; }
        public decimal? AmountofDividendsReceived { get; set; }
        public string TableOrNot { get; set; }
        public string RegisterOrNot { get; set; }
        public string Industry { get; set; }
        public string Remark { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string MakeUnit { get; set; }
    }
}
