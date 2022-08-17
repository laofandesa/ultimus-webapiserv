using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportAboadAbroadUserRecord
    {
        public int Id { get; set; }
        public string CompName { get; set; }
        public string Nationality { get; set; }
        public string VisaType { get; set; }
        public string DeptName { get; set; }
        public string Name { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string RoadInfo { get; set; }
        public string Tvcountry { get; set; }
        public string PassportType { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
    }
}
