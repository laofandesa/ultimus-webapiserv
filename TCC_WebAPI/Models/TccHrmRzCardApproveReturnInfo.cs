using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccHrmRzCardApproveReturnInfo
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public string StepName { get; set; }
        public string ReturnPerson { get; set; }
        public string ReturnStatus { get; set; }
        public string ReturnOption { get; set; }
        public string ReturnTime { get; set; }
        public string PmFk { get; set; }
    }
}
