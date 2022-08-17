using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProposalDict
    {
        public int Id { get; set; }
        public int? PType { get; set; }
        public string DicDes { get; set; }
        public string DicValue { get; set; }
    }
}
