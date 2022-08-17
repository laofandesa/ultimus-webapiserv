using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewBudgetProjectHappenedRunningCostDetail
    {
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string SubjectName { get; set; }
        public int? SubjectId { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int Flag { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
    }
}
