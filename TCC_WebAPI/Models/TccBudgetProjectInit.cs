using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetProjectInit
    {
        public int Id { get; set; }
        public string ProjectCode { get; set; }
        public decimal? Amount { get; set; }
        public string SubjectCode { get; set; }
    }
}
