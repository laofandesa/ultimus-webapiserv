using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccInvoicesAccountDetail
    {
        public int Id { get; set; }
        public string Requestor { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public string LinkProcessName { get; set; }
        public int? LinkIncident { get; set; }
        public int? LinkId { get; set; }
    }
}
