using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPartyValueUser
    {
        public int Id { get; set; }
        public string PersonName { get; set; }
        public int? PersonType { get; set; }
        public string PartyDepCode { get; set; }
        public string Account { get; set; }
        public string PartyDepName { get; set; }
    }
}
