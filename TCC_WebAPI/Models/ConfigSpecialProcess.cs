using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigSpecialProcess
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public string StepName { get; set; }
    }
}
