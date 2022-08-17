using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class CopiedIncident
    {
        public string Processname { get; set; }
        public string Processversion { get; set; }
        public int Incident { get; set; }
        public string Priority { get; set; }
        public string Summary { get; set; }
        public DateTime? Starttime { get; set; }
        public DateTime? Endtime { get; set; }
        public int? Status { get; set; }
        public string Initiator { get; set; }
    }
}
