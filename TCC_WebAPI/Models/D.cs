using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class D
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string FormNumber { get; set; }
        public string CompName { get; set; }
        public string DeptNo { get; set; }
        public string DeptName { get; set; }
        public string Name { get; set; }
        public int? Sex { get; set; }
        public string Mobile { get; set; }
        public string UserKey { get; set; }
        public string FlightNo { get; set; }
        public string LeaveCountry { get; set; }
        public string LeaveCity { get; set; }
        public string PassCountry { get; set; }
        public string PassCity { get; set; }
        public string AimCountry { get; set; }
        public string AimCity { get; set; }
        public int? FlagType { get; set; }
        public DateTime? LeaveTime { get; set; }
        public DateTime? AimTime { get; set; }
        public DateTime? RequestTime { get; set; }
        public string RflightNo { get; set; }
        public DateTime? RleaveTime { get; set; }
        public DateTime? RaimTime { get; set; }
        public string RleaveCountry { get; set; }
        public string RleaveCity { get; set; }
        public string RpassCountry { get; set; }
        public string RpassCity { get; set; }
        public string RaimCountry { get; set; }
        public string RaimCity { get; set; }
        public int? Flag { get; set; }
    }
}
