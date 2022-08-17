using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReceivablesRecord
    {
        public int Id { get; set; }
        public string ContractCode { get; set; }
        public string ContractName { get; set; }
        public string ContractDate { get; set; }
        public string DeptName { get; set; }
        public string DeptCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectType { get; set; }
        public string ProjectManager { get; set; }
        public string ProjectManagerLoginName { get; set; }
        public string ProjectManagerId { get; set; }
        public string BusinessManager1 { get; set; }
        public string BusinessManagerLoginName1 { get; set; }
        public string BusinessManagerId1 { get; set; }
        public string BusinessManager2 { get; set; }
        public string BusinessManagerLoginName2 { get; set; }
        public string BusinessManagerId2 { get; set; }
        public string ReceiveType { get; set; }
        public decimal? ReceiveAmount { get; set; }
        public string Currency { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string ReceiveMethod { get; set; }
        public string ContractType { get; set; }
        public int? IncidentNo { get; set; }
        public string ProcessName { get; set; }
        public int? Status { get; set; }
        public int? Rpid { get; set; }
        public string RequestLoginName { get; set; }
        public string RequsetSfzh { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
        public string RequestRealName { get; set; }
        public DateTime? RequestDate { get; set; }
        public string RequestFormNumber { get; set; }
        public DateTime? ReceivablesTime { get; set; }
        public DateTime? AccountingTime { get; set; }
        public string Handing { get; set; }
        public string HandingIdnumber { get; set; }
        public string Operater { get; set; }
        public string OperaterIdnumber { get; set; }
        public DateTime? CreateDate { get; set; }
        public decimal? ChangeLocalCurrencyAmount { get; set; }
        public decimal? Exchange { get; set; }
        public string Remark { get; set; }
        public decimal? WithholdingAmount { get; set; }
        public decimal? TaxWithholding { get; set; }
        public decimal WithholdingOfVat { get; set; }
        public decimal? CounterFee { get; set; }
        public decimal? RateProfitAndLoss { get; set; }
        public int? RId { get; set; }
        public decimal? AmountReceivable { get; set; }
        public decimal? AmountReceivableRmb { get; set; }
        public string ProName { get; set; }
        public decimal? RefundAmount { get; set; }
        public decimal? ShouldAmount { get; set; }
        public decimal? ShouldAmountRmb { get; set; }
        public int? RequestPayCategory { get; set; }
        public decimal? BuckleWaElecAmount { get; set; }
        public decimal? ValueAddedTax { get; set; }
        public decimal? ProjectPayment { get; set; }
        public decimal? PayInfoAmount { get; set; }
        public decimal? WaElecAmount { get; set; }
        public decimal? PayTheOtherAmount { get; set; }
        public decimal OwnerForfeit { get; set; }
        public decimal ReceiveAmount1 { get; set; }
        public decimal TaxWithholding1 { get; set; }
        public decimal CounterFee1 { get; set; }
        public decimal BuckleWaElecAmount1 { get; set; }
        public decimal ZsHv { get; set; }
        public decimal? ConvertedRate { get; set; }
        public int? TcpOperate { get; set; }
    }
}
