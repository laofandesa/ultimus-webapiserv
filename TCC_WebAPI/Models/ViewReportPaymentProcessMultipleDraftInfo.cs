using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportPaymentProcessMultipleDraftInfo
    {
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int Id { get; set; }
        public string DraftType { get; set; }
        public string DraftCode { get; set; }
        public string DraftAmount { get; set; }
        public string DraftAmountChineseNumeral { get; set; }
        public string PayingBankName { get; set; }
        public string ResponsiblePerson { get; set; }
        public string ResponsibleSfzh { get; set; }
    }
}
