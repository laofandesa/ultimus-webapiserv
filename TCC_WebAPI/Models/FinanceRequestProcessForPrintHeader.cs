using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class FinanceRequestProcessForPrintHeader
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ContantCode { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public string Currency { get; set; }
        public decimal? ReceiveAmount { get; set; }
        public string ReceiveBank { get; set; }
        public string RaceiveAccount { get; set; }
        public string PmCpmpany { get; set; }
        public decimal? Bpbjamount { get; set; }
        public string DycustCode { get; set; }
        public decimal? TotalAmountGd1 { get; set; }
        public decimal? HwckAmount { get; set; }
        public string GdCode { get; set; }
        public decimal? TotalAmountGd2 { get; set; }
        public decimal? Thirdamount { get; set; }
        public decimal? SgAmount { get; set; }
        public decimal? Sg1Amount { get; set; }
        public decimal? OtherAmount1 { get; set; }
        public string Other1 { get; set; }
        public decimal? OtherAmount2 { get; set; }
        public string Other2 { get; set; }
        public string Incidents { get; set; }
    }
}
