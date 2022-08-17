using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewFinanceTaskBusinessTableOfFp
    {
        public string IDeptName { get; set; }
        public string IDeptCode { get; set; }
        public int? ITypeName { get; set; }
        public int? ITypeCode { get; set; }
        public string ProCode { get; set; }
        public string ProName { get; set; }
        public int? PMethodCode { get; set; }
        public int? PMethodName { get; set; }
        public string Currency { get; set; }
        public int Amount { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string FormCode { get; set; }
        public string CasierClaim { get; set; }
        public int? VoucherId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCode { get; set; }
        public string AuditName { get; set; }
    }
}
