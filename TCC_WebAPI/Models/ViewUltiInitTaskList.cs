using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewUltiInitTaskList
    {
        public string ProcessName { get; set; }
        public int Incident { get; set; }
        public DateTime? ProcessBeginDate { get; set; }
        public string Requestor { get; set; }
        public string RequestorName { get; set; }
        public string ProcessStatus { get; set; }
    }
}
