using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigAbroadAtt
    {
        public int Id { get; set; }
        public string AfileName { get; set; }
        public string AfileNameId { get; set; }
        public int? AttOption { get; set; }
        public string AttRequire { get; set; }
        public int? AbroadType { get; set; }
        public string AbroadTypeName { get; set; }
    }
}
