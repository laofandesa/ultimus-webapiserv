using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigAbroadInsStandard
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public string CompanyName { get; set; }
        public DateTime? ValidStdate { get; set; }
        public DateTime? ValidEddate { get; set; }
        public decimal? InsDayStardard { get; set; }
        public decimal? InsYearStardard { get; set; }
    }
}
