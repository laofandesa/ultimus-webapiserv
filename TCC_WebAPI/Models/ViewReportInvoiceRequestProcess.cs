using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportInvoiceRequestProcess
    {
        public string VoucherCode { get; set; }
        public int? VchrnumCode { get; set; }
        public string ProcessName { get; set; }
        public int Incident { get; set; }
        public string Id { get; set; }
        public string RequestFormNumber { get; set; }
        public string RequestRealName { get; set; }
        public DateTime RequestDate { get; set; }
        public string RequestType { get; set; }
        public string RequestPayCategoryName { get; set; }
        public string Telphone { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectContractAmount { get; set; }
        public string ProjectReceivedAmount { get; set; }
        public string ProjectReceivedPct { get; set; }
        public string ProjectCompletePct { get; set; }
        public string ProjectCategory { get; set; }
        public string ProjectCategorySub { get; set; }
        public string SumReceiveAmountSmall { get; set; }
        public string ReceiptAmount { get; set; }
        public string BillAmount { get; set; }
        public string TheApplyCurcencyName { get; set; }
        public string TheApplyReceivedAmount { get; set; }
        public decimal? TheApplyRate { get; set; }
        public DateTime? PlanInAcctDate { get; set; }
        public string PayCmpName { get; set; }
        public string PayCmpPhone { get; set; }
        public string Tariff { get; set; }
        public string PayCmpAddress { get; set; }
        public string PayCmpBank { get; set; }
        public string PayCmpBankAcct { get; set; }
        public string PayCmpBankUnionAcct { get; set; }
        public string BillContent { get; set; }
        public string NotesRemark { get; set; }
        public string TaxRate { get; set; }
        public string SubMoneyOnVat { get; set; }
        public string DesignOfIncome { get; set; }
    }
}
