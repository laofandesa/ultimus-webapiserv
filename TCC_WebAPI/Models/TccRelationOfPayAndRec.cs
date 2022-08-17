using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccRelationOfPayAndRec
    {
        public int Id { get; set; }
        public int? PayInfoId { get; set; }
        public string ReceiveId { get; set; }
        public int? AccountStatus { get; set; }
    }
}
