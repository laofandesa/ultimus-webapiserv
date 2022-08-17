using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class HrpVisitRele
    {
        public string DeptName { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string UserKey { get; set; }
        public DateTime? MStartDate { get; set; }
        public DateTime? EEndDate { get; set; }
        public string Mreason { get; set; }
    }
}
