using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProjectAdvanReceivedHistory
    {
        public int Id { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectType { get; set; }
        public string ProjectManager { get; set; }
        public string ProjectManagerLoginName { get; set; }
        public string ProjectManagerIdentityId { get; set; }
        public string ContractCode { get; set; }
        public string ContractName { get; set; }
        public decimal? ContractAmount { get; set; }
        public string ReceiveType { get; set; }
        public decimal? ReceiveAmount { get; set; }
        public string Currency { get; set; }
        public int? ReceivedBatch { get; set; }
        public DateTime? ReceivedDate { get; set; }
    }
}
