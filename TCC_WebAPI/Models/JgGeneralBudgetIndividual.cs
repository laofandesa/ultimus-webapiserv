using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class JgGeneralBudgetIndividual
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? AccountId { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public int? PAccountId { get; set; }
        public string PAccountCode { get; set; }
        public string PAccountName { get; set; }
        public string SecAccountName { get; set; }
        public string FirAccountName { get; set; }
        public int? AccountLevel { get; set; }
        public decimal? BudgetAmount { get; set; }
        public string Remark { get; set; }
    }
}
