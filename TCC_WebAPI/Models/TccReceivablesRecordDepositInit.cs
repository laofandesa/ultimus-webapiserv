using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccReceivablesRecordDepositInit
    {
        public string ContractCode { get; set; }
        public string ContractName { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public decimal? ReceiveAmount { get; set; }
        public decimal? WithholdingAmount { get; set; }
        public decimal? Exchange { get; set; }
        public decimal? ChangeLocalCurrencyAmount { get; set; }
        public string Currency { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public int? IncidentNo { get; set; }
        public string ProcessName { get; set; }
        public int? RequestType { get; set; }
        public string RequestTypeName { get; set; }
        public int? RequestPayCategory { get; set; }
        public string RequestPayCategoryName { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public DateTime? RequestDate { get; set; }
        public string RequestFormNumber { get; set; }
        public DateTime? AccountingTime { get; set; }
        public DateTime? CreateDate { get; set; }
        public string PayCmpName { get; set; }
        public string PayCmpCode { get; set; }
        public string PayCmpAddress { get; set; }
        public string PayCmpBank { get; set; }
        public string PayCmpBankAcct { get; set; }
        public string PayCmpBankUnionAcct { get; set; }
        public int? BillCategory { get; set; }
        public string BillCategoryName { get; set; }
        public string GrtLtType { get; set; }
        public string ContCode { get; set; }
    }
}
