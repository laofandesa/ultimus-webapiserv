using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewDraftInfoWarning
    {
        public string DraftType { get; set; }
        public string StatusName { get; set; }
        public int SendType { get; set; }
        public string DueDateStr { get; set; }
        public DateTime? DueDate { get; set; }
        public string DraftCode { get; set; }
        public decimal? Damount { get; set; }
        public int? Cts { get; set; }
    }
}
