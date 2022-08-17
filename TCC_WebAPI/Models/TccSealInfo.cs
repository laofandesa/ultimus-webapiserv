using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSealInfo
    {
        public int Id { get; set; }
        public int? Incident { get; set; }
        public string SealName { get; set; }
        public string ApplyRemark { get; set; }
        public string FormNumber { get; set; }
        public string SealStartDate { get; set; }
        public string SealEndDate { get; set; }
        public string UsePerson { get; set; }
        public DateTime? ObtainTime { get; set; }
        public DateTime? RepayTime { get; set; }
        public string RepayUser { get; set; }
        public int? FileId { get; set; }
        public string SealType { get; set; }
    }
}
