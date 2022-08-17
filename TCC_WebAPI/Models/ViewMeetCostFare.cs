using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewMeetCostFare
    {
        public int Id { get; set; }
        public string UseDept { get; set; }
        public string UseDeptId { get; set; }
        public string ProjectNo { get; set; }
        public string ProjectName { get; set; }
        public string ProjectManagerName { get; set; }
        public string DeptManagerName { get; set; }
        public int? ApplyType { get; set; }
        public decimal? MeetCost { get; set; }
        public int? MeetYear { get; set; }
        public int? MeetQuarter { get; set; }
        public DateTime? RequestDate { get; set; }
    }
}
