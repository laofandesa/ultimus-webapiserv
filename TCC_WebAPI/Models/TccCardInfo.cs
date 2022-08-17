using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccCardInfo
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public int? AboutType { get; set; }
        public string FormNumber { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyName { get; set; }
        public string ApplyPhone { get; set; }
        public string ApplyDeptNo { get; set; }
        public string ApplyDept { get; set; }
        public int? ApplyType { get; set; }
        public string CardFloor { get; set; }
        public string CardNo { get; set; }
        public string ApplyRemark { get; set; }
        public string ProjectNo { get; set; }
        public string ProjectName { get; set; }
        public DateTime? CardStartDate { get; set; }
        public DateTime? CardEndDate { get; set; }
        public DateTime? RequestDate { get; set; }
        public string FormNo { get; set; }
        public string CardType { get; set; }
        public string ObtainUser { get; set; }
        public DateTime? ObtainTime { get; set; }
        public decimal? Money { get; set; }
        public DateTime? RepayTime { get; set; }
        public string RepayUser { get; set; }
        public string Operationer { get; set; }
        public int? Carmiles { get; set; }
    }
}
