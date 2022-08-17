using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewItopTicket
    {
        public string Ref { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public string Title { get; set; }
        public int? AgentId { get; set; }
        public int? CallerId { get; set; }
        public string Finalclass { get; set; }
        public string AgentUser { get; set; }
        public string CallerUser { get; set; }
        public string OperationalStatus { get; set; }
    }
}
