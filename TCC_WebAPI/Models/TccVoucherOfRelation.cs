using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccVoucherOfRelation
    {
        public int Id { get; set; }
        public string RProName { get; set; }
        public int? RIncident { get; set; }
        public int? RStatus { get; set; }
        public int RVoucherId { get; set; }
    }
}
