using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetMessageConfig
    {
        public int Id { get; set; }
        public int? BdgType { get; set; }
        public string BdgMessage { get; set; }
        public string FormUrl { get; set; }
        public int? IsEnable { get; set; }
        public int? LevelFlag { get; set; }
        public int? SendYear { get; set; }
        public int? SendMonth { get; set; }
        public int? SendDay { get; set; }
    }
}
