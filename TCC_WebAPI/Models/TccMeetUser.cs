using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccMeetUser
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string FormNumber { get; set; }
        public string UserName { get; set; }
        public string UserKey { get; set; }
        public string DeptName { get; set; }
        public string LoginName { get; set; }
        public int? Leader { get; set; }
    }
}
