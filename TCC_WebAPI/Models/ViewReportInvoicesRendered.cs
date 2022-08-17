using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportInvoicesRendered
    {
        public int Id { get; set; }
        public int? VchrnumCode { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string FormNumber { get; set; }
        public string RequestRealName { get; set; }
        public DateTime? RequestDate { get; set; }
        public string RequestTelephone { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectContractTotalAmount { get; set; }
        public string ReceivedAmount { get; set; }
        public string ReceivedPercentage { get; set; }
        public string ProjectSchedule { get; set; }
        public string ProjectCategory { get; set; }
        public string BName { get; set; }
        public string OwnerCategory { get; set; }
        public string OwnerName { get; set; }
        public string InvoiceCategoryText { get; set; }
        public string AggregateRenInvoiceAmount { get; set; }
        public string AggregateRenReceiptAmount { get; set; }
        public string InvoiceTotalAmount { get; set; }
        public string PayCompanyName { get; set; }
        public string PayCompanyTaxId { get; set; }
        public string PayCompanyAddress { get; set; }
        public string PayBankAccount { get; set; }
        public string PayBankName { get; set; }
        public string RenderedCategoryText { get; set; }
        public string PayCompanyPhone { get; set; }
        public string PayUnitedBankNumber { get; set; }
        public string BillContent { get; set; }
    }
}
