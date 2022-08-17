using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccExpenseBudget
    {
        public int Id { get; set; }
        public int? Flag { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? ExpenseCategory { get; set; }
        public decimal? Money { get; set; }
        public string CreateUserLoginName { get; set; }
        public string CreateUserRealName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateUserLoginName { get; set; }
        public string UpdateUserRealName { get; set; }
        public DateTime? UpdateDate { get; set; }
        public decimal? RemainMoney { get; set; }
    }
}
