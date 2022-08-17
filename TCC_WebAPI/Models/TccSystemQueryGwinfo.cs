using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSystemQueryGwinfo
    {
        public int Id { get; set; }
        public int StepInfoFk { get; set; }
        public string GwId { get; set; }
        public string GwName { get; set; }
        public string GwKindName { get; set; }
    }
}
