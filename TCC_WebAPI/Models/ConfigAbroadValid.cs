using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigAbroadValid
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public int? Month { get; set; }
    }
}
