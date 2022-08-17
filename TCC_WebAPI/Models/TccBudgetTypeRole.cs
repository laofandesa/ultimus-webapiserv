using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetTypeRole
    {
        public int Id { get; set; }
        public int? BdgType { get; set; }
        public string RoleId1 { get; set; }
        public string RoleId2 { get; set; }
    }
}
