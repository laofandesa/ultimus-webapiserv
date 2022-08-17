using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPostingCarryoverRecord
    {
        public int Id { get; set; }
        public int? MainId { get; set; }
        public string TypeName { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? Action { get; set; }
        public string CreateUserName { get; set; }
        public string CreateUserLoginName { get; set; }
        public DateTime? CreateDate1 { get; set; }
        public string Remark { get; set; }
        public int? ResponseFlag { get; set; }
        public string ResponseMessage { get; set; }
        public decimal? DebitMoney { get; set; }
        public decimal? CreditMoney { get; set; }
        public decimal? ShouldPayMoney { get; set; }
        public decimal? ActualPayMoney { get; set; }
        public string FormNumber { get; set; }
        public string JiuqiNumber { get; set; }
    }
}
