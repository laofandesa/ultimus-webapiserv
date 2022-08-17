using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccTheForthAwardSection2
    {
        public int Id { get; set; }
        public string SectionDesc { get; set; }
        public int? EffectType { get; set; }
        public decimal? MinrSectionValue { get; set; }
        public decimal? MaxSectionValue { get; set; }
        public decimal? Minuend { get; set; }
    }
}
