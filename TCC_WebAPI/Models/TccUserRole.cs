using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccUserRole
    {
        public string RoleId { get; set; }
        public string IdcardNo { get; set; }
        public string RoleScopeId { get; set; }
        public string RoleScope { get; set; }
    }
}
