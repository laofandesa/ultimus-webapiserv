using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportRequestProcessRequest
    {
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string Id { get; set; }
        public string CodeName { get; set; }
        public string RequestNode { get; set; }
        public string RequestDesc { get; set; }
        public string RequestMethod { get; set; }
        public string CurCurrency { get; set; }
        public string CurRequestAmount { get; set; }
        public string CurRequestAmountUpp { get; set; }
    }
}
