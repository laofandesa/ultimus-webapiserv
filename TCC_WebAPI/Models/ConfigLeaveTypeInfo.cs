using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigLeaveTypeInfo
    {
        public int Id { get; set; }
        public string TypeId { get; set; }
        public string TypeName { get; set; }
        public string NameDesc { get; set; }
        public string DayDesc { get; set; }
        public string ControlType { get; set; }
        public string DayType { get; set; }
    }
}
