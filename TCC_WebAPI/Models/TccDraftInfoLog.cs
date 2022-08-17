using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccDraftInfoLog
    {
        public int Id { get; set; }
        public int DraftInfoId { get; set; }
        public int OriginalStatus { get; set; }
        public int NewStatus { get; set; }
        public DateTime OriginalChangeDate { get; set; }
        public DateTime NewChangeDate { get; set; }
        public string CreatorUserLoginName { get; set; }
        public string CreatorUserName { get; set; }
    }
}
