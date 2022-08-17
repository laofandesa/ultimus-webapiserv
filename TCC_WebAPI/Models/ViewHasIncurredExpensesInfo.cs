using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewHasIncurredExpensesInfo
    {
        public string ProjectCode { get; set; }
        public string ExpensesName { get; set; }
        public decimal? Amount { get; set; }
    }
}
