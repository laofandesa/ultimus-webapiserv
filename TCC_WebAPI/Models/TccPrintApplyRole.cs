using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPrintApplyRole
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
