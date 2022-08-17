using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBidQuotationProjectAwardDetailList
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public decimal? ApproveMoney { get; set; }
        public string SenderUserName { get; set; }
        public string SenderLoginName { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string FormNumber { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectType { get; set; }
        public string ProjectMajor { get; set; }
        public string AwardComposed { get; set; }
        public string AwardComposedCode { get; set; }
        public string SubAward { get; set; }
        public string SubAwardCode { get; set; }
        public string AwardDesc { get; set; }
        public string ReceiverMajor { get; set; }
        public string ReceiverRole { get; set; }
        public string ReceiverUserName { get; set; }
        public string ReceiverUserLoginName { get; set; }
        public string ReceiverUserIdentityId { get; set; }
        public decimal? AwardMoney { get; set; }
        public int? Status { get; set; }
        public DateTime? ArchiveDate { get; set; }
    }
}
