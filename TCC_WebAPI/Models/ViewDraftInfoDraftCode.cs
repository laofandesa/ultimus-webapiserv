using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewDraftInfoDraftCode
    {
        public string DraftCode { get; set; }
        public int? Status { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string SignCode { get; set; }
    }
}
