using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewTccAbroadAbroadRecord
    {
        public string Name { get; set; }
        public string UserKey { get; set; }
        public string AimCountry { get; set; }
        public string AimCity { get; set; }
        public string ProjectNo { get; set; }
        public string ProjectName { get; set; }
        public DateTime? LeaveTime { get; set; }
        public DateTime? RleaveTime { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string LeaveCity { get; set; }
    }
}
