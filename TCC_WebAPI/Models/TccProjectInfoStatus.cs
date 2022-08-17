using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccProjectInfoStatus
    {
        public int Id { get; set; }
        public string ProjectCode { get; set; }
        public int? Status { get; set; }
    }
}
