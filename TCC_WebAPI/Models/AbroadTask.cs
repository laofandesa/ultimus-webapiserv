using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class AbroadTask
    {
        public int Id { get; set; }
        public string TaskInfo { get; set; }
        public int? NIndex { get; set; }
        public int? Type { get; set; }
        public string SId { get; set; }
        public string TaskId { get; set; }
    }
}
