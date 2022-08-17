using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class Budget
    {
        public int Id { get; set; }
        public string Projectcode { get; set; }
        public string Projectname { get; set; }
        public string Budgetid { get; set; }
        public string Budgetname { get; set; }
        public decimal? Money { get; set; }
        public string Year { get; set; }
        public string Updateed { get; set; }
        public decimal? HasTheAmount { get; set; }
        public decimal? RemainMoney { get; set; }
    }
}
