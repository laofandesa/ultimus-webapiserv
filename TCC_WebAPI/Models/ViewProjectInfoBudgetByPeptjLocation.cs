using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewProjectInfoBudgetByPeptjLocation
    {
        public int Id { get; set; }
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int? SubjectId { get; set; }
        public string SubjectName { get; set; }
        public decimal? CostApprove { get; set; }
        public decimal? CostChange { get; set; }
        public decimal? CostChanged { get; set; }
        public string ProjectType { get; set; }
    }
}
