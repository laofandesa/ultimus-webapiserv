using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewUltiWarningTaskList
    {
        public string ProcessName { get; set; }
        public int Incident { get; set; }
        public string Requestor { get; set; }
        public string RequestorName { get; set; }
        public DateTime? ProcessBeginDate { get; set; }
        public string Transactor { get; set; }
        public string TransactorName { get; set; }
        public DateTime? TaskBeginDate { get; set; }
    }
}
