using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccLetterOfCreditOpen
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
        public string RequestSfzh { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public DateTime? RequestDate { get; set; }
        public string RequestFormNumber { get; set; }
        public int? RequestType { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public string RequestTelephone { get; set; }
        public string ProjectCodeDev { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectCategory { get; set; }
        public string ContractCode { get; set; }
        public string ContractName { get; set; }
        public int? ContractType { get; set; }
        public string ContractCategory { get; set; }
        public string UnitJnw { get; set; }
        public string ReceivingCompanyName { get; set; }
        public string ReceivingCompanyCode { get; set; }
        public DateTime? ContractSignDate { get; set; }
        public string ContractCurrency { get; set; }
        public decimal? ContractAmt { get; set; }
        public string ContractFkfs { get; set; }
        public int? RequestLccategory { get; set; }
        public string RequestLccategoryName { get; set; }
        public string RequestPaymentNode { get; set; }
        public string RequestPaymentNodeName { get; set; }
        public int? RequestPaymentTimer { get; set; }
        public DateTime? RequestOpeningDate { get; set; }
        public DateTime? RequestDueDate { get; set; }
        public int? RequestDueDay { get; set; }
        public string RequestLccurrency { get; set; }
        public decimal? RequestLcamt { get; set; }
        public decimal? RequestExchange { get; set; }
        public decimal? RequestLcrmb { get; set; }
        public string RequestDescription { get; set; }
        public DateTime? CasierClaimDate { get; set; }
        public string CasierClaimLoginUserName { get; set; }
        public string CasierClaimUserName { get; set; }
        public DateTime? AccountingAuditDate { get; set; }
        public string AccountingAuditLoginUserName { get; set; }
        public string AccountingAuditUserName { get; set; }
        public int? Voucherid { get; set; }
        public string VoucherCode { get; set; }
        public string ContractUnitName { get; set; }
        public string ContractUnitCode { get; set; }
        public int? RequestCalculateMode { get; set; }
        public int? RequestDecimalDigit { get; set; }
        public string ProjectManager { get; set; }
        public string ProjectManagerLoginName { get; set; }
        public string ProjectManagerIdentityId { get; set; }
        public string Approver1 { get; set; }
        public string Approver1LoginName { get; set; }
        public string Approver2 { get; set; }
        public string Approver2LoginName { get; set; }
        public string SignSupplierCode { get; set; }
        public string SignSupplierName { get; set; }
        public int? FinanceLccategory { get; set; }
        public string FinanceLccategoryName { get; set; }
        public string FinanceLccode { get; set; }
        public DateTime? FinanceOpeningDate { get; set; }
        public DateTime? FinanceDueDate { get; set; }
        public int? FinanceDueDay { get; set; }
        public string FinanceBeneficiary { get; set; }
        public string FinanceLccurrency { get; set; }
        public string FinanceBankName { get; set; }
        public string FinanceBankCode { get; set; }
        public string FinanceSubjectName { get; set; }
        public string FinanceSubjectCode { get; set; }
        public decimal? FinanceLcamt { get; set; }
        public decimal? FinanceLcexchange { get; set; }
        public decimal? FinanceLcrmb { get; set; }
        public string FinanceDepositCurrency { get; set; }
        public decimal? FinanceDepositAmt { get; set; }
        public decimal? FinanceDepositExchange { get; set; }
        public decimal? FinanceDepositRmb { get; set; }
        public int? Attachment { get; set; }
        public string ContractSid { get; set; }
        public int? FinanceDecimalDigit { get; set; }
        public int? FinanceCalculateMode { get; set; }
        public int? FinanceDepositDecimalDigit { get; set; }
        public int? FinanceDepositCalculateMode { get; set; }
        public int? IsDeposit { get; set; }
        public int? IsHanding { get; set; }
        public decimal? HandingAmount { get; set; }
        public string HandingBankSubjectCode { get; set; }
        public string HandingBankSubjectName { get; set; }
        public int? HandingVoucherid { get; set; }
        public string HandingVoucherCode { get; set; }
        public string GrtLtDeliver { get; set; }
        public DateTime? DeliverDate { get; set; }
        public DateTime? RequestCollectTime { get; set; }
        public string ConfirmFinaceIdnumber { get; set; }
        public string AuditAccountIdnumber { get; set; }
    }
}
