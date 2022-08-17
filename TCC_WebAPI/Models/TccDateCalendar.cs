using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccDateCalendar
    {
        public int Id { get; set; }
        public DateTime? DataTime { get; set; }
        public string Status { get; set; }
    }
}
