using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccExpenseCategory
    {
        public int Id { get; set; }
        public string ExpenseCode { get; set; }
        public string ExpenseName { get; set; }
        public string CreateUserLoginName { get; set; }
        public string CreateUserRealName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateUserLoginName { get; set; }
        public string UpdateUserRealName { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
