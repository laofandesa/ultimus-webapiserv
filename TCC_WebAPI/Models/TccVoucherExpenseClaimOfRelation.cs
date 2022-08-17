using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccVoucherExpenseClaimOfRelation
    {
        public int Id { get; set; }
        public int? ExpenseClaimId { get; set; }
        public int? ExpenseClaimStatus { get; set; }
        public int? Voucherid { get; set; }
    }
}
