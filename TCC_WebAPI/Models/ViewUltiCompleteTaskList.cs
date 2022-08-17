using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewUltiCompleteTaskList
    {
        public string ProcessName { get; set; }
        public int Incident { get; set; }
        public string Requestor { get; set; }
        public string RequestorName { get; set; }
        public DateTime? TaskEndDate { get; set; }
        public string Transactor { get; set; }
        public string TransactorName { get; set; }
        public string ProcessStatus { get; set; }
    }
}
