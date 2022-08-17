﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewGeneralExpensesPayInfo
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string ApplyLoginName { get; set; }
        public string ApplyRealName { get; set; }
        public string ApplyUseridentity { get; set; }
        public string PayInfoFormNumber { get; set; }
        public string PayInfoReceiveCpmpany { get; set; }
        public string PaymentReceivingCompanyCode { get; set; }
        public string ExpenseTypeName { get; set; }
        public int? ExpenseTypeCode { get; set; }
        public decimal? FinancePaymentTotal { get; set; }
        public decimal? FinanceChangeLocalCurrencyAmount { get; set; }
        public decimal? BillAmount { get; set; }
        public decimal? BillTaxAmount { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Rate { get; set; }
        public decimal? AmountRmb { get; set; }
        public string TaxRate { get; set; }
        public string TaxRateName { get; set; }
        public int? InvoiceCategoryValue { get; set; }
        public string InvoiceCategoryText { get; set; }
        public string BillCode { get; set; }
        public int? NotesNumber { get; set; }
        public string Remark { get; set; }
        public string Beyond { get; set; }
        public int? IsSupplierOrCustomer { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string InvoiceCode { get; set; }
        public string IsTaxVoucher { get; set; }
    }
}
