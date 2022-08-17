using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccBalanceCostTypeSubject
    {
        public int CostTypeId { get; set; }
        public string ProcessName { get; set; }
        public string SubjectCodes { get; set; }
    }
}
