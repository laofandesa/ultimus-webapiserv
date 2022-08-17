using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigLeaveInfoStep
    {
        public int Id { get; set; }
        public int? UserType { get; set; }
        public string UserTypeName { get; set; }
        public string TypeId { get; set; }
        public string TypeName { get; set; }
        public decimal? StartApplyDays { get; set; }
        public decimal? EndApplyDays { get; set; }
        public int? CompUnion { get; set; }
        public int? GroupLeader { get; set; }
        public int? DeptLeader { get; set; }
        public int? ResourceSupervise { get; set; }
        public int? ResourceLeader { get; set; }
        public int? SupervLeader { get; set; }
        public int? GeneralLeader { get; set; }
        public int? Chairman { get; set; }
    }
}
