using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigBudgetApplicationLink
    {
        public int Id { get; set; }
        public string ApYear { get; set; }
        public string Item2 { get; set; }
        public string Item3 { get; set; }
        public string ApplicationName { get; set; }
        public int? ApplicationCode { get; set; }
        public int? RunningCost { get; set; }
        public int? IsControl { get; set; }
        public int? Flag { get; set; }
        public string SubjectType { get; set; }
        public string Item2Yf { get; set; }
        public int? SubjectId { get; set; }
        public int? CbyGroup { get; set; }
    }
}
