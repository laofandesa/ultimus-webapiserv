﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportGeneralExpensesDeteail
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string ApplyLoginName { get; set; }
        public string ApplyRealName { get; set; }
        public string ApplyUseridentity { get; set; }
        public string ExpenseTypeName { get; set; }
        public int? ExpenseTypeCode { get; set; }
        public string BillAmount { get; set; }
        public string BillTaxAmount { get; set; }
        public string Amount { get; set; }
        public decimal? Rate { get; set; }
        public string AmountRmb { get; set; }
        public string TaxRate { get; set; }
        public string TaxRateName { get; set; }
        public int? InvoiceCategoryValue { get; set; }
        public string InvoiceCategoryText { get; set; }
        public string BillCode { get; set; }
        public int? NotesNumber { get; set; }
        public string Remark { get; set; }
        public decimal? BudgetAmount { get; set; }
        public string Using { get; set; }
        public string Beyond { get; set; }
        public string Money { get; set; }
        public string UnitCode { get; set; }
        public string UnitName { get; set; }
    }
}
