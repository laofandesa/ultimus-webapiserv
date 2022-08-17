using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewFinanceRecInvoice
    {
        public string PayFormNumber { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ContractCode { get; set; }
        public string ContractName { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public DateTime? RecInvoiceDate { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestIdentity { get; set; }
        public decimal? PayAmount { get; set; }
        public decimal? RecInvoicesAmount { get; set; }
        public decimal? RecBillsAmount { get; set; }
        public string RecBankAccount { get; set; }
        public string RecCompanyCode { get; set; }
        public string RecCompanyName { get; set; }
        public decimal? PayActualAmount { get; set; }
        public decimal WithholdingTax { get; set; }
        public string TransactorLoginName { get; set; }
        public string TransactorRealName { get; set; }
        public string TransactorIdentity { get; set; }
        public int? ProcessStatus { get; set; }
        public decimal? AmountCnt { get; set; }
    }
}
