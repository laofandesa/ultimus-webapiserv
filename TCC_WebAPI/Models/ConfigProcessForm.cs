using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigProcessForm
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public string StepName { get; set; }
        public int? IsDefault { get; set; }
        public string FormUrl { get; set; }
    }
}
