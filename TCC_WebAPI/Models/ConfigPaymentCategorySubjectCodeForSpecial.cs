using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigPaymentCategorySubjectCodeForSpecial
    {
        public int Id { get; set; }
        public int? ApplicationCode { get; set; }
        public string ApplicationName { get; set; }
        public int? InvoiceCategoryValue { get; set; }
        public string InvoiceCategoryText { get; set; }
        public string TaxSubjectCode { get; set; }
        public int? BillStatus { get; set; }
        public int? IsEnabled { get; set; }
        public int? PayType { get; set; }
        public string TaxRateText { get; set; }
    }
}
