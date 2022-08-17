using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccRole
    {
        public Guid Guid { get; set; }
        public string RoleId { get; set; }
        public string RoleDesc { get; set; }
        public string RoleClass { get; set; }
        public string RoleClassId { get; set; }
    }
}
