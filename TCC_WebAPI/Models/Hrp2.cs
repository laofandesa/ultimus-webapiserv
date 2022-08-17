using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class Hrp2
    {
        public int Id { get; set; }
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Xmjl { get; set; }
        public string Isfinish { get; set; }
        public string ProjectCategory { get; set; }
        public string ContractType { get; set; }
        public string Addr { get; set; }
    }
}
