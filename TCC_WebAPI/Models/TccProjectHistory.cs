using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProjectHistory
    {
        public int Id { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ContractType { get; set; }
        public string ProjectCategory { get; set; }
        public string ProjectStatus { get; set; }
        public decimal? ContractAmount { get; set; }
        public decimal? ContractAfterChangeAmount { get; set; }
        public string ContractUnit { get; set; }
        public decimal? ReceivablesAmount { get; set; }
        public decimal? RemainingAmount { get; set; }
        public decimal? AwardAmountTotal { get; set; }
        public decimal? AwardAuditAmount { get; set; }
        public decimal? AwardPayAmount { get; set; }
    }
}
