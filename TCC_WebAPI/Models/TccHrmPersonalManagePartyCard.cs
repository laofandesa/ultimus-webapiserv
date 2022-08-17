using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccHrmPersonalManagePartyCard
    {
        public int Id { get; set; }
        public string PoliticalStatusId { get; set; }
        public string PoliticalStatus { get; set; }
        public string JoinTime { get; set; }
        public string WorkPlace { get; set; }
        public string Introducer { get; set; }
        public string Zztime { get; set; }
        public int PmFk { get; set; }
        public string RzPartyZb { get; set; }
        public string RzPartyZbid { get; set; }
        public string RzPartyZw { get; set; }
        public string RzPartyZwid { get; set; }
    }
}
