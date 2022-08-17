using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewFinanceRequestInfo
    {
        public int FId { get; set; }
        public string ProcessName { get; set; }
        public int Incident { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string RequestRealName { get; set; }
        public string FormNumber { get; set; }
        public string PayCmpName { get; set; }
        public string PayCmpCode { get; set; }
        public string AccountReceiveCmpCode { get; set; }
        public decimal? PaymentAmount { get; set; }
        public string ProjectCategory { get; set; }
        public DateTime? PlanInAcctDate { get; set; }
        public string DigestDescribition { get; set; }
        public decimal? ReceiptAmount { get; set; }
        public decimal? BillAmount { get; set; }
        public string PaidAmount { get; set; }
        public string BankNoticeNo { get; set; }
        public decimal ReceivingAmount { get; set; }
        public decimal? DwithholdingAmount { get; set; }
        public decimal DtaxWithholding { get; set; }
        public decimal? TelegraphicTransferAmount { get; set; }
        public decimal? DraftAmount { get; set; }
        public decimal? OtherAmount { get; set; }
        public decimal? ReceiveAmountTotal { get; set; }
        public int DbankCharges { get; set; }
        public string Currency { get; set; }
        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }
        public string ReceivedType { get; set; }
        public decimal? ProjectPayment { get; set; }
        public decimal? ValueAddedTax { get; set; }
        public decimal? WithholdingOfVat { get; set; }
        public decimal? StandardExchangeRate { get; set; }
        public decimal? PayInfoAmount { get; set; }
        public decimal? WaElecAmount { get; set; }
        public decimal? Ramount { get; set; }
        public int PayTheOtherAmount { get; set; }
        public string OwnersDealWithSubject { get; set; }
        public decimal? BuckleWaElecAmount { get; set; }
        public decimal? OwnerForfeit { get; set; }
    }
}
