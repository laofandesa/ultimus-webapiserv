using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBusinessTripPersonDetail
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string LoginName { get; set; }
        public string RealName { get; set; }
        public int? Status { get; set; }
        public string IdcardDno { get; set; }
        public int? IsReimbursed { get; set; }
        public DateTime? TheReimbursementBeginTime { get; set; }
        public DateTime? TheReimbursementEndTime { get; set; }
        public int? TheReimbursementDays { get; set; }
        public int? SignMarked { get; set; }
    }
}
