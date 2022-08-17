using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPurchaseBudgetBased
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string EncodingParents { get; set; }
        public int? IsLastNode { get; set; }
        public string DeptRange { get; set; }
        public string ManageDept { get; set; }
    }
}
