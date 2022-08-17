using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccComputerInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ComputerType { get; set; }
        public string ComputerStatus { get; set; }
        public int? ComputerYear { get; set; }
        public string AssetId { get; set; }
        public string DeptName { get; set; }
    }
}
