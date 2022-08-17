using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTsDictPlanItemCount
    {
        public int Id { get; set; }
        public string DeptNo { get; set; }
        public string DeptName { get; set; }
        public string PlanItemCount { get; set; }
        public string TrainYear { get; set; }
    }
}
