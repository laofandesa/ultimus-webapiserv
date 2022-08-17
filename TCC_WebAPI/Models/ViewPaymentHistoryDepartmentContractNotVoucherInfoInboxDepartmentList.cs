using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewPaymentHistoryDepartmentContractNotVoucherInfoInboxDepartmentList
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string RequestFormNumber { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public int? Flag { get; set; }
        public decimal? PaymentAmount { get; set; }
        public int? PaymentApplicationCode { get; set; }
        public string PaymentApplicationName { get; set; }
        public string RequestPayCategoryName { get; set; }
    }
}
