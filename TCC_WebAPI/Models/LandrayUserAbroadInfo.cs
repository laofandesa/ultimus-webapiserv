using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class LandrayUserAbroadInfo
    {
        public int Sid { get; set; }
        public string Name { get; set; }
        public string UserKey { get; set; }
        public string FormNumber { get; set; }
        public string Tvcountry { get; set; }
        public string RoadInfo { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Id { get; set; }
        public string TaskType { get; set; }
        public int? AbroadSpecType { get; set; }
        public string RequestDeptNo { get; set; }
        public string RequestRealName { get; set; }
        public string ProjectNo { get; set; }
        public string ProjectName { get; set; }
        public string LeaveCountry { get; set; }
        public string LeaveCity { get; set; }
        public string AimCountry { get; set; }
        public string AimCity { get; set; }
        public string Url { get; set; }
    }
}
