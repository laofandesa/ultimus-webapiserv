using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccDraftInfoOperateProcess
    {
        public int Id { get; set; }
        public int? Diid { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public DateTime? ProcessFinishDate { get; set; }
        public DateTime? RequestDate { get; set; }
        public string RequestSfzh { get; set; }
        public string RequestRealName { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public string RequestFormNumber { get; set; }
        public DateTime? AccountingAuditDate { get; set; }
        public string AccountingAuditLoginUserName { get; set; }
        public string AccountingAuditUserName { get; set; }
        public decimal? PaymentDepositRate { get; set; }
        public string PaymentDepositSubjectCode { get; set; }
        public string PaymentDepositSubjectName { get; set; }
        public string PaymentSubjectCode { get; set; }
        public string PaymentSubjectName { get; set; }
        public DateTime? CollectionDate { get; set; }
        public decimal? CollectionAmount { get; set; }
        public string CollectionSubjectCode { get; set; }
        public string CollectionSubjectName { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? DiscountCharges { get; set; }
        public string DiscountBank { get; set; }
        public int? DiscountDay { get; set; }
        public DateTime? DiscountDate { get; set; }
        public string DiscountSubjectCode { get; set; }
        public string DiscountSubjectName { get; set; }
        public int? IsVoucher { get; set; }
        public string VoucherCode { get; set; }
        public int? Voucherid { get; set; }
        public int? Flag { get; set; }
        public int? Attachment { get; set; }
        public int? IsMultiple { get; set; }
        public string Idlist { get; set; }
    }
}
