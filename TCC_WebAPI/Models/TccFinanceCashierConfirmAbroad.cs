using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccFinanceCashierConfirmAbroad
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int Incident { get; set; }
        public string RequestRealName { get; set; }
        public string RequestLoginName { get; set; }
        public DateTime? RequestDate { get; set; }
        public int CategoryType { get; set; }
        public string CategoryTypeName { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public int? PaymentMethod { get; set; }
        public string PaymentMethodName { get; set; }
        public string Currency { get; set; }
        public decimal PaymentAmount { get; set; }
        public string PaymentCodes { get; set; }
        public string FundType { get; set; }
        public string CasierClaimUserName { get; set; }
        public string CasierClaimLoginUserName { get; set; }
        public int? ConfirmPayment { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public string OperateLoginUserName { get; set; }
        public string OperateUserName { get; set; }
        public DateTime? ContractPaymentDate { get; set; }
        public DateTime? CreateTime { get; set; }
        public string PaymentBank { get; set; }
        public string PaymentBankAccount { get; set; }
        public string CheckBank { get; set; }
        public string CheckBankAccount { get; set; }
        public string LetterOfCreditType { get; set; }
        public string ContractCode { get; set; }
        public string ContractName { get; set; }
        public int? Flag { get; set; }
        public string ReceivingCompanyCode { get; set; }
        public string ReceivingCompanyName { get; set; }
        public string ResponsiblePerson { get; set; }
        public string AccountingAuditUserName { get; set; }
        public string AccountingAuditLoginUserName { get; set; }
        public string ConfirmLoginUserName { get; set; }
        public string VoucherCode { get; set; }
        public string ResponsibleSfzh { get; set; }
        public string FormNumber { get; set; }
        public int? IsVoucher { get; set; }
        public string Vchrnum { get; set; }
        public string OperateIdnumber { get; set; }
        public decimal? ExchangeRate { get; set; }
        public int? Location { get; set; }
        public int? BusinessObject { get; set; }
        public string RequestTelphone { get; set; }
        public decimal? TelegraphicTransferAmount { get; set; }
        public decimal? DraftAmount { get; set; }
        public decimal? OtherAmount { get; set; }
        public decimal? ReceivingAmount { get; set; }
        public decimal? DwithholdingAmount { get; set; }
        public decimal? DtaxWithholding { get; set; }
        public decimal? StandardExchangeRate { get; set; }
        public decimal? WithholdingOfVat { get; set; }
        public decimal? ProjectPayment { get; set; }
        public decimal? ValueAddedTax { get; set; }
        public int? RecordType { get; set; }
        public decimal? BuckleWaElecAmount { get; set; }
        public decimal? OwnerForfeit { get; set; }
        public string UnitName { get; set; }
        public string UnitCode { get; set; }
        public int? DataSource { get; set; }
        public int? IsHaveBill { get; set; }
        public string RefundBank { get; set; }
        public string RefundBankAccount { get; set; }
        public string RefundSubjectCode { get; set; }
    }
}
