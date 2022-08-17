using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetCheckLog
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationCode { get; set; }
        public string DeptOrProject { get; set; }
        public decimal? Amount { get; set; }
        public int? Group { get; set; }
        public int? Control { get; set; }
        public string Json { get; set; }
        public string IsBeyond { get; set; }
        public string Times { get; set; }
    }
}
