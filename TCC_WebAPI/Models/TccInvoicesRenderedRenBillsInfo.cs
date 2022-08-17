using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccInvoicesRenderedRenBillsInfo
    {
        public int Id { get; set; }
        public string Requestor { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string RecFormNumber { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string OwnerCode { get; set; }
        public string OwnerName { get; set; }
        public DateTime? RenInvoiceDate { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestIdentity { get; set; }
        public decimal? RecAmount { get; set; }
        public decimal? RenInvoicesAmount { get; set; }
        public decimal? RenBillsAmount { get; set; }
        public string PayBankAccount { get; set; }
        public string PayCompanyCode { get; set; }
        public string PayCompanyName { get; set; }
        public decimal? RecActualAmount { get; set; }
        public string TransactorLoginName { get; set; }
        public string TransactorRealName { get; set; }
        public string TransactorIdentity { get; set; }
        public int? BillStatus { get; set; }
        public int? InvoiceCategoryValue { get; set; }
        public string InvoiceCategoryText { get; set; }
        public decimal? EquipmentParagraph { get; set; }
        public decimal? ConstructionParagraph { get; set; }
        public decimal? DesignParagraph { get; set; }
        public decimal? ServicesParagraph { get; set; }
    }
}
