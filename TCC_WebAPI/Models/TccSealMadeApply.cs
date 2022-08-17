using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSealMadeApply
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyName { get; set; }
        public string ApplyPhone { get; set; }
        public string ApplyDeptNo { get; set; }
        public string ApplyDept { get; set; }
        public int? ApplyType { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string SealType { get; set; }
        public string ProjectNo { get; set; }
        public string ProjectName { get; set; }
        public string Demo1 { get; set; }
        public string Demo2 { get; set; }
        public string FormNumber { get; set; }
        public int? SpecialSealType { get; set; }
        public int? IsNew { get; set; }
    }
}
