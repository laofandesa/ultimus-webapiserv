using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ApprovedRecordExtend
    {
        public int Id { get; set; }
        public int? AppRecordId { get; set; }
        public int? AwardRecordId { get; set; }
    }
}
