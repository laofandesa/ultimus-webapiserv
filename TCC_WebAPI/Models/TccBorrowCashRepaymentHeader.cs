using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBorrowCashRepaymentHeader
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestUserIdentity { get; set; }
        public string RequestUserPost { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public string RequestTelPhone { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? RequestFinishDate { get; set; }
        public string FormNumber { get; set; }
        public int? Agency { get; set; }
        public string VisaUserPost { get; set; }
        public string VisaRealName { get; set; }
        public string VisaLoginName { get; set; }
        public string VisaUserIdentity { get; set; }
        public string VisaDeptCode { get; set; }
        public string VisaDeptName { get; set; }
        public string CardNo { get; set; }
        public string BussinessCard { get; set; }
        public int? BorrowType { get; set; }
        public string BorrowTypeText { get; set; }
        public int? HaveBorrow { get; set; }
        public string HaveBorrowText { get; set; }
        public string Remark { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public int? Voucherid { get; set; }
        public string ConfirmFinaceName { get; set; }
        public string ConfirmFinaceLoginName { get; set; }
        public string ConfirmFinaceUserIdentity { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public string ConfirmAuditName { get; set; }
        public string ConfirmAuditLoginName { get; set; }
        public string ConfirmAuditUserIdentity { get; set; }
        public DateTime? ConfirmAuditDate { get; set; }
        public int? AttachmentNum { get; set; }
        public string PaymentName { get; set; }
        public int? Location { get; set; }
        public string AdressLocation { get; set; }
    }
}
