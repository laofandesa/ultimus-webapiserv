using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ViewRoleAuthorityRelation
    {
        public string Roleid { get; set; }
        public string IdcardNo { get; set; }
        public string Flag { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
    }
}
