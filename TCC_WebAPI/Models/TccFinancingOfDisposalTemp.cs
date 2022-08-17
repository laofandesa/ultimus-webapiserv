using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccFinancingOfDisposalTemp
    {
        public int Id { get; set; }
        public int Pid { get; set; }
        public string EquityProjectName { get; set; }
        public DateTime? InvestmentTime { get; set; }
        public decimal? InvestmentAmount { get; set; }
        public decimal? BookValue { get; set; }
        public string DisposalReasons { get; set; }
        public string DisposalMethod { get; set; }
        public decimal? Disposallosses { get; set; }
        public string IsApproved { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
    }
}
