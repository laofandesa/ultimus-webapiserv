using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccHrpVoteCode
    {
        public int Id { get; set; }
        public string UserGroup { get; set; }
        public string CodeName { get; set; }
        public string CodeValue { get; set; }
        public int? SerialNumber { get; set; }
    }
}
