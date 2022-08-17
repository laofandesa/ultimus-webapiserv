using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewSubsidyWarning
    {
        public int? DraftType { get; set; }
        public int? StatusName { get; set; }
        public int SendType { get; set; }
        public int? DraftCode { get; set; }
        public int? Damount { get; set; }
        public int? Cts { get; set; }
        public string LoginName { get; set; }
        public string RequestRealName { get; set; }
        public string RequestUserIdentity { get; set; }
        public DateTime? DueDate { get; set; }
        public string DueDateStr { get; set; }
    }
}
