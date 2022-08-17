using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewProjectInfoBudgetByPeptj
    {
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public long? SubjectId { get; set; }
        public string SubjectName { get; set; }
        public double CostApprove { get; set; }
        public double CostChange { get; set; }
        public double CostChanged { get; set; }
        public string ProjectType { get; set; }
    }
}
