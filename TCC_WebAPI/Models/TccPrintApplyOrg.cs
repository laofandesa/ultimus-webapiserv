using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccPrintApplyOrg
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public string OrgName { get; set; }
        public int? OrgParId { get; set; }
        public string OrgParName { get; set; }
    }
}
