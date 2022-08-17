using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class FinanceRequestProcessOfCashierContract
    {
        public int Id { get; set; }
        public int? FId { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string RequestLoginName { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectCategory { get; set; }
        public string ApplyName { get; set; }
        public string ApplyFormNumber { get; set; }
        public decimal? ReceiveAmount { get; set; }
        public decimal? BillAmount { get; set; }
        public decimal? ReceiptAmount { get; set; }
        public decimal? PaidAmount { get; set; }
        public string BankNoticeNo { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public decimal? DwithholdingAmount { get; set; }
        public decimal? DtaxWithholding { get; set; }
        public decimal? DbankCharges { get; set; }
        public string Currency { get; set; }
        public string ReceivedType { get; set; }
        public decimal? TelegraphicTransferAmount { get; set; }
        public decimal? DraftAmount { get; set; }
        public decimal? OtherAmount { get; set; }
        public decimal? ReceiveAmountTotal { get; set; }
        public decimal? WithholdingOfVat { get; set; }
        public decimal? ProjectPayment { get; set; }
        public decimal? ValueAddedTax { get; set; }
        public decimal? PayInfoAmount { get; set; }
        public decimal? WaElecAmount { get; set; }
        public string OwnersDealWithSubject { get; set; }
        public decimal? PayTheOtherAmount { get; set; }
        public decimal? BuckleWaElecAmount { get; set; }
        public decimal? OwnerForfeit { get; set; }
        public string ContractCodeCkts { get; set; }
        public string ContractNameCkts { get; set; }
        public string SupplierCodeCkts { get; set; }
        public string SupplierNameCkts { get; set; }
    }
}
