using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccDraft
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string Requestor { get; set; }
        public string AwardCategory { get; set; }
        public string DraftContent { get; set; }
    }
}
