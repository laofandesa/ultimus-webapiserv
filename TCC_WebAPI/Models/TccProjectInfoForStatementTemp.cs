using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProjectInfoForStatementTemp
    {
        public long Id { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public decimal? ProjectContractAmountShow { get; set; }
        public decimal? ProjectPaymentContractTotalAmountShow { get; set; }
        public decimal? ProjectReceivedAmountShow { get; set; }
        public decimal? ProjectReceivedPercentageShow { get; set; }
        public decimal? ProjectPaymentAmountShow { get; set; }
        public decimal? ContractPaymentTotal { get; set; }
        public decimal? ProjectManagementCostShow { get; set; }
        public decimal? ProjectNeiBuRenGongFeiShow { get; set; }
        public decimal? ProjectProfitMarginWithoutHuman { get; set; }
        public decimal? ProjectProfitMarginShow { get; set; }
        public decimal? ProjectOtherCostShow { get; set; }
    }
}
