using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportFinanceRequestProcessForPrintHeader
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string ProjectName { get; set; }
        public string ContantCode { get; set; }
        public string ReceiveDate { get; set; }
        public string ProjectCode { get; set; }
        public string Currency { get; set; }
        public string ReceiveAmount { get; set; }
        public string ReceiveBank { get; set; }
        public string RaceiveAccount { get; set; }
        public string PmCpmpany { get; set; }
        public string Bpbjamount { get; set; }
        public string BpbjamountNotes { get; set; }
        public string DycustCode { get; set; }
        public string TotalAmountGd1 { get; set; }
        public string HwckAmount { get; set; }
        public string HwckAmountNotes { get; set; }
        public string GdCode { get; set; }
        public string TotalAmountGd2 { get; set; }
        public string Thirdamount { get; set; }
        public string ThirdamountNotes { get; set; }
        public string SgAmount { get; set; }
        public string SgAmountNotes { get; set; }
        public string Sg1Amount { get; set; }
        public string Sg1AmountNotes { get; set; }
        public string OtherAmount1 { get; set; }
        public string Other1 { get; set; }
        public string OtherAmount2 { get; set; }
        public string Other2 { get; set; }
        public string ProjectManager { get; set; }
        public string ProjectControler { get; set; }
        public string ProjectSaler { get; set; }
        public string Cwbz { get; set; }
        public string Jbr { get; set; }
        public string Xmcgwlfzr { get; set; }
    }
}
