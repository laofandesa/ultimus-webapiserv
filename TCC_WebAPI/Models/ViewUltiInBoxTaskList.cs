using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewUltiInBoxTaskList
    {
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string Requestor { get; set; }
        public string RequestorName { get; set; }
        public string Transactor { get; set; }
        public string TransactorName { get; set; }
        public DateTime? ProcessBeginDate { get; set; }
        public int? Status { get; set; }
        public string Type { get; set; }
        public int? Level { get; set; }
        public string TaskId { get; set; }
    }
}
