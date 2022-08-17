using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAwardPaymentHistroy
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string AwardReceiver { get; set; }
        public string AwardReceiverLoginName { get; set; }
        public string AwardReceiverIdentityId { get; set; }
        public string AwardComposed { get; set; }
        public string AwardComposedCode { get; set; }
        public decimal? PaymentMoney { get; set; }
        public int? Status { get; set; }
        public string AwardDesc { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string Role { get; set; }
        public string Professional { get; set; }
        public string SenderIdentityId { get; set; }
        public int? ReceiverType { get; set; }
        public int? StepId { get; set; }
        public string ReceiverDeptManager { get; set; }
        public DateTime? ArchiveDate { get; set; }
        public int? NoticeStatus { get; set; }
        public string IsFanPin { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? ParentId { get; set; }
    }
}
