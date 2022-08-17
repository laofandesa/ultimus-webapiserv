using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccHrmHrpDictMap
    {
        public int Id { get; set; }
        public string HrmDictName { get; set; }
        public string HrpDictCode { get; set; }
    }
}
