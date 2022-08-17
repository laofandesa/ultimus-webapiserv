using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaymentProcessInit
    {
        public int Id { get; set; }
        public string RequestFormNumber { get; set; }
        public string RequestSfzh { get; set; }
        public string RequestDeptCode { get; set; }
        public string RequestDeptName { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public int? RequestPayCategory { get; set; }
        public string RequestPayCategoryName { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCode { get; set; }
        public string RequestRealName { get; set; }
        public string RequestloginName { get; set; }
        public decimal? PaymentAmount { get; set; }
        public decimal? PaymentAmountRmb { get; set; }
        public string Currency { get; set; }
        public decimal? Exchange { get; set; }
    }
}
