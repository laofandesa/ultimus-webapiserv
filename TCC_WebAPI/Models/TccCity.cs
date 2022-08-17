using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccCity
    {
        public int Id { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }
        public string ParentCity { get; set; }
        public int? CityLevel { get; set; }
    }
}
