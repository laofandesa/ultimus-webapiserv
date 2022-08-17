using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccConstructionCostConfirmHeader
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestUserIdentity { get; set; }
        public int? RequestUserPost { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public string RequestTelPhone { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? RequestFinishDate { get; set; }
        public string FormNumber { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectCategory { get; set; }
        public string ProjectJnw { get; set; }
        public decimal? ProjectSchedule { get; set; }
        public decimal? ProjectContractTotalAmount { get; set; }
        public decimal? ReceivedAmount { get; set; }
        public decimal? ReceivedPercentage { get; set; }
        public decimal? Kpjine { get; set; }
        public decimal? SgcontAmount { get; set; }
        public decimal? RenderedBillAmount { get; set; }
        public decimal? ReceiveBillAmount { get; set; }
        public int? ConfirmStatus { get; set; }
        public string ConfirmAuditName { get; set; }
        public string ConfirmAuditLoginName { get; set; }
        public string ConfirmAuditUserIdentity { get; set; }
        public DateTime? ConfirmAuditDate { get; set; }
        public int? AttachmentNum { get; set; }
        public int? Voucherid { get; set; }
    }
}
