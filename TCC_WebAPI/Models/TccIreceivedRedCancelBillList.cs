﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccIreceivedRedCancelBillList
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string RequestLoginName { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string CProcessName { get; set; }
        public string CFormNumber { get; set; }
        public string CIncident { get; set; }
        public string BillCode { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string InvoiceCategoryValue { get; set; }
        public string InvoiceCategoryText { get; set; }
        public string BillContent { get; set; }
        public decimal? BillAmount { get; set; }
        public decimal? BillTaxAmount { get; set; }
        public decimal? Amount { get; set; }
        public string TaxRateCode { get; set; }
        public string TaxRateText { get; set; }
        public decimal? TaxRate { get; set; }
        public string Currency { get; set; }
        public decimal? Exchange { get; set; }
        public decimal? BillAmountRmb { get; set; }
        public decimal? BillTaxAmountRmb { get; set; }
        public int? CalculateMode { get; set; }
        public decimal? AmountRmb { get; set; }
        public string InvoiceCode { get; set; }
        public decimal? BillAmountCnt { get; set; }
        public decimal? BillTaxAmountCnt { get; set; }
        public decimal? ExchangeCnt { get; set; }
        public string RelevanceInvoiceCategoryValue { get; set; }
        public string RelevanceInvoiceCategoryText { get; set; }
        public string RelevanceRateCode { get; set; }
        public string RelevanceRateText { get; set; }
    }
}
