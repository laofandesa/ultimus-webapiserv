using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccExpenseClaimAnnualLine
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? Category { get; set; }
        public string SelectRealName { get; set; }
        public string SelectLoginName { get; set; }
        public string SelectUserIdentity { get; set; }
        public string SelectDeptName { get; set; }
        public string SelectDeptCode { get; set; }
        public string BusinessCard { get; set; }
        public string PostName { get; set; }
        public int? PostCode { get; set; }
        public decimal? ReimbursementStandard { get; set; }
        public string Salary { get; set; }
        public string CardNo { get; set; }
        public string FaFangD { get; set; }
    }
}
