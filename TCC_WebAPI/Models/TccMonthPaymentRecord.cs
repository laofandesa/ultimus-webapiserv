using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccMonthPaymentRecord
    {
        public int Id { get; set; }
        public int? VchrId { get; set; }
        public int? ItemOrder { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public string Digest { get; set; }
        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }
        public string DeptName { get; set; }
        public string DeptCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCode { get; set; }
        public string SupplierName { get; set; }
        public string SupplierCode { get; set; }
        public string SetTlementName { get; set; }
        public string SetTlementCode { get; set; }
        public int? Flag { get; set; }
        public string NewSalaryVest { get; set; }
        public string SalaryVest { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Currencycode { get; set; }
        public decimal? Exchrate { get; set; }
        public decimal? Orgnd { get; set; }
        public decimal? Orgnc { get; set; }
        public string ProjectCode { get; set; }
        public string Type { get; set; }
        public string UserIdentityId { get; set; }
        public string ProjectName { get; set; }
        public string StaffCode { get; set; }
        public string StaffName { get; set; }
        public int? Qty { get; set; }
        public decimal? Price { get; set; }
        public string BizNo { get; set; }
        public DateTime? BizDate { get; set; }
        public DateTime? SettlementDate { get; set; }
        public string SlCode { get; set; }
        public string SlName { get; set; }
        public string Gbcode { get; set; }
        public string Gbname { get; set; }
    }
}
