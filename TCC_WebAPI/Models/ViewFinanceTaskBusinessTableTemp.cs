﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewFinanceTaskBusinessTableTemp
    {
        public string IDeptName { get; set; }
        public string IDeptCode { get; set; }
        public string ITypeName { get; set; }
        public int? ITypeCode { get; set; }
        public string ProCode { get; set; }
        public string ProName { get; set; }
        public int? PMethodCode { get; set; }
        public string PMethodName { get; set; }
        public string Currency { get; set; }
        public decimal? Amount { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string FormCode { get; set; }
        public string CasierClaim { get; set; }
        public int? VoucherId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCode { get; set; }
        public string AuditName { get; set; }
        public int Zbbt { get; set; }
        public decimal? AmountBj { get; set; }
        public string CasierClaimBj { get; set; }
        public string AuditNameBj { get; set; }
        public string RequestLoginName { get; set; }
        public string RequestRealName { get; set; }
    }
}
