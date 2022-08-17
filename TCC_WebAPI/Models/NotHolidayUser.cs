using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class NotHolidayUser
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string FormNumber { get; set; }
        public string RequestUserName { get; set; }
        public string DeptNo { get; set; }
        public string DeptName { get; set; }
        public string RealName { get; set; }
        public string UserKey { get; set; }
        public string BeginDate { get; set; }
        public string EndDate { get; set; }
        public decimal? AllDays { get; set; }
        public string ReasonInfo { get; set; }
    }
}
