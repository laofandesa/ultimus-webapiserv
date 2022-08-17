using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigAwardDispenseType
    {
        public int Id { get; set; }
        public int? DispenseType { get; set; }
        public string AwardComposeCode { get; set; }
        public int? DispenseTime { get; set; }
    }
}
