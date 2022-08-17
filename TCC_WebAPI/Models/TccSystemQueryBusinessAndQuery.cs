using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSystemQueryBusinessAndQuery
    {
        public int Id { get; set; }
        public string BelongSystem { get; set; }
        public string ProcessName { get; set; }
        public string BusinessName { get; set; }
        public string AccessPath { get; set; }
        public string AccessLink { get; set; }
        public string BusinessKind { get; set; }
        public string UserName { get; set; }
        public string UserAccount { get; set; }
        public string UserIdcardNo { get; set; }
        public string Remark { get; set; }
    }
}
