using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccAwardBusinessAprovessHistroy
    {
        public int Id { get; set; }
        public int? RecordId { get; set; }
        public int? IsAgreed { get; set; }
        public string IsAgreedResult { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ApproveUser { get; set; }
        public string ApproveUserRole { get; set; }
        public string AwardCode { get; set; }
    }
}
