using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_CoreApi.Model.entity
{
    public partial class LandrayCashierTaskFpInbox
    {
        public int Id { get; set; }
        public string TaskId { get; set; }
        public string PName { get; set; }
        public int? Incident { get; set; }
        public string SName { get; set; }
        public string TUser { get; set; }
        public DateTime? TBeginTime { get; set; }
        public DateTime? TEndTime { get; set; }
        public string IUser { get; set; }
        public DateTime? IBeginTime { get; set; }
        public DateTime? IEndTime { get; set; }
        public string IDeptName { get; set; }
        public string IDeptCode { get; set; }
        public string ITypeName { get; set; }
        public string ITypeCode { get; set; }
        public string ProCode { get; set; }
        public string ProName { get; set; }
        public string pMethodCode { get; set; }
        public string pMethodName { get; set; }
        public string Currency { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? CreateTime { get; set; }
        public string FormCode { get; set; }
        public string CasierClaim { get; set; }
        public int? FinFlag { get; set; }
        public int? TuiFlag { get; set; }
        public string Vchrnum { get; set; }
        public int? IsVoucher { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCode { get; set; }
        public string AuditName { get; set; }
        public int? MsgSendCts { get; set; }
        public DateTime? MsgSendTime { get; set; }
        public DateTime? Requestdate { get; set; }
        public string Rate { get; set; }
        public string Billtype { get; set; }
        public string Tobilltype { get; set; }
        public string Billcontent { get; set; }
        public decimal? BillAmount { get; set; }
        public decimal? ReceiptAmount { get; set; }
        public int? FinanceStatus { get; set; }
        public string AccountReceiveCmpCode { get; set; }
        public string AccountReceiveCmpName { get; set; }
        public string BillCode { get; set; }
        public string IsTs { get; set; }
        public string BillContentType { get; set; }
        public int? IsHaveBill { get; set; }
        public int? IsPay { get; set; }
        public int? Flag { get; set; }
    }
}
