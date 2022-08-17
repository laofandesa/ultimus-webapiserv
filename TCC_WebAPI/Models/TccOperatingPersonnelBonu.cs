using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccOperatingPersonnelBonu
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string AwardCategory { get; set; }
        public string DeptName { get; set; }
        public string DeptNo { get; set; }
        public string SelectName { get; set; }
        public string AssignFromDept { get; set; }
        public string AssignFromDeptName { get; set; }
        public string WorkContent { get; set; }
        public string Level { get; set; }
        public decimal? AwardAmount { get; set; }
        public string IsFanPin { get; set; }
        public string UserIdentity { get; set; }
        public string PersonLoginName { get; set; }
        public int? Flag { get; set; }
    }
}
