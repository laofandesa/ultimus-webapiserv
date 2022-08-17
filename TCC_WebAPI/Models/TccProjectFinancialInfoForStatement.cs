using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProjectFinancialInfoForStatement
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string ProjectCode { get; set; }
        public decimal ReceiveAmount { get; set; }
        public decimal PayAmount { get; set; }
        public decimal ContractPayAmount { get; set; }
        public decimal ManagerFee { get; set; }
        public decimal ProjectMargin { get; set; }
    }
}
