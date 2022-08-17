using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccRoleAuthorityRelation
    {
        public int Id { get; set; }
        public string Roleid { get; set; }
        public string IdcardNo { get; set; }
        public string Falg { get; set; }
        public int? Code { get; set; }
        public string Name { get; set; }
    }
}
