using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewRunningcost
    {
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Name { get; set; }
        public int? Code { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? PaymentDate { get; set; }
    }
}
