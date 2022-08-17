using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigMonthlyPlanApplicationInfo
    {
        public int Id { get; set; }
        public int ApplicationCode { get; set; }
        public string ApplicationName { get; set; }
        public int ApplicationType { get; set; }
        public int ControlType { get; set; }
        public int ProjectType { get; set; }
    }
}
