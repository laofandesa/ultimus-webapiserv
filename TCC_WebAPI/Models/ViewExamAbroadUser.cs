using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewExamAbroadUser
    {
        public string FormNumber { get; set; }
        public string FlowStatus { get; set; }
        public string RequestRealName { get; set; }
        public string RequestTelephone { get; set; }
        public int SId { get; set; }
        public string Tvcountry { get; set; }
        public string DeptName { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string UserKey { get; set; }
        public DateTime? RequestDate { get; set; }
        public string BeginDate { get; set; }
        public string EndDate { get; set; }
    }
}
