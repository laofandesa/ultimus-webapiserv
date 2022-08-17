using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPaymentProcessUpdateInfoByPeptj90
    {
        public int Id { get; set; }
        public DateTime? LogTime { get; set; }
        public string SupplyCode { get; set; }
        public string IncidentList { get; set; }
        public int? ProcessFlag { get; set; }
        public string PeptjFlag { get; set; }
    }
}
