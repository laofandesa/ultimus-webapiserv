using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccRecDocReportRelation
    {
        public int Id { get; set; }
        public int? Incident { get; set; }
        public string LeaderType { get; set; }
        public string ZhuBanLeader { get; set; }
        public string DealPerson { get; set; }
        public string XieBanLeader { get; set; }
        public string DeptLeader { get; set; }
    }
}
