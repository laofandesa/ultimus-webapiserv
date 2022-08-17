using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigPagePermissionsConfiguration
    {
        public int Id { get; set; }
        public string PageUrl { get; set; }
        public int? PageType { get; set; }
        public string StepName { get; set; }
        public int? TaskStatus { get; set; }
        public int? IncidentStatus { get; set; }
        public int? Category { get; set; }
        public int? Enabled { get; set; }
    }
}
