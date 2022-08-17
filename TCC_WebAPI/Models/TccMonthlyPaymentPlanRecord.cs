using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccMonthlyPaymentPlanRecord
    {
        public int Id { get; set; }
        public string ProjectCode { get; set; }
        public int ControlFlag { get; set; }
        public int ControlYear { get; set; }
        public int ControlMonth { get; set; }
        public int RequestType { get; set; }
        public string RequestName { get; set; }
        public decimal BudgetAmount { get; set; }
        public decimal HappenedAmount { get; set; }
        public decimal RemainAmount { get; set; }
        public string Description { get; set; }
    }
}
