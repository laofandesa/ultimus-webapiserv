using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBudgetBasicAccountInfo
    {
        public int Sid { get; set; }
        public string Guid { get; set; }
        public int Flag { get; set; }
        public string BdgCode { get; set; }
        public string BdgName { get; set; }
        public string ParentBdgCode { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
