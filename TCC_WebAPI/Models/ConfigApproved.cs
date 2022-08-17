using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigApproved
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public string StepName { get; set; }
        public int? StepId { get; set; }
        public string ApproveResult { get; set; }
    }
}
