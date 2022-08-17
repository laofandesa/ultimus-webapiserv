using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewReportAttachment
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string FileName { get; set; }
        public string StepName { get; set; }
        public string UserName { get; set; }
    }
}
