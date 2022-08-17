using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewAbroadUser
    {
        public string Name { get; set; }
        public string UserKey { get; set; }
        public string Tvcountry { get; set; }
        public string RoadInfo { get; set; }
        public string ProjectNo { get; set; }
        public string ProjectName { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
