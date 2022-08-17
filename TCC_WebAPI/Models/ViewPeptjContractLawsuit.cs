using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewPeptjContractLawsuit
    {
        public string Account { get; set; }
        public DateTime? Ddate { get; set; }
        public string ProjId { get; set; }
        public string Htbh { get; set; }
        public string Skdwmc { get; set; }
        public string ContType { get; set; }
        public Guid? ContRegHumSid { get; set; }
    }
}
