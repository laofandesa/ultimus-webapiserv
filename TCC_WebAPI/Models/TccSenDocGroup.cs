using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSenDocGroup
    {
        public int Id { get; set; }
        public int? SenDocGroupId { get; set; }
        public string SenDocGroupName { get; set; }
        public string SenDocGroupType { get; set; }
        public int? Enabled { get; set; }
    }
}
