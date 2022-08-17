using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class ConfigSpecialStandard
    {
        public int Id { get; set; }
        public string SpecialType { get; set; }
        public string Country { get; set; }
        public double? Modulus { get; set; }
        public double? ModulusDay { get; set; }
        public double? ModulusMonth { get; set; }
        public int? PostGrade { get; set; }
        public decimal? SocialRatio { get; set; }
        public decimal? TaxRatio { get; set; }
        public string CurcencyAb { get; set; }
        public string CurcencyName { get; set; }
        public decimal? DocGt90 { get; set; }
        public decimal? OsLte120 { get; set; }
        public decimal? OsGt150 { get; set; }
        public string MaintenDate { get; set; }
        public string MaxDate { get; set; }
    }
}
