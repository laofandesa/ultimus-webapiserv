using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBasicData20181122
    {
        public int Id { get; set; }
        public string Flag { get; set; }
        public string FlagName { get; set; }
        public int? DomOrOver { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string OwnerDept { get; set; }
        public int? SortField { get; set; }
    }
}
