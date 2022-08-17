using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccContractInfoChangeHistoryLog
    {
        public int Id { get; set; }
        public string ContractCode { get; set; }
        public decimal? Bl { get; set; }
        public decimal? OldAmount { get; set; }
        public decimal? NewAmount { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
