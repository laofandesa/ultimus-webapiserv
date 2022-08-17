using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewAnuualUserList
    {
        public string SelectUserIdentity { get; set; }
        public string SelectRealName { get; set; }
        public string SelectDeptCode { get; set; }
        public string SelectDeptName { get; set; }
        public string SelectLoginName { get; set; }
        public string IsFanPin { get; set; }
        public string BusinessCard { get; set; }
        public string PostName { get; set; }
        public int PostCode { get; set; }
        public decimal ReimbursementStandard { get; set; }
        public decimal ReimbursementStandard2 { get; set; }
        public string Salary { get; set; }
        public string CardNo { get; set; }
        public string FaFangD { get; set; }
    }
}
