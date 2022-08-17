using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigPaymentCategorySubjectCodeForTaxRate
    {
        public int Id { get; set; }
        public int? Category { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectType { get; set; }
        public int? BillStatus { get; set; }
        public int? IsEnabled { get; set; }
        public int? PayType { get; set; }
        public int? PayCategory { get; set; }
        public int? PayType2 { get; set; }
        public string TaxRateText { get; set; }
    }
}
