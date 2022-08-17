using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccItProject
    {
        public int Id { get; set; }
        public Guid? Sid { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public int? ProjectState { get; set; }
        public DateTime? RequestDate { get; set; }
    }
}
